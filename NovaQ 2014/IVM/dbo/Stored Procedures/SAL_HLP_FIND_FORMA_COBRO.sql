create procedure SAL_HLP_FIND_FORMA_COBRO
	(
	@codigo varchar(2)
	)
as
	if len(ISNULL(@codigo,''))=0
		begin
			SELECT ID,NAME FROM TERMS
			order by ID
		end
	else
		begin
			SELECT ID,NAME FROM TERMS
			WHERE ID=@codigo
		end