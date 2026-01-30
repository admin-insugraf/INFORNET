CREATE TABLE [dbo].[RENTABILIDAD_POR_FAMILIA] (
    [FAMILY]            VARCHAR (8)     NULL,
    [MODEL]             VARCHAR (8)     NULL,
    [DESCRIPTION_OPT]   VARCHAR (64)    NULL,
    [PART_ID]           VARCHAR (20)    NULL,
    [DESCRIPTION]       VARCHAR (64)    NULL,
    [NUMBER_DOCUMENT]   VARCHAR (7)     NULL,
    [DOCUMENT_ID]       VARCHAR (2)     NULL,
    [NUMBER_SERIE]      VARCHAR (3)     NULL,
    [CURRENCY_ID]       VARCHAR (2)     NULL,
    [DOCUMENT_DATE]     DATETIME        NULL,
    [CURRENCY_EXCHANGE] NUMERIC (15, 6) NULL,
    [FECHA]             VARCHAR (60)    NULL,
    [QTY]               NUMERIC (15, 6) NULL,
    [PRICE_ORI]         NUMERIC (15, 6) NULL,
    [COSTOMN]           NUMERIC (15, 9) NULL,
    [COSTOME]           NUMERIC (15, 9) NULL
);

