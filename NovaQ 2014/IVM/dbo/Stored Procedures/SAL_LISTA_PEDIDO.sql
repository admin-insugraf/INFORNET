create procedure SAL_LISTA_PEDIDO
	(
	@ID varchar(7)
	)
as
select  o.ID,
		o.ORDER_DATE,
		o.CADUCATE_DATE,	
		o.SALES_ID,
		o.PLACE_SALES,
		o.CUSTOMER_ID,
		o.CUSTOMER_NAME,
		o.CUSTOMER_ADDR,
		o.VAT_REGISTRATION,
		o.AMOUNT,
		o.TERMS,
		o.SELL_RATE,
		o.CURRENCY_ID,
		o.CREATE_DATE,
		o.STATUS,
		o.USER_ID,
		o.COMMENT,
		o.AMOUNT_VAT,
		o.AMOUNT_ISC,
		o.STATUS_ORDER,
		ol.ITEM,
		ol.PART_ID,
		ol.PART_DESCRIPTION,
		ol.QTY,
		ol.PRICE_SALES,
		ol.PRICE_ORI,
		ol.AMOUNT_TAX,
		ol.PERCENT_TAX,
		ol.AMOUNT_ISC,
		ol.PERCENT_ISC,
		ol.AMOUNT_US,
		ol.AMOUNT,
		ol.WAREHOUSE_ID,
		ol.LOT,
		ol.UNIT
	from ORDERS o		
	inner join ORDER_LINE ol
		on o.ID=ol.ID
	where o.ID=@ID
	
			
	
