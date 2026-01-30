create procedure SAL_HLP_MONEDAS
as
	select id,name,type_currency_id,symbol
	from CURRENCY_TYPE
	order by TYPE_CURRENCY_ID
