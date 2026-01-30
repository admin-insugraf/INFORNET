CREATE TABLE [dbo].[REQUIREMENT_SERVICE_LINE] (
    [ID]             VARCHAR (10)    NULL,
    [SERVICE_ID]     VARCHAR (6)     NULL,
    [SERVICE_NAME]   VARCHAR (80)    NULL,
    [QTY]            NUMERIC (15, 6) NULL,
    [STATUS]         VARCHAR (2)     NULL,
    [CCOST]          VARCHAR (6)     NULL,
    [ITEM]           TINYINT         NULL,
    [AMOUNT_BALANCE] NUMERIC (15, 6) NULL,
    [COMMENT]        VARCHAR (250)   NULL
);

