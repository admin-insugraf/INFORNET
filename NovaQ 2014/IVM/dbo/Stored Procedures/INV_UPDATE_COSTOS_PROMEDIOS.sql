CREATE procedure [dbo].[INV_UPDATE_COSTOS_PROMEDIOS]
	@moremesingsal nvarchar(80)
as
	declare @STRquery nvarchar(1500)
	declare @tabla nvarchar(80)
	declare @mondefaultmn char(2)
	declare @mondefaultus char(2)
	set @tabla='[tempdb].dbo.'+@moremesingsal
	set @mondefaultmn='MN'
	set @mondefaultus='ME'
	set @STRquery='update D 
		set D.AMOUNT=(case when T.STATUS_VALUE=0 then T.PRECIOPROMEDIO else (case when T.CURRENCY_TYPE=@mondefaultmn then T.AVERAGE_COST else T.AVERAGE_COST*C.CURRENCY_EXCHANGE end) end) ,
		D.AMOUNT_US=(case when T.STATUS_VALUE=0 then T.PRECIOPROMEDIOUSS else (case when T.CURRENCY_TYPE=@mondefaultus then T.AVERAGE_COST ELSE T.AVERAGE_COST/(case when C.CURRENCY_EXCHANGE=0 then 1 
			else C.CURRENCY_EXCHANGE end)end) end) 
		from WAREHOUSE_TRANS C inner join (
			WAREHOUSE_TRANS_LINE D inner join '+@tabla+ ' T on
			D.WAREHOUSE_ID=T.WAREHOUSE_ID and 
			D.DOCUMENT_ID=T.DOCUMENT_ID and 
			D.NUMBER_DOCUMENT=T.NUMBER_DOCUMENT and 
			D.ITEM=T.ITEM) 
		on C.WAREHOUSE_ID=D.WAREHOUSE_ID and C.DOCUMENT_ID=D.DOCUMENT_ID and C.NUMBER_DOCUMENT=D.NUMBER_DOCUMENT'
	exec sp_executesql @STRquery,N'@moremesingsal nvarchar(80),@tabla nvarchar(80),
				@mondefaultmn char(2),@mondefaultus char(2)',
				@moremesingsal,@tabla,@mondefaultmn,@mondefaultus