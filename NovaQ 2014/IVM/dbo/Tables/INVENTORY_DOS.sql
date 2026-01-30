CREATE TABLE [dbo].[INVENTORY_DOS] (
    [ITEM]         INT             NULL,
    [PART_ID]      VARCHAR (20)    NULL,
    [DATE]         SMALLDATETIME   NULL,
    [TIME]         VARCHAR (8)     NULL,
    [IS_IN_OUT]    VARCHAR (1)     NULL,
    [TRANS_ID]     VARCHAR (2)     NULL,
    [TYPE_DOC]     VARCHAR (2)     NULL,
    [WAREHOUSE_ID] VARCHAR (2)     NULL,
    [NUMBER_DOC]   VARCHAR (20)    NULL,
    [QTY_INITIAL]  FLOAT (53)      NULL,
    [QTY_IN]       FLOAT (53)      NULL,
    [QTY_OUT]      FLOAT (53)      NULL,
    [QTY_VALANCE]  FLOAT (53)      NULL,
    [UNIT_PRICE]   FLOAT (53)      NULL,
    [INIT_VALUE]   FLOAT (53)      NULL,
    [IN_VALUE]     FLOAT (53)      NULL,
    [OUT_VALUE]    FLOAT (53)      NULL,
    [END_VALUE]    FLOAT (53)      NULL,
    [AVERAGE_COST] NUMERIC (15, 6) NULL,
    [IS_VALUE]     BIT             NULL
);

