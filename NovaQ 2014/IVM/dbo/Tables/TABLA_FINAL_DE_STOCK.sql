CREATE TABLE [dbo].[TABLA_FINAL_DE_STOCK] (
    [ID]                  VARCHAR (20)    NOT NULL,
    [DESCRIPTION]         VARCHAR (64)    NULL,
    [NAME]                VARCHAR (45)    NULL,
    [DESCRIPTION_OPT]     VARCHAR (64)    NULL,
    [UNIT_OF_MEASUREMENT] VARCHAR (6)     NULL,
    [ID_FAB]              VARCHAR (40)    NULL,
    [COSTO_PROMEDIO]      DECIMAL (15, 4) NULL,
    [ALMACEN1]            FLOAT (53)      NULL,
    [ALMACEN2]            FLOAT (53)      NULL,
    [ALMACEN3]            FLOAT (53)      NULL,
    [ALMACEN4]            FLOAT (53)      NULL,
    [ALMACEN5]            FLOAT (53)      NULL
);

