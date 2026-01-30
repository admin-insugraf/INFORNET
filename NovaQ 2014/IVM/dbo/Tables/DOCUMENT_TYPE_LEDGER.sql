CREATE TABLE [dbo].[DOCUMENT_TYPE_LEDGER] (
    [ID]               VARCHAR (2)  NOT NULL,
    [DESCRIPTION]      VARCHAR (25) NOT NULL,
    [SUNAT_ID]         VARCHAR (2)  NULL,
    [IS_MINUS]         BIT          NULL,
    [IS_REFERENCE]     BIT          NULL,
    [DOC_FILE]         VARCHAR (8)  NULL,
    [IS_CADUCATE_DATE] BIT          NULL
);

