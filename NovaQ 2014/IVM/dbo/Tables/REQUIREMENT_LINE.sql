CREATE TABLE [dbo].[REQUIREMENT_LINE] (
    [ID]               VARCHAR (10)    NULL,
    [TYPE]             VARCHAR (2)     NULL,
    [ITEM]             TINYINT         NULL,
    [PART_ID]          VARCHAR (20)    NULL,
    [PART_DESCRIPTION] VARCHAR (64)    NULL,
    [UNIT]             VARCHAR (10)    NULL,
    [QTY]              NUMERIC (15, 6) NULL,
    [STATUS]           VARCHAR (1)     NULL,
    [DOCUMENT_DATE]    SMALLDATETIME   NULL,
    [AMOUNT_BALANCE]   NUMERIC (15, 6) NULL,
    [CCOST_ID]         VARCHAR (10)    NULL,
    [COMMENT]          VARCHAR (250)   NULL,
    [PROJECT_ID]       VARCHAR (20)    NULL
);

