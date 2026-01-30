CREATE TABLE [dbo].[tmpPendxTipDoc] (
    [DOCUMENT_ID]    VARCHAR (2)      NULL,
    [TDNAME]         VARCHAR (30)     NULL,
    [NUMBER_DOC]     VARCHAR (10)     NULL,
    [ID]             VARCHAR (11)     NULL,
    [CNAME]          VARCHAR (70)     NULL,
    [DOC_DATE]       DATETIME         NULL,
    [CURRENCY_ID]    VARCHAR (2)      NULL,
    [AMOUNT]         NUMERIC (15, 6)  NULL,
    [AMOUNT_BALANCE] NUMERIC (15, 6)  NULL,
    [CADUCATE_DATE]  SMALLDATETIME    NULL,
    [SELL_RATE]      NUMERIC (12, 5)  NULL,
    [TERMS]          VARCHAR (4)      NULL,
    [NAME]           VARCHAR (32)     NULL,
    [PagMN]          NUMERIC (28, 11) NULL,
    [PagME]          NUMERIC (33, 19) NULL
);

