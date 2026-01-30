CREATE procedure [dbo].[SAL_LIST_PEDIDOS]
	(
	@fecha_ini datetime,
	@fecha_fin datetime
	)
as
select o.ID,
	   o.ORDER_DATE,
	   p.SALES_PLACE_DESCRIPTION,
	   o.CUSTOMER_ID,
	   o.CUSTOMER_NAME,
	   o.AMOUNT,
	   o.CURRENCY_ID,
	   o.SELL_RATE,
	   o.STATUS_ORDER,
	   o.STATUS,
	   r.DOCUMENT_ID,
	   r.NUMBER_SERIE,
	   r.NUMBER_DOCUMENT
from ORDERS o
inner join SALES_PLACE p
	on o.PLACE_SALES=p.SALES_PLACE_ID
left join RECEIVABLE r
	on o.ID=r.NUMBER_ORDER
where convert(varchar(10),o.ORDER_DATE,103) between @fecha_ini and @fecha_fin
order by o.ID