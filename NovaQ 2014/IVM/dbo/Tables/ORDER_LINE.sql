CREATE TABLE [dbo].[ORDER_LINE] (
    [ID]               VARCHAR (7)     NULL,
    [ITEM]             VARCHAR (3)     NULL,
    [PART_ID]          VARCHAR (20)    NULL,
    [PART_DESCRIPTION] VARCHAR (64)    NULL,
    [QTY]              NUMERIC (15, 6) NULL,
    [PRICE_SALES]      NUMERIC (15, 6) NULL,
    [PRICE_ORI]        NUMERIC (15, 6) NULL,
    [DISCOUNT]         NUMERIC (15, 6) NULL,
    [AMOUNT_TAX]       NUMERIC (15, 6) NULL,
    [DISCOUNT_CUST]    NUMERIC (15, 6) NULL,
    [DISCOUNT_SP]      NUMERIC (15, 6) NULL,
    [PERCENT_TAX]      NUMERIC (15, 6) NULL,
    [PERCENT_DISCOUNT] NUMERIC (15, 6) NULL,
    [AMOUNT_US]        NUMERIC (15, 6) NULL,
    [AMOUNT]           NUMERIC (15, 6) NULL,
    [STATUS]           VARCHAR (1)     NULL,
    [SERIE]            VARCHAR (15)    NULL,
    [WAREHOUSE_ID]     VARCHAR (2)     NULL,
    [TEXT_COMMENT]     VARCHAR (100)   NULL,
    [QTY_REF]          NUMERIC (15, 6) NULL,
    [LOT]              VARCHAR (20)    NULL,
    [BALANCE]          NUMERIC (15, 6) NULL,
    [IS_PART_TAX]      BIT             NULL,
    [LIST_ID]          VARCHAR (2)     NULL,
    [UNIT]             VARCHAR (6)     NULL,
    [AMOUNT_ISC]       NUMERIC (15, 6) NULL,
    [PERCENT_ISC]      NUMERIC (15, 6) NULL
);



