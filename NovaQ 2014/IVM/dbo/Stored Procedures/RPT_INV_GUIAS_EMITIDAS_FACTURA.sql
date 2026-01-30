CREATE procedure [dbo].[RPT_INV_GUIAS_EMITIDAS_FACTURA]
	@almacen char(3),
	@tipodoc char(3),
	@docini char(20),
	@docfin char(20)
as
	declare @STRquery nvarchar(2000)
	declare @guia char(2)
	set @guia='GS'
	set @STRquery='select W.DOCUMENT_ID,W.NUMBER_DOCUMENT,
			convert(varchar(10),W.DATE_DOCUMENT,103) as DATE_DOCUMENT,
			W.DOC_ID_REF,W.NUM_ID_REF,W.CUSTOMER_ID,W.CUSTOMER_NAME,W.STATUS_GUIA,
			WL.PART_ID,WL.QTY,P.DESCRIPTION,P.UNIT_OF_MEASUREMENT,P.WEIGHT
			from WAREHOUSE_TRANS W
			inner join WAREHOUSE_TRANS_LINE WL
			on W.WAREHOUSE_ID=WL.WAREHOUSE_ID and W.DOCUMENT_ID=WL.DOCUMENT_ID
			and W.NUMBER_DOCUMENT=WL.NUMBER_DOCUMENT
			inner join PART P on WL.PART_ID=P.ID
			where W.WAREHOUSE_ID=@almacen  
			and ((W.DOC_ID_REF=@tipodoc) and W.DOCUMENT_ID=@guia)
			and (W.NUM_ID_REF>=@docini AND W.NUM_ID_REF<=@docfin)'
	exec sp_executesql @STRquery,N'@almacen char(3),@tipodoc char(3),
			@docini char(20),@docfin char(20),@guia char(2)',
			@almacen,@tipodoc,@docini,@docfin,@guia
