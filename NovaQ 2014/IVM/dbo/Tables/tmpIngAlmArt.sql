CREATE TABLE [dbo].[tmpIngAlmArt] (
    [WAREHOUSE_ID]      VARCHAR (2)     NULL,
    [DOCUMENT_ID]       VARCHAR (2)     NULL,
    [TYPE_TRANS]        VARCHAR (1)     NULL,
    [NUMBER_DOCUMENT]   VARCHAR (10)    NOT NULL,
    [DATE_DOCUMENT]     DATETIME        NULL,
    [TRANS_ID]          VARCHAR (2)     NULL,
    [DOC_ID_REF]        VARCHAR (2)     NULL,
    [NUM_ID_REF]        VARCHAR (10)    NULL,
    [VENDOR_ID]         VARCHAR (11)    NULL,
    [CURRENCY_TYPE]     VARCHAR (2)     NULL,
    [CURRENCY_EXCHANGE] NUMERIC (15, 6) NULL,
    [VENDOR_NAME]       VARCHAR (50)    NULL,
    [PART_ID]           VARCHAR (20)    NULL,
    [PART_DESCRIPTION]  VARCHAR (64)    NULL,
    [UNIT_PART]         VARCHAR (6)     NULL,
    [QTY]               NUMERIC (15, 6) NULL,
    [AVERAGE_COST]      NUMERIC (15, 6) NULL
);

