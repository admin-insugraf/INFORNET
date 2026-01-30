create procedure INV_RPT_STOCK_QTY
	(
	@CODIGO varchar(20)
	)
AS
	
	   begin
	        select P.ID, p.DESCRIPTION,p.UNIT_OF_MEASUREMENT,
				   pq.WAREHOUSE_ID,pq.QTY_ON_HAND,
				   w.NAME
	        from PART p
			inner join PART_QTY pq
				on p.ID=pq.PART_ID
			inner join WAREHOUSE w
				on w.ID=pq.WAREHOUSE_ID
			where p.ID=@codigo
			order by p.ID,pq.WAREHOUSE_ID	
	   end
