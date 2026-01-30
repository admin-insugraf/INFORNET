CREATE procedure SAL_ANULA_DOCUMENTO
	(
	@documento_id varchar(2),
	@number_serie varchar(3),
	@number_documento varchar(7),
	@place_sales varchar(2)
	)
as
	declare @document_ref varchar(2)
	declare @serie_ref varchar(3)
	declare @number_ref varchar(7)
	declare @customer_id varchar(11)
	

	select @document_ref=DOCUMENT_REF,
		   @serie_ref=SERIE_REF,
		   @number_ref=NUMBER_REF,
		   @customer_id=CUSTOMER_ID
	from RECEIVABLE r
	where r.DOCUMENT_ID=@documento_id
	and r.NUMBER_SERIE=@number_serie
	and r.NUMBER_DOCUMENT=@number_documento
	and r.PLACE_SALES=@place_sales
	
	
	Update WAREHOUSE_TRANS Set STATUS_GUIA = 'A' 
		Where DOCUMENT_ID = @document_ref 
		and NUMBER_DOCUMENT = @serie_ref + @number_ref
		and TRANS_ID='GF'
	
	Update WAREHOUSE_TRANS 
				Set STATUS_GUIA = 'A',
				    USER_ID = '5',
				    TYPE_TRANS = 'I' 
	where DOCUMENT_ID = @documento_id
	and NUMBER_DOCUMENT = @number_serie +  @number_documento

	Update RECEIVABLE 
		Set STATUS = 'A',
			USER_ID = '5', 
			AMOUNT = 0, 
			AMOUNT_TAX = 0 , 
			LAST_MODIFIED = GETDATE(),
			VOUCHER_ID = ' ',
			SUB_ID = ' ' ,
			NUMBER_ORDER='',
			SERIE_REF='',
			LIST_GUIA='',
			NUMBER_REF='' 
	Where PLACE_SALES =@place_sales
	and NUMBER_SERIE = @number_serie 
	and NUMBER_DOCUMENT = @number_documento 
	AND DOCUMENT_ID = @documento_id

	UPDATE RECEIVABLE_LINE 
		SET STATUS ='A' 
		WHERE DOCUMENT_ID = @documento_id 
		AND NUMBER_SERIE =@number_serie 
		AND NUMBER_DOCUMENT=@number_documento

	Delete from CUSTOMER_BALANCE 
	where CUSTOMER_ID = @customer_id
	and DOCUMENT_ID = @documento_id 
	AND SUBSTRING(NUMBER_DOC,1,3) = @number_serie
	AND SUBSTRING(NUMBER_DOC,4,7) = @number_documento