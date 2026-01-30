CREATE TABLE [dbo].[VENTASCARTERAX] (
    [CUSTOMER_ID]   VARCHAR (11)    NULL,
    [NAME]          VARCHAR (150)   NULL,
    [DOCUMENT_ID]   VARCHAR (2)     NULL,
    [NUMBER_DOC]    VARCHAR (10)    NULL,
    [DOC_DATE]      DATETIME        NULL,
    [CADUCATE_DATE] SMALLDATETIME   NULL,
    [SALDO]         NUMERIC (15, 6) NULL,
    [CURRENCY_ID]   VARCHAR (2)     NULL,
    [SELL_RATE]     NUMERIC (12, 5) NULL,
    [SALDOINI]      NUMERIC (15, 6) NULL,
    [ID]            VARCHAR (2)     NOT NULL,
    [NAME_V]        VARCHAR (30)    NULL,
    [CHEQUE]        INT             NOT NULL
);

