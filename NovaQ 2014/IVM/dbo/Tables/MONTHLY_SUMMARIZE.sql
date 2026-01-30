CREATE TABLE [dbo].[MONTHLY_SUMMARIZE] (
    [WAREHOUSE_ID]       VARCHAR (2)     NULL,
    [PART_ID]            VARCHAR (20)    NULL,
    [YEAR_MONTH]         VARCHAR (6)     NULL,
    [AMOUNT_US]          NUMERIC (15, 6) NULL,
    [AMOUNT]             NUMERIC (15, 6) NULL,
    [AMOUNT_PREVIOUS_US] NUMERIC (15, 6) NULL,
    [AMOUNT_PREVIOUS]    NUMERIC (15, 6) NULL,
    [LAST_MOVE]          VARCHAR (50)    NULL,
    [QTY_ENTER]          NUMERIC (15, 6) NULL,
    [QTY_OUT]            NUMERIC (15, 6) NULL,
    [QTY_PREVIOUS]       NUMERIC (15, 6) NULL,
    [QTY_ACT]            NUMERIC (15, 6) NULL,
    [GROUP_PART_ID]      VARCHAR (3)     NULL,
    [FAMILY_PART_ID]     VARCHAR (8)     NULL,
    [LINE_PART_ID]       VARCHAR (8)     NULL,
    [TYPE]               VARCHAR (1)     NULL,
    [QTY_INITIAL]        NUMERIC (15, 6) NULL
);

