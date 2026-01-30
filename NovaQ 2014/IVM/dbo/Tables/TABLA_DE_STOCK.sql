CREATE TABLE [dbo].[TABLA_DE_STOCK] (
    [ID]                  VARCHAR (20)    NOT NULL,
    [DESCRIPTION]         VARCHAR (64)    NULL,
    [NAME]                VARCHAR (45)    NULL,
    [DESCRIPTION_OPT]     VARCHAR (64)    NULL,
    [WAREHOUSE_ID]        VARCHAR (2)     NOT NULL,
    [STOCK]               DECIMAL (15, 4) NULL,
    [UNIT_OF_MEASUREMENT] VARCHAR (6)     NULL,
    [ID_FAB]              VARCHAR (40)    NULL,
    [COSTO_PROMEDIO]      NUMERIC (19, 6) NULL
);

