CREATE TABLE [dbo].[CARRIER] (
    [ID]                    VARCHAR (11)  NOT NULL,
    [NAME_CARRIER]          VARCHAR (50)  NULL,
    [ADDR]                  VARCHAR (100) NULL,
    [PHONE]                 VARCHAR (25)  NULL,
    [VAT_REGISTRATION]      VARCHAR (20)  NULL,
    [STATUS]                VARCHAR (1)   NULL,
    [CREATE_DATE]           SMALLDATETIME NULL,
    [NAME]                  VARCHAR (50)  NULL,
    [VAT_REGISTRATION_COMP] VARCHAR (11)  NULL,
    [ADDR_COMP]             VARCHAR (50)  NULL,
    [PHONE_COMP]            VARCHAR (25)  NULL,
    [NUMBER_REGISTRATION]   VARCHAR (10)  NULL,
    [NUMBER_LICENSE]        VARCHAR (15)  NULL,
    [MODEL_VEH]             VARCHAR (50)  NULL,
    [NUMBER_INSCRIP]        VARCHAR (50)  NULL,
    [NUMBER_DOCUMENT]       VARCHAR (8)   NULL
);

