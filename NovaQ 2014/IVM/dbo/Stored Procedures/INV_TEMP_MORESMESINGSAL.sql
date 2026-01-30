CREATE procedure [dbo].[INV_TEMP_MORESMESINGSAL]
	@pc nvarchar(80),
	@DATinicio int,
	@DATfinal int
as
	declare @STRquery nvarchar(2000)
	declare @tabla nvarchar(80)
	if exists(select * from tempdb.dbo.sysobjects where name=@pc)
		begin
		   set @tabla='[tempdb].dbo.'+@pc
		   set @STRquery='drop table '+ @tabla
		   exec sp_executesql @STRquery,N'@pc nvarchar(80),@tabla nvarchar(80),
							@DATinicio int,@DATfinal int',
						@pc,@tabla,@DATinicio,@DATfinal
		end
		set @tabla='[tempdb].dbo.'+@pc
		set @STRquery='select WAREHOUSE_ID,PART_ID,DATE_DOCUMENT,ENTR,SALI,AVERAGE_COST,CURRENCY_TYPE,
		CURRENCY_EXCHANGE,UNIT_PART,TYPE_TRANS,TRANS_ID,DOCUMENT_ID,NUMBER_DOCUMENT,
		ITEM,STATUS_VALUE,
		convert(numeric(15,6),0) as SALDO,
		convert(numeric(19,10),0) as PRECIOPROMEDIO,
		convert(varchar(4),year(DATE_DOCUMENT))+convert(varchar(2),replicate(0,2-len(convert(varchar(2),Month(DATE_DOCUMENT))))+CONVERT(varchar(2),Month(DATE_DOCUMENT))) as ANOMES,
		convert(numeric(15,6),0) as SALDOINICIAL,
		convert(numeric(19,10),0) as PRECIOPROMEDIOUSS,
		convert(numeric(15,6),0) as SALDOVALANTMN,
		convert(numeric(15,6),0) as SALDOVALANTME
		into '+ @tabla + '
		from vwMoresMesIngSal
		where DATE_DOCUMENT between @DATinicio and @DATfinal 
		order by PART_ID,DATE_DOCUMENT,TYPE_TRANS,TRANS_ID,DOCUMENT_ID,NUMBER_DOCUMENT,ITEM'
		exec sp_executesql @STRquery,N'@pc nvarchar(80),@tabla nvarchar(80),
						@DATinicio int,@DATfinal int',
						@pc,@tabla,@DATinicio,@DATfinal

		set @STRquery='alter table '+ @tabla +' add ID INTEGER IDENTITY(1,1) CONSTRAINT '+@pc+ 'IDX PRIMARY KEY'
		exec sp_executesql @STRquery,N'@pc nvarchar(80),@tabla nvarchar(80),
						@DATinicio int,@DATfinal int',
						@pc,@tabla,@DATinicio,@DATfinal