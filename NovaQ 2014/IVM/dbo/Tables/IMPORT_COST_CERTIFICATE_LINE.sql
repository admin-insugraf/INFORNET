CREATE TABLE [dbo].[IMPORT_COST_CERTIFICATE_LINE] (
    [ID]                VARCHAR (13)    NOT NULL,
    [NUMBER_LIQ]        VARCHAR (20)    NOT NULL,
    [COST_ID]           VARCHAR (2)     NOT NULL,
    [COMMENT_COST]      VARCHAR (80)    NULL,
    [AMOUNT]            FLOAT (53)      NULL,
    [TYPE]              VARCHAR (1)     NULL,
    [CURRENCY_EXCHANGE] FLOAT (53)      NULL,
    [EXCHANGE_TYPE]     VARCHAR (3)     NULL,
    [CURRENCY_ID]       VARCHAR (2)     NULL,
    [NUMBER_IMPORT_INT] VARCHAR (20)    NULL,
    [AMOUNT_COST_ORIG]  NUMERIC (15, 6) NULL
);

