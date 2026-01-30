CREATE TABLE [dbo].[INVENTORY_COUNT] (
    [ID]           VARCHAR (10)  NULL,
    [WAREHOUSE_ID] VARCHAR (3)   NULL,
    [DATE]         SMALLDATETIME NULL,
    [USER_ID]      VARCHAR (15)  NULL,
    [COMMENT]      VARCHAR (255) NULL,
    [STATUS]       VARCHAR (2)   NULL,
    [CONDITION]    INT           DEFAULT (0) NULL,
    [ORDER_ID]     INT           DEFAULT (0) NULL
);

