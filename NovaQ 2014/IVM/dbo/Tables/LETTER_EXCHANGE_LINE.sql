CREATE TABLE [dbo].[LETTER_EXCHANGE_LINE] (
    [ID]            VARCHAR (6)     NULL,
    [ITEM]          VARCHAR (3)     NULL,
    [TYPE_DOC]      VARCHAR (2)     NULL,
    [NUMBER_DOC]    VARCHAR (10)    NULL,
    [AMOUNT]        NUMERIC (15, 6) NULL,
    [CADUCATE_DATE] SMALLDATETIME   NULL,
    [IS_ORIG]       VARCHAR (1)     NULL
);

