CREATE TABLE [dbo].[CHECK_EXCHANGE] (
    [ID]          CHAR (10)    NOT NULL,
    [DATE]        DATETIME     NULL,
    [CREATE_DATE] DATETIME     NULL,
    [USER_ID]     VARCHAR (8)  NULL,
    [CUSTOMER_ID] VARCHAR (11) NULL,
    [SELL_RATE]   MONEY        NULL,
    [AMOUNT]      MONEY        NULL,
    [CURRENCY_ID] CHAR (2)     NULL,
    [SALES_ID]    CHAR (2)     NULL
);

