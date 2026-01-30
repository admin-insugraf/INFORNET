CREATE TABLE [dbo].[IMPORT_COST_CERTIFICATE] (
    [ID]              VARCHAR (13) NOT NULL,
    [NUMBER_LIQ]      VARCHAR (20) NOT NULL,
    [DOCUMENT_DATE]   DATETIME     NULL,
    [PERCENT_FOB]     FLOAT (53)   NULL,
    [AMOUNT_FOB]      FLOAT (53)   NULL,
    [AMOUNT_TOTAL]    FLOAT (53)   NULL,
    [L_CLOSE]         BIT          NULL,
    [WAREHOUSE_ID]    VARCHAR (2)  NULL,
    [NUMBER_PARTE]    VARCHAR (10) NULL,
    [l_REAL]          BIT          NULL,
    [ACCOUNT]         BIT          NULL,
    [ACCOUNT_VOUCHER] VARCHAR (6)  NULL
);

