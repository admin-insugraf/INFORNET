CREATE procedure ADM_INSERT_DOC_PTO_VENTA
	(
	@place_sales_id varchar(2),
	@document_type varchar(30),
	@number_serie varchar(60)
	)
as	
	insert DOCUMENT_PLACE_SALES
		(
		PLACE_SALES_ID,
		DOCUMENT_TYPE,
		NUMBER_SERIE
		)
	values
		(
		@place_sales_id,
		@document_type,
		@number_serie
		)