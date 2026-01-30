CREATE TABLE [dbo].[PURCHASE_QUOTE_LINE] (
    [ID]               VARCHAR (10)    NULL,
    [ITEM]             TINYINT         NULL,
    [PART_ID]          VARCHAR (20)    NULL,
    [PART_DESCRIPTION] VARCHAR (64)    NULL,
    [UNIT]             VARCHAR (10)    NULL,
    [QTY]              NUMERIC (15, 6) NULL,
    [PRICE]            NUMERIC (15, 6) NULL,
    [AMOUNT_TAX]       NUMERIC (15, 6) NULL,
    [AMOUNT]           NUMERIC (15, 6) NULL,
    [GUARANTEE]        VARCHAR (80)    NULL,
    [QUALITY]          VARCHAR (80)    NULL,
    [MARK]             VARCHAR (80)    NULL,
    [COMMENT]          VARCHAR (250)   NULL,
    [CURRENCY_ID]      VARCHAR (2)     NULL,
    [DISCOUNT]         NUMERIC (15, 6) NULL,
    [DLV_DATE]         SMALLDATETIME   NULL,
    [IS_VAT]           VARCHAR (1)     NULL,
    [PROJECT_ID]       VARCHAR (20)    NULL,
    [CC_ID]            VARCHAR (20)    NULL,
    [AREA_ID]          VARCHAR (20)    NULL,
    [REQUI_ID]         VARCHAR (20)    NULL
);

