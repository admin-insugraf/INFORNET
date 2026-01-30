CREATE procedure [dbo].[RPT_INV_DOCUMENTOS_ALMACEN]
	@fecini int,
	@fecfin int,
	@almacen char(3),
	@tipomov char(3),
	@movini char(3),
	@movfin char(3),
	@opcion char(1)
as
	declare @STRquery nvarchar(2000)
	declare @STRfiltro nvarchar(1000)
	if @opcion='0'
		set @STRfiltro=N' and W.WAREHOUSE_ID=@almacen'
	if @opcion='1'
		set @STRfiltro=N' and W.WAREHOUSE_ID=@almacen and W.TYPE_TRANS=@tipomov 
				and (W.TRANS_ID>=@movini and W.TRANS_ID<=@movfin)'

	set @STRquery='select W.DOCUMENT_ID,W.NUMBER_DOCUMENT,
			convert(varchar(10),W.DATE_DOCUMENT,103) as DATE_DOCUMENT,W.TRANS_ID,
			W.DOC_ID_REF,W.NUM_ID_REF,W.VENDOR_ID,W.CUSTOMER_ID,
			W.CURRENCY_TYPE,WL.PART_ID,WL.QTY,WL.AVERAGE_COST,
			WL.NUMBER_SERIE,WL.NUMBER_LOT,P.DESCRIPTION,P.UNIT_OF_MEASUREMENT
			from WAREHOUSE_TRANS W
			inner join WAREHOUSE_TRANS_LINE WL
			on W.WAREHOUSE_ID=WL.WAREHOUSE_ID and W.DOCUMENT_ID=WL.DOCUMENT_ID
			and W.NUMBER_DOCUMENT=WL.NUMBER_DOCUMENT
			inner join PART P on WL.PART_ID=P.ID
			where W.DATE_DOCUMENT between @fecini and @fecfin '+@STRfiltro
	exec sp_executesql @STRquery,N'@fecini int,@fecfin int,@almacen char(3),
		@tipomov char(3),@movini char(20),@movfin char(20)',
		@fecini,@fecfin,@almacen,@tipomov,@movini,@movfin
