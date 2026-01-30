CREATE TABLE [dbo].[CONFIGURATION] (
    [ID]               VARCHAR (15) NULL,
    [IS_NUM_LOCK]      BIT          NOT NULL,
    [FIND_ID]          BIT          NOT NULL,
    [WAREHOUSE_ID]     VARCHAR (10) NULL,
    [WAREHOUSE_TYPE]   VARCHAR (1)  NULL,
    [ENTER_ID]         VARCHAR (8)  NULL,
    [DR_ID]            VARCHAR (10) NULL,
    [CR_ID]            VARCHAR (10) NULL,
    [ANALYTICAL_ENTRY] VARCHAR (2)  NULL,
    [IS_DIRECT_PRINT]  BIT          NULL,
    [TYPE_ENTRY]       INT          NULL
);

