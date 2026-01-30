CREATE TABLE [dbo].[CHECK_EXCHANGE_LINE] (
    [ID]               VARCHAR (6)   NOT NULL,
    [ITEM]             NUMERIC (18)  NOT NULL,
    [TYPE_DOC]         VARCHAR (2)   NULL,
    [NUMBER_DOC]       VARCHAR (10)  NULL,
    [DATE]             DATETIME      NULL,
    [CURRENCY_ID]      CHAR (2)      NULL,
    [AMOUNT]           MONEY         NULL,
    [AMOUNT_BALANCE]   MONEY         NULL,
    [AMOUNT_ACT]       MONEY         NULL,
    [BANK_DESCRIPTION] VARCHAR (100) NULL,
    [BANK_ID]          VARCHAR (2)   NULL,
    [DIF_DATE]         DATETIME      NULL,
    [NUMBER_TYPE]      CHAR (1)      NOT NULL
);

