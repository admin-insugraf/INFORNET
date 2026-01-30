create procedure [dbo].[SAL_VENTAS_GENERAL]
    (
    @FECHA_INI DATE,
    @FECHA_FIN DATE,
    @VENDEDOR_INI VARCHAR(5),
    @VENDEDOR_FIN VARCHAR(5),
    @CLIENTE_INI VARCHAR(20),
    @CLIENTE_FIN VARCHAR(20),
    @PRODUCTO_INI VARCHAR(20),
    @PRODUCTO_FIN VARCHAR(20),
    @MONEDA VARCHAR(2)
    )
as
    begin
        if len(ISNULL(@VENDEDOR_INI,''))=0
            begin
                select @VENDEDOR_INI=MIN(id),@VENDEDOR_FIN=MAX(id)
                from SALES_REP
            end
        
        if LEN(ISNULL(@CLIENTE_INI,''))=0
            begin
                select @CLIENTE_INI=MIN(id),@CLIENTE_FIN=MAX(id)
                from CUSTOMER
            end
        
        if LEN(isnull(@PRODUCTO_INI,''))=0
            begin
                select @PRODUCTO_INI=MIN(id),@PRODUCTO_FIN=MAX(id)
                from part
            end
    end
    
    begin
        select r.DOCUMENT_ID,r.NUMBER_SERIE,r.NUMBER_DOCUMENT,r.DOCUMENT_DATE,
                r.SALES_REP_ID,r.PLACE_SALES,r.CUSTOMER_ID,r.CUSTOMER_NAME,
                r.VAT_REGISTRATION,rl.WAREHOUSE_ID,r.TERMS_ID,
                r.SELL_RATE,r.CURRENCY_ID,r.NUMBER_ORDER,rl.PART_ID,rl.PART_DESCRIPTION,rl.QTY,UNIT,rl.PRICE_ORI,
                rl.AMOUNT_TAX,rl.TAX_PERCENT,rl.AMOUNT_US,rl.AMOUNT,PART_LOT 
        from receivable r
        inner join RECEIVABLE_LINE rl
            on r.DOCUMENT_ID=rl.DOCUMENT_ID
            and r.NUMBER_SERIE=rl.NUMBER_SERIE
            and r.NUMBER_DOCUMENT=rl.NUMBER_DOCUMENT
        inner join SALES_REP sr
            on r.SALES_REP_ID=sr.ID
        where convert(varchar(10),r.DOCUMENT_DATE,103) between @FECHA_INI and @FECHA_FIN
        and r.SALES_REP_ID between @VENDEDOR_INI and @VENDEDOR_FIN
        and r.CUSTOMER_ID between @CLIENTE_INI and @CLIENTE_FIN
        and rl.PART_ID between @PRODUCTO_INI and @PRODUCTO_FIN
        order by r.DOCUMENT_DATE
    end