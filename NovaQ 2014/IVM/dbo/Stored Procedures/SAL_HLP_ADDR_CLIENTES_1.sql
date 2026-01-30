
create procedure SAL_HLP_ADDR_CLIENTES
	(
	@customer_id varchar(11)
	)
as
select CUSTOMER_ID,CUSTOMER_ADDR
from CUSTOMER_ADDR
where CUSTOMER_ID=@customer_id