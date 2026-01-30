CREATE procedure ADM_INSERT_PTO_VENTA
	(
	@sales_place_id varchar(2),
	@sales_place_description varchar(30),
	@sales_place_addr varchar(60),
	@warehouse_id varchar(2),
	@insupd varchar(1)
	)
as
	if @insupd='I'
		begin
			insert into SALES_PLACE
				(
				SALES_PLACE_ID,
				SALES_PLACE_DESCRIPTION,
				SALES_PLACE_ADDR,
				WAREHOUSE_ID
				)
			values
				(
				@sales_place_id,
				@sales_place_description,
				@sales_place_addr,
				@warehouse_id
				)
		end
	else
		begin
		   update SALES_PLACE
		   set SALES_PLACE_DESCRIPTION=@sales_place_description,
			   SALES_PLACE_ADDR=@sales_place_addr,
			   WAREHOUSE_ID=@warehouse_id
		   where SALES_PLACE_ID=@sales_place_id
		
		end