
CREATE procedure SAL_ACTUALIZA_STATUS_PEDIDO
	(@ID varchar(7),
	 @STATUS_ORDER varchar(40)
	)
as
	update ORDERS
	set STATUS_ORDER=@STATUS_ORDER
	where ID=@ID