create procedure SAL_HLP_VENDEDORES
	(@codigo varchar(2),
	 @nombre varchar(30)
	)
as
	if ISNULL(@codigo,'')<>''
		begin
			select id,name
			from SALES_REP
			where id like '%' + @codigo + '%'
		end
		
	if ISNULL(@nombre,'')=''
		begin
			select id,name
			from SALES_REP
			where name like '%' + @nombre + '%'
		end
