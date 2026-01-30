CREATE TABLE [dbo].[TRANS_IN_SERVICE] (
    [TYPE_ID]              VARCHAR (2)     NOT NULL,
    [NUMBER_DOC]           VARCHAR (10)    NOT NULL,
    [DOCUMENT_DATE]        SMALLDATETIME   NULL,
    [TRANS_TYPE_ID]        VARCHAR (1)     NULL,
    [TRANS_ID]             VARCHAR (2)     NULL,
    [STATUS]               VARCHAR (1)     NULL,
    [DOCUMENT_REF]         VARCHAR (2)     NULL,
    [NUMBER_REF]           VARCHAR (10)    NULL,
    [SOLICIT_ID]           VARCHAR (3)     NULL,
    [VENDOR_ID]            VARCHAR (11)    NULL,
    [CCOST]                VARCHAR (6)     NULL,
    [COMMENT]              VARCHAR (250)   NULL,
    [STATUS_GUIA]          VARCHAR (1)     NULL,
    [UPDATE_DATE]          SMALLDATETIME   NULL,
    [USER_ID]              VARCHAR (8)     NULL,
    [CURRENCY_ID]          VARCHAR (2)     NULL,
    [CURRENCY_EXCHANGE]    NUMERIC (15, 6) NULL,
    [NUMBER_ORDER_MANUFAC] VARCHAR (20)    NULL,
    [VENDOR_NAME]          VARCHAR (50)    NULL,
    [AMOUNT]               NUMERIC (15, 6) NULL
);

