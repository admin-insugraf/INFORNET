CREATE TABLE [dbo].[COMPANY] (
    [ID]                 VARCHAR (50)  NOT NULL,
    [DOC_ID]             VARCHAR (2)   NULL,
    [NAME]               VARCHAR (30)  NULL,
    [LAST_NAME_PATERNAL] VARCHAR (50)  NULL,
    [LAST_NAME_MATERNAL] VARCHAR (50)  NULL,
    [ADDR]               VARCHAR (50)  NULL,
    [PHONE]              VARCHAR (15)  NULL,
    [FAX]                VARCHAR (15)  NULL,
    [VAT_REGISTRATION]   VARCHAR (11)  NULL,
    [REPRESENTATIVE]     VARCHAR (40)  NULL,
    [DOCUMENT]           VARCHAR (15)  NULL,
    [LEVEL]              SMALLINT      NULL,
    [LEVEL1]             SMALLINT      NULL,
    [LEVEL2]             SMALLINT      NULL,
    [LEVEL3]             SMALLINT      NULL,
    [LEVEL4]             SMALLINT      NULL,
    [LEVEL5]             SMALLINT      NULL,
    [LEVEL6]             SMALLINT      NULL,
    [SCREEN]             VARCHAR (20)  NULL,
    [REPORT_SCREEN]      VARCHAR (100) NULL,
    [AUTONUMERIC]        BIT           NOT NULL,
    [CHARACTER]          NUMERIC (18)  NULL,
    [NAME_COMPANY]       VARCHAR (50)  NULL,
    [ADDRESS1]           VARCHAR (100) NULL,
    [ANNEX_ID]           VARCHAR (50)  NULL
);



