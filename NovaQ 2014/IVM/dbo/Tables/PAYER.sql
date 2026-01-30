CREATE TABLE [dbo].[PAYER] (
    [ID]               VARCHAR (2)   NOT NULL,
    [NAME]             VARCHAR (30)  NULL,
    [ADDR]             VARCHAR (100) NULL,
    [PHONE]            VARCHAR (8)   NULL,
    [EMAIL]            VARCHAR (30)  NULL,
    [VAT_REGISTRATION] VARCHAR (11)  NULL,
    [TERRITORY_ID]     VARCHAR (2)   NULL,
    [SEGMENT_ID]       VARCHAR (2)   NULL,
    [UBICATION_ID]     VARCHAR (2)   NULL,
    [ZONE_ID]          VARCHAR (2)   NULL,
    [CREATE_DATE]      SMALLDATETIME NULL,
    [USER_ID]          VARCHAR (25)  NULL,
    [ROUTE_ID]         VARCHAR (2)   NULL,
    [DOC_NUMBER]       VARCHAR (11)  NULL
);

