
create procedure ADM_LISTA_PTO_VENTA
	(
	@codigo varchar(2)
	)
as
	if len(ISNULL(@codigo,''))=0
		begin
			select s.SALES_PLACE_ID,
				   s.SALES_PLACE_DESCRIPTION,
				   s.SALES_PLACE_ADDR,
				   s.WAREHOUSE_ID,
				   w.NAME
			from SALES_PLACE s
			inner join WAREHOUSE w
				on s.WAREHOUSE_ID=w.ID
			order by s.SALES_PLACE_ID
		end
	else
		begin
			select s.SALES_PLACE_ID,
				   s.SALES_PLACE_DESCRIPTION,
				   s.SALES_PLACE_ADDR,
				   s.WAREHOUSE_ID,
				   w.NAME
			from SALES_PLACE s
			inner join WAREHOUSE w
				on s.WAREHOUSE_ID=w.ID
			where s.SALES_PLACE_ID=@codigo
		end