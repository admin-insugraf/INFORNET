create procedure [dbo].[INV_RPT_KARDEX_VAL]
		@pc nvarchar(80),@opcion char(1),
		@mes char(2),@anyo char(4),
		@codini char(20),@codfin char(20),
		@tipoart char(4),
		@anyomesant char(6),@anyomes char(6)
as
	declare @STRquery nvarchar(2500)
	declare @tabla nvarchar(80)
	declare @staanul char(1),@guiasal char(2),@guiafac char(2)
	declare @stafac char(1),@isno char(1),@texto char(5)
	declare @filtro nvarchar(200)

	if @opcion='0' --crea temporal
		begin
		   if exists(select * from tempdb.dbo.sysobjects where name=@pc)
		      begin
		         set @tabla=N'[tempdb].dbo.'+@pc
		         set @STRquery='drop table '+ @tabla
		         	exec sp_executesql @STRquery,N'@pc nvarchar(80),@opcion char(1)',
								@pc,@opcion
		      end
			set @tabla='[tempdb].dbo.'+@pc
			set @STRquery='create table '+@tabla+ '(PART_ID varchar(20),
				DOCUMENT_DATE smalldatetime,HOUR varchar(8),
				TRANS_ID varchar(2),TYPE_TRANS varchar(2),NUMBER_DOC varchar(20),QTY float,
				UNIT_PRICE float,AVERAGE_COST float,STOCK_BALANCE float,FAMILY_ID varchar(10),
				IS_SER_LOT varchar(20),IS_POST bit default(0),IN_OUT varchar(20),
				WAREHOUSE_ID varchar(2),ITEM int)'
			exec sp_executesql @STRquery,N'@pc nvarchar(80),@opcion char(1)',
								@pc,@opcion
		end

	if @opcion='1' --consulta
	  begin
		set @staanul='A'		
		set @guiasal='GS'
		set @guiafac='GF'	
		set @stafac='F'
		set @isno='N'
		set @texto='TEXTO'

		if len(@tipoart)>0
		   set @filtro= N' AND M.TYPE_PART=@tipoart order by A.PART_ID,B.DATE_DOCUMENT,B.TYPE_TRANS,B.TRANS_ID,B.WAREHOUSE_ID,
								B.DOCUMENT_ID,B.NUMBER_DOCUMENT,A.ITEM'
		else
			set @filtro= N' order by A.PART_ID,B.DATE_DOCUMENT,B.TYPE_TRANS,B.TRANS_ID,B.WAREHOUSE_ID,
								B.DOCUMENT_ID,B.NUMBER_DOCUMENT,A.ITEM'

		set @STRquery='select A.*,B.* from 
			WAREHOUSE_TRANS B inner join 
			(WAREHOUSE_TRANS_LINE A left join PART M on A.PART_ID=M.ID ) on
			B.WAREHOUSE_ID = A.WAREHOUSE_ID AND B.DOCUMENT_ID=A.DOCUMENT_ID AND B.NUMBER_DOCUMENT=A.NUMBER_DOCUMENT
			where month(B.DATE_DOCUMENT) =@mes
			and year(B.DATE_DOCUMENT) =@anyo and B.STATUS_GUIA<>@staanul
			and not (B.DOCUMENT_ID=@guiasal and B.TRANS_ID=@guiafac and B.STATUS_GUIA=@stafac)
			and not (M.IS_STOCKED=@isno and M.SERIES=@isno and M.IS_LOT=@isno) 
			and (A.PART_ID>=@codini and A.PART_ID<=@codfin) 
			and (A.PART_ID<>@texto)' + @filtro	
		exec sp_executesql @STRquery,N'@opcion char(1),
				@mes char(2),@anyo char(4),@codini char(20),@codfin char(20),@tipoart char(4),
				@staanul char(1),@guiasal char(2),@guiafac char(2),@stafac char(1),
				@isno char(1),@texto char(5)',
				@opcion,@mes,@anyo,@codini,@codfin,@tipoart,
				@staanul,@guiasal,@guiafac,@stafac,@isno,@texto
	  end

	if @opcion='2' --consulta agrupada moresmes
	  begin
		set @STRquery='select PART_ID,YEAR_MONTH,AMOUNT,AMOUNT_US,
			sum(QTY_INITIAL) as QTY_INITIAL,
			sum(QTY_ENTER) as QTY_ENTER,
			sum(QTY_OUT) as  QTY_OUT 
			from MONTHLY_SUMMARIZE where 
			YEAR_MONTH >=@anyomesant
			AND YEAR_MONTH <=@anyomes
			AND (PART_ID>=@codini AND PART_ID<=@codfin) 
			group by PART_ID,YEAR_MONTH,AMOUNT,AMOUNT_US order by YEAR_MONTH'
		exec sp_executesql @STRquery,N'@opcion char(1),
				@anyomesant char(6),@anyomes char(6),@codini char(20),@codfin char(20)',
				@opcion,@anyomesant,@anyomes,@codini,@codfin
      end

	if @opcion='3' --consulta moresmes
		begin
		set @STRquery='select * from MONTHLY_SUMMARIZE where 
			YEAR_MONTH >=@anyomesant AND YEAR_MONTH <=@anyomes 
			AND (PART_ID>=@codini AND PART_ID<=@codfin) ORDER BY YEAR_MONTH'
		exec sp_executesql @STRquery,N'@opcion char(1),
			@anyomesant char(6),@anyomes char(6),@codini char(20),@codfin char(20)',
			@opcion,@anyomesant,@anyomes,@codini,@codfin
		end 

	if @opcion='4' --Consulta stock y partes
		begin
			if len(@tipoart)>0
			   set @filtro=N' AND B.TYPE_PART=@tipoart'
			else
			   set @filtro=N''
			
			set @STRquery='select distinct(A.PART_ID) from PART_QTY A 
				inner join PART B on A.PART_ID=B.ID 
				where (A.PART_ID>=@codini and A.PART_ID<=@codfin)' + @filtro
		exec sp_executesql @STRquery,N'@opcion char(1),
			@codini char(20),@codfin char(20),@tipoart char(4)',
			@opcion,@codini,@codfin,@tipoart
		end
	
	if @opcion='5'
		begin
			set @tabla=N'[tempdb].dbo.'+@pc
			set @STRquery='select K.PART_ID,K.DOCUMENT_DATE,K.HOUR,K.TRANS_ID,K.TYPE_TRANS,
				K.NUMBER_DOC,K.QTY,K.UNIT_PRICE,K.AVERAGE_COST,
				K.STOCK_BALANCE,K.FAMILY_ID,K.IS_SER_LOT,K.IS_POST,
				K.IN_OUT,K.WAREHOUSE_ID,K.ITEM,P.DESCRIPTION,W.CURRENCY_EXCHANGE
				from '+@tabla+ ' K
				inner join PART P on K.PART_ID=P.ID
				inner join WAREHOUSE_TRANS W ON K.WAREHOUSE_ID=W.WAREHOUSE_ID
				and K.TYPE_TRANS=W.DOCUMENT_ID and K.NUMBER_DOC=W.NUMBER_DOCUMENT'
			exec sp_executesql @STRquery,N'@pc nvarchar(80),@opcion char(1)',
								@pc,@opcion
		end

	if @opcion='6'
		begin
		set @tabla=N'[tempdb].dbo.'+@pc
		set @STRquery='select K.PART_ID,K.DOCUMENT_DATE,K.HOUR,K.TRANS_ID,K.TYPE_TRANS,
				K.NUMBER_DOC,K.QTY,K.UNIT_PRICE,K.AVERAGE_COST,K.STOCK_BALANCE,
				K.FAMILY_ID,K.IS_SER_LOT,K.IS_POST,K.IN_OUT,K.WAREHOUSE_ID,K.ITEM,
				P.DESCRIPTION,P.UNIT_OF_MEASUREMENT
				from '+@tabla+ ' K
				inner join PART P on K.PART_ID=P.ID'
			exec sp_executesql @STRquery,N'@pc nvarchar(80),@opcion char(1)',
								@pc,@opcion
		end
