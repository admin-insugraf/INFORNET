CREATE procedure [dbo].[INV_UPDATE_PRECIOS_PROMEDIOS]
	@moremesingsal nvarchar(80)
as
	declare @STRquery nvarchar(1500)
	declare @tabla nvarchar(80)
	declare @mondefault char(2)
	set @tabla='[tempdb].dbo.'+@moremesingsal
	set @mondefault='MN'
	set @STRquery='update D 
		set D.AVERAGE_COST=case when C.CURRENCY_TYPE=@mondefault then T.PRECIOPROMEDIO else T.PRECIOPROMEDIOUSS end
		from WAREHOUSE_TRANS C inner join 
		(WAREHOUSE_TRANS_LINE D 
		inner join '+@tabla+ ' T ON D.WAREHOUSE_ID=T.WAREHOUSE_ID and D.DOCUMENT_ID=T.DOCUMENT_ID and D.NUMBER_DOCUMENT=T.NUMBER_DOCUMENT and D.ITEM=T.ITEM) 
		on 
		C.WAREHOUSE_ID=D.WAREHOUSE_ID and C.DOCUMENT_ID=D.DOCUMENT_ID and C.NUMBER_DOCUMENT=D.NUMBER_DOCUMENT where D.STATUS_VALUE=0'
	exec sp_executesql @STRquery,N'@moremesingsal nvarchar(80),@tabla nvarchar(80),
					@mondefault char(2)',@moremesingsal,@tabla,@mondefault