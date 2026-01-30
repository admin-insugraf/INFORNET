CREATE procedure SAL_HLP_CLIENTES
	(@codigo varchar(20),
	 @nombre varchar(150),
	 @vat varchar(11),
	 @direccion varchar(100))
as
	if isnull(@codigo,'')<>''
		begin
			select ID,NAME,VAT_REGISTRATION,ADDR,SALES_ID,TERMS_TYPE 
			from CUSTOMER
			where ID like '%' + @codigo + '%'
		end
	else if isnull(@nombre,'')<>'' 
		begin
			select ID,NAME,VAT_REGISTRATION,ADDR,SALES_ID,TERMS_TYPE 
			from CUSTOMER
			where NAME like '%' + @nombre + '%'
		end
	else if isnull(@direccion,'')<>'' 
		begin
			select ID,NAME,VAT_REGISTRATION,ADDR,SALES_ID,TERMS_TYPE 
			from CUSTOMER
			where ADDR like '%' + @direccion + '%'
		end
	else if ISNULL(@vat,'')<>''
		begin
			select ID,NAME,VAT_REGISTRATION,ADDR,SALES_ID,TERMS_TYPE 
			from CUSTOMER
			where VAT_REGISTRATION like '%' + @vat + '%'
		end 
	else
		begin
			select ID,NAME,VAT_REGISTRATION,ADDR,SALES_ID,TERMS_TYPE 
			from CUSTOMER
		end