CREATE TABLE [dbo].[DATA_IMPORT] (
    [ID]                   VARCHAR (13)   NOT NULL,
    [BILL_NAME_COMPANY]    VARCHAR (60)   NULL,
    [BILL_ADDRESS_COMPANY] VARCHAR (60)   NULL,
    [BILL_TELFAX]          VARCHAR (60)   NULL,
    [BILL_CONTAC]          VARCHAR (60)   NULL,
    [BILL_FAX]             VARCHAR (60)   NULL,
    [EMBARQUE]             VARCHAR (100)  NULL,
    [TERMS_TYPE]           VARCHAR (100)  NULL,
    [NAME_FACT]            VARCHAR (250)  NULL,
    [ADJUNTAR]             VARCHAR (250)  NULL,
    [IMPORTANT]            VARCHAR (250)  NULL,
    [DOCUMENTS]            VARCHAR (100)  NULL,
    [COMMENT]              VARCHAR (250)  NULL,
    [COMMENT_TECNIC]       VARCHAR (4000) NULL
);

