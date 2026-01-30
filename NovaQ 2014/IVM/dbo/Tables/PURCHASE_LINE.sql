CREATE TABLE [dbo].[PURCHASE_LINE] (
    [PURCHASE_ID]      INT             IDENTITY (1, 1) NOT NULL,
    [PURCHASE_ID_CAB]  INT             NULL,
    [PART_ID]          VARCHAR (20)    NULL,
    [QTY]              NUMERIC (12, 5) NULL,
    [PRICE_BUY]        NUMERIC (12, 5) NULL,
    [PRICE_ORI]        NUMERIC (12, 5) NULL,
    [AMOUNT_TAX]       NUMERIC (12, 5) NULL,
    [TAX_PERCENT]      NUMERIC (12, 5) NULL,
    [AMOUNT_US]        NUMERIC (12, 5) NULL,
    [AMOUNT]           NUMERIC (12, 5) NULL,
    [BRUTE_AMOUNT]     NUMERIC (12, 5) NULL,
    [UNIT]             VARCHAR (6)     NULL,
    [BRUTE_AMOUNT_US]  NUMERIC (15, 6) NULL,
    [PART_SERIE]       VARCHAR (15)    NULL,
    [WAREHOUSE_ID]     VARCHAR (2)     NULL,
    [DISCOUNT]         NUMERIC (15, 6) NULL,
    [DISCOUNT_PERCENT] NUMERIC (12, 5) NULL,
    [PART_DESCRIPTION] VARCHAR (65)    NULL,
    [PART_LOT]         VARCHAR (20)    NULL
);

