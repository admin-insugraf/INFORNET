CREATE procedure [dbo].[RPT_INV_GUIAS_EMITIDAS]
	@fecini int,
	@fecfin int,
	@almacen char(3),
	@opcion char(1)
as
	declare @STRquery nvarchar(2000)
	declare @guia char(2),@boleta char(2),@factura char(2)

	set @guia='GS'
	set @boleta='BV'
	set @factura='FT'

	if @opcion='0'
		begin
		  set @STRquery='select * from WAREHOUSE_TRANS 
			where WAREHOUSE_ID=@almacen
			AND DOCUMENT_ID IN (@guia,@boleta,@factura) 
			AND DATE_DOCUMENT between @fecini and @fecfin order by NUMBER_DOCUMENT'
		  exec sp_executesql @STRquery,N'@fecini int,@fecfin int,@almacen char(3),
					@opcion char(1),@guia char(2),@boleta char(2),@factura char(2)',
					@fecini,@fecfin,@almacen,@opcion,@guia,@boleta,@factura
		end

	if @opcion='1'
		begin
		  set @STRquery='select convert(varchar(10),C.DATE_DOCUMENT,103) as DATE_DOCUMENT,
				C.NUMBER_DOCUMENT,C.DOC_ID_REF,C.NUM_ID_REF,
				D.PART_ID,D.PART_DESCRIPTION,
				D.QTY,C.STATUS_GUIA,C.CARRIER_ID,C.NUMBER_REGISTRATION 
				from WAREHOUSE_TRANS C 
				inner join WAREHOUSE_TRANS_LINE D 
				on C.DOCUMENT_ID=D.DOCUMENT_ID and C.NUMBER_DOCUMENT=D.NUMBER_DOCUMENT 
				and C.WAREHOUSE_ID=D.WAREHOUSE_ID
				where C.WAREHOUSE_ID=@almacen 
				and C.DATE_DOCUMENT between @fecini and @fecfin'
		   exec sp_executesql @STRquery,N'@fecini int,@fecfin int,@almacen char(3),
					@opcion char(1)',@fecini,@fecfin,@almacen,@opcion
		end
