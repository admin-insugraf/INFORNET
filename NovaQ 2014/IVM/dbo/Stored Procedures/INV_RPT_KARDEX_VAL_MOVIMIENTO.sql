CREATE procedure [dbo].[INV_RPT_KARDEX_VAL_MOVIMIENTO]
--	declare
	@pc nvarchar(80),
	@opcion char(1),
	@orden char(1),
	@almacen char(3),
	@anyo char(4),
	@mes char(2),
	@partini char(20),
	@partfin char(20),
	@anyomesant char(6)

/*set @pc=''
set	@opcion='3'
set	@orden=''
set	@almacen=''
set	@anyo=''
set	@mes=''
set	@partini=''
set	@partfin=''
set	@anyomesant='200702'
--*/as
	declare @STRquery nvarchar(2000)
	declare @tabla nvarchar(80)
	declare @STRfiltro nvarchar(1000)
	declare @staanul char(1),@guiasal char(2),@guiafac char(2)
	declare @stafac char(1),@isno char(1),@texto char(5)

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
	
	if @opcion='1'
		begin
		   if @orden='0'
				set @STRfiltro=N' order by P.ID asc'
		   else
				set @STRfiltro=N' order by P.ID desc'	
		   
		   set @STRquery='select top 1 P.ID,P.DESCRIPTION,P.UNIT_OF_MEASUREMENT,P.ID_FAB 
				from PART P, PART_QTY N where P.ID= N.PART_ID  
				and N.WAREHOUSE_ID=@almacen ' + @STRfiltro
			
			exec sp_executesql @STRquery,N'@opcion char(1),@almacen char(3),
								@orden char(1)',@opcion,@almacen,@orden
		end

	if @opcion='2'
		begin
			set @staanul='A'		
			set @guiasal='GS'
			set @guiafac='GF'	
			set @stafac='F'
			set @isno='N'
			set @texto='TEXTO'

			if len(@partini)>0
				set @STRfiltro=N' and (A.PART_ID>=@partini and A.PART_ID<=@partfin)
					order by A.PART_ID,B.DATE_DOCUMENT,B.TYPE_TRANS,B.TRANS_ID,B.WAREHOUSE_ID,B.DOCUMENT_ID,B.NUMBER_DOCUMENT,A.ITEM'
			if len(@partini)=0
				set @STRfiltro=N' order by A.PART_ID,B.DATE_DOCUMENT,B.TYPE_TRANS,B.TRANS_ID,B.WAREHOUSE_ID,B.DOCUMENT_ID,B.NUMBER_DOCUMENT,A.ITEM'
				
			set @STRquery='select A.* , B.* from 
				WAREHOUSE_TRANS B inner join 
				(WAREHOUSE_TRANS_LINE  A left join PART M on A.PART_ID=M.ID) on
				B.WAREHOUSE_ID=A.WAREHOUSE_ID and B.DOCUMENT_ID=A.DOCUMENT_ID and B.NUMBER_DOCUMENT=A.NUMBER_DOCUMENT
				where month(B.DATE_DOCUMENT)=@mes
				and year(B.DATE_DOCUMENT)=@anyo
				and B.STATUS_GUIA<>@staanul  
				and not (B.DOCUMENT_ID=@guiasal and B.TRANS_ID=@guiafac and B.STATUS_GUIA=@stafac) 
				and not(M.IS_STOCKED=@isno and M.SERIES=@isno and M.IS_LOT=@isno) 
				and (A.PART_ID<>@texto) '+@STRfiltro
			exec sp_executesql @STRquery,N'@opcion char(1),@partini char(20),@partfin char(20),
						@mes char(2),@anyo char(4),@staanul char(1),@guiasal char(2),@guiafac char(2),@stafac char(1),@isno char(1),@texto char(5)',
						@opcion,@partini,@partfin,@mes,@anyo,@staanul,@guiasal,@guiafac,@stafac,@isno,@texto
		end

	if @opcion='3'
		begin
			set @STRquery='select PART_ID,YEAR_MONTH,AMOUNT_US,AMOUNT,
				sum(QTY_INITIAL) as QTY_INITIAL,sum(QTY_ENTER) as QTY_ENTER,
				sum(QTY_OUT) as QTY_OUT from MONTHLY_SUMMARIZE 
				where YEAR_MONTH >=@anyomesant
				group by PART_ID,YEAR_MONTH,AMOUNT_US,AMOUNT order by YEAR_MONTH'
			exec sp_executesql @STRquery,N'@opcion char(1),@anyomesant char(6)',
								@opcion,@anyomesant
		end

	
	if @opcion='4'
		begin
			set @STRquery='select * from MONTHLY_SUMMARIZE 
				where YEAR_MONTH >=@anyomesant order by YEAR_MONTH'
			exec sp_executesql @STRquery,N'@opcion char(1),@anyomesant char(6)',
							@opcion,@anyomesant
		end
	
	if @opcion='5'
		begin
			if len(@partini)=0 and len(@partfin)=0
				set @STRfiltro=N''
			else
				set @STRfiltro=N' AND (P.PART_ID>=@partini AND P.PART_ID<=@partfin)'
		
			set @STRquery='SELECT P.WAREHOUSE_ID, P.PART_ID, P.QTY_ON_HAND 
				FROM PART_QTY P WHERE P.WAREHOUSE_ID=@almacen '+ @STRfiltro

		exec sp_executesql @STRquery,N'@opcion char(1),@partini char(20),@partfin char(20),
							@almacen char(3)',@opcion,@partini,@partfin,@almacen
		end

	
	if @opcion='6'
		begin
			set @tabla=N'[tempdb].dbo.'+@pc
			set @STRquery='SELECT K.PART_ID,K.DOCUMENT_DATE,K.HOUR,K.TRANS_ID,
				K.TYPE_TRANS,K.NUMBER_DOC,
				K.QTY,UNIT_PRICE,K.AVERAGE_COST,K.STOCK_BALANCE,K.FAMILY_ID,
				K.IS_SER_LOT,K.IS_POST,K.IN_OUT,K.WAREHOUSE_ID,K.ITEM,
				P.DESCRIPTION
				FROM @tabla K
				inner join PART P on K.PART_ID=P.ID'
		exec sp_executesql @STRquery,N'@opcion char(1),@pc nvarchar(80)',
								@pc,@opcion
		end
