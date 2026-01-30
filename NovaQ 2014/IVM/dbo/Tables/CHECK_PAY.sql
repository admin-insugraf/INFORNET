CREATE TABLE [dbo].[CHECK_PAY] (
    [CUSTOMER_ID]       VARCHAR (11)    NOT NULL,
    [CHECK_ID]          VARCHAR (21)    NOT NULL,
    [BANK_ID]           VARCHAR (50)    NULL,
    [CURRENCY_ID]       VARCHAR (2)     NULL,
    [AMOUNT]            NUMERIC (15, 6) NULL,
    [CUST_BANK_ACCOUNT] VARCHAR (50)    NULL,
    [NUMBER_LIST]       VARCHAR (6)     NULL,
    [ITEM]              VARCHAR (3)     NULL,
    [STATUS]            VARCHAR (1)     NULL,
    [CREATE_DATE]       SMALLDATETIME   NULL,
    [USER_ID]           VARCHAR (8)     NULL,
    [EFFECTIVE_DATE]    SMALLDATETIME   NULL,
    [REGISTER_DATE]     SMALLDATETIME   NULL,
    [DIF_DATE]          SMALLDATETIME   NULL,
    [LAST_NUMBER_LIST]  INT             NULL,
    [NUMBER_LIST_LINE]  INT             NULL
);

