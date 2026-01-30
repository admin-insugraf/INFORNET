create procedure [dbo].[SAL_HLP_PTO_VENTA]
	(@cod_compania varchar(50))
	
	as
	
	select s.sales_place_id,
		   s.sales_place_description,
		   s.warehouse_id,
		   w.NAME,
		   s.company_id
	from SALES_PLACE s
	inner join WAREHOUSE w
		on s.WAREHOUSE_ID=w.ID
	where s.COMPANY_ID=@cod_compania
	order by s.SALES_PLACE_ID
