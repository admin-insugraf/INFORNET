CREATE procedure [dbo].[RPT_STOCK_LOTES_MENSUAL_ANTERIOR19072010]
	@pc nvarchar(80)
as
	declare @STRquery nvarchar(1500)
	declare @tabla nvarchar(80)
	set @tabla=N'[tempdb].dbo.'+@pc
	set @STRquery='select WAREHOUSE_ID,YEAR_MONTH,PART_ID,AMOUNT_US,LOT_ID,AMOUNT,
		QTY_ENTER,QTY_OUT,QTY_INITIAL,DESCRIPTION,UNIT_OF_MEASUREMENT,
		convert(varchar(10),CADUCATE_DATE,103) as CADUCATE_DATE,
		convert(varchar(10),MANUFACT_DATE,103) as MANUFACT_DATE,
		FAMILY,WEIGHT,REFERENCE,
		convert(varchar(10),FECINGRESO,103) as FECINGRESO
		from '+ @tabla
	exec sp_executesql @STRquery,N'@pc nvarchar(80)',@pc