create procedure SAL_HLP_FIND_VENDEDOR
	(@codigo varchar(2))
as
	select id,name
			from SALES_REP
			where id=@codigo
