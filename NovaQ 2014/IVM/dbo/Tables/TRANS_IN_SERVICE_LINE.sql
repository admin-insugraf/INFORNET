CREATE TABLE [dbo].[TRANS_IN_SERVICE_LINE] (
    [TYPE_ID]          VARCHAR (2)     NOT NULL,
    [ITEM]             NUMERIC (15, 6) NOT NULL,
    [NUMBER_DOC]       VARCHAR (10)    NOT NULL,
    [PART_ID]          VARCHAR (20)    NULL,
    [PART_DESCRIPTION] VARCHAR (50)    NULL,
    [UNIT]             VARCHAR (6)     NULL,
    [CCOST]            VARCHAR (6)     NULL,
    [QTY]              NUMERIC (15, 6) NULL,
    [QTY_IN]           NUMERIC (15, 6) NULL,
    [QTY_REF]          NUMERIC (15, 6) NULL,
    [QTY_FAC]          NUMERIC (15, 6) NULL,
    [PRICE_UNIT]       NUMERIC (15, 6) NULL,
    [PRICE]            NUMERIC (15, 6) NULL,
    [AMOUNT_TOTAL]     NUMERIC (15, 6) NULL,
    [AMOUNT_TAX]       NUMERIC (15, 6) NULL,
    [AMOUNT]           NUMERIC (15, 6) NULL,
    [AMOUNT_US]        NUMERIC (15, 6) NULL
);

