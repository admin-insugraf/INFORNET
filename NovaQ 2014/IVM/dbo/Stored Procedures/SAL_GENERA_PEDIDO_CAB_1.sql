create procedure [dbo].[SAL_GENERA_PEDIDO_CAB]
	(
	@ID varchar(7) out,
	@ORDER_DATE smalldatetime,
	@CADUCATE_DATE smalldatetime,
	@SALES_ID varchar(2),
	@PLACE_SALES varchar(2),
	@CUSTOMER_ID varchar(11),
	@CUSTOMER_NAME varchar(70),
	@CUSTOMER_ADDR varchar(100),
	@VAT_REGISTRATION varchar(11),
	@AMOUNT numeric(15, 6),
	@TERMS varchar(4),
	@SELL_RATE numeric(15, 6),
	@CURRENCY_ID varchar(3),
	@STATUS varchar(1),
	@USER_ID varchar(8),
	@COMMENT varchar(100),
	@AMOUNT_VAT numeric(15, 6),
	@AMOUNT_ISC numeric(15, 6),
	@STATUS_ORDER varchar(40)
	)
as
	declare @Secuencia varchar(7)
	declare @NumeroPed numeric(9,0)
	
	select @NumeroPed=last_number + 1 from NUMBER_DOCUMENT where TYPE_DOC='PD'
	set @Secuencia=RIGHT('0000000' + Ltrim(Rtrim(@NumeroPed)),7)
	set @ID=@Secuencia
	begin
		insert into ORDERS
			(
			ID,
			ORDER_DATE,
			CADUCATE_DATE,	
			SALES_ID,
			PLACE_SALES,
			CUSTOMER_ID,
			CUSTOMER_NAME,
			CUSTOMER_ADDR,
			VAT_REGISTRATION,
			AMOUNT,
			TERMS,
			SELL_RATE,
			CURRENCY_ID,
			CREATE_DATE,
			STATUS,
			USER_ID,
			COMMENT,
			AMOUNT_VAT,
			AMOUNT_ISC,
			STATUS_ORDER
			)
			values
			(
			@ID,
			@ORDER_DATE,
			@CADUCATE_DATE,	
			@SALES_ID,
			@PLACE_SALES,
			@CUSTOMER_ID,
			@CUSTOMER_NAME,
			@CUSTOMER_ADDR,
			@VAT_REGISTRATION,
			@AMOUNT,
			@TERMS,
			@SELL_RATE,
			@CURRENCY_ID,
			GETDATE(),
			@STATUS,
			@USER_ID,
			@COMMENT,
			@AMOUNT_VAT,
			@AMOUNT_ISC,
			@STATUS_ORDER
			)
			
	update NUMBER_DOCUMENT set LAST_NUMBER=@NumeroPed
	where TYPE_DOC='PD'
	end
