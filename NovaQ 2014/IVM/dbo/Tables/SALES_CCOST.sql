CREATE TABLE [dbo].[SALES_CCOST] (
    [SUBD_ID]            NVARCHAR (2)    NULL,
    [VOUCHER_ID]         NVARCHAR (4)    NULL,
    [DATE]               SMALLDATETIME   NULL,
    [COMMENT]            NVARCHAR (60)   NULL,
    [CURRENCY_ID]        NVARCHAR (2)    NULL,
    [CURR_EXCHANGE_TYPE] NVARCHAR (3)    NULL,
    [CURR_EXCHANGE_SP]   NUMERIC (20, 3) NULL,
    [CURRENCY_DATE]      SMALLDATETIME   NULL,
    [CURRENCY_EXCHANGE]  NUMERIC (20, 6) NULL,
    [AMOUNT_DR]          NUMERIC (20, 2) NULL,
    [AMOUNT_CR]          NUMERIC (20, 2) NULL,
    [AMOUNT_DR_US]       NUMERIC (20, 2) NULL,
    [AMOUNT_CR_US]       NUMERIC (20, 2) NULL,
    [NUMBER_AUTO]        BIT             NOT NULL,
    [COST_MOV]           BIT             NOT NULL,
    [CHECK_MOV]          BIT             NOT NULL,
    [BUY_MOV]            BIT             NOT NULL,
    [SELL_MOV]           BIT             NOT NULL,
    [CADUCATE_DATE]      SMALLDATETIME   NULL,
    [WAREHOUSE_ID]       VARCHAR (10)    NULL
);

