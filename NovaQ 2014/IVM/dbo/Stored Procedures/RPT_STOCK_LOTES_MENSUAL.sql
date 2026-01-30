CREATE procedure [dbo].[RPT_STOCK_LOTES_MENSUAL]
	@pc nvarchar(80)
as

	declare @extraido as varchar(10)
	declare @STRquery nvarchar(2500)
	declare @STRquery2 nvarchar(2500)
	declare @tabla nvarchar(80)
	declare @pday nvarchar(2)
	declare @month nvarchar(2)
	declare @year nvarchar(4)
	declare @complemento as varchar(70)
	set @extraido=substring(@pc,0,2)
	
	

	if @extraido='0' OR  @extraido='1' OR @extraido='2' OR @extraido='3'
		begin
			set @pday=substring(@pc,0,3)
			set @month=substring(@pc,4,2)
			set @year=substring(@pc,7,4)
			set @complemento=substring(@pc,11,len(@pc))
			set @tabla=N'[tempdb].dbo.'+@complemento
			set @STRquery2='select WAREHOUSE_ID,YEAR_MONTH,PART_ID,AMOUNT_US,LOT_ID,AMOUNT,
			QTY_ENTER,QTY_OUT,QTY_INITIAL,DESCRIPTION,UNIT_OF_MEASUREMENT,
			convert(varchar(10),CADUCATE_DATE,103) as CADUCATE_DATE,
			convert(varchar(10),MANUFACT_DATE,103) as MANUFACT_DATE,
			FAMILY,NAME,WEIGHT,REFERENCE
			from '+ @tabla+' WHERE year(caducate_date)<='+@YEAR+' and month(caducate_date)<='+@MONTH+' and day(caducate_date)<='+@PDAY+' '
		
			EXEC  (@STRquery2)
		end
	else
		begin
			set @tabla=N'[tempdb].dbo.'+@PC
			set @STRquery='select WAREHOUSE_ID,YEAR_MONTH,PART_ID,AMOUNT_US,LOT_ID,AMOUNT,
			QTY_ENTER,QTY_OUT,QTY_INITIAL,DESCRIPTION,UNIT_OF_MEASUREMENT,
			convert(varchar(10),CADUCATE_DATE,103) as CADUCATE_DATE,
			convert(varchar(10),MANUFACT_DATE,103) as MANUFACT_DATE,
			FAMILY,NAME,WEIGHT,REFERENCE,
			convert(varchar(10),FECINGRESO,103) as FECINGRESO
			from '+ @tabla
			
			EXEC (@STRquery)
--			exec sp_executesql @STRquery,N'@pc nvarchar(80)',@pc

		end