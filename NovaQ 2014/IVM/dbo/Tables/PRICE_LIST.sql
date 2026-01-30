CREATE TABLE [dbo].[PRICE_LIST] (
    [ID]              VARCHAR (4)     NOT NULL,
    [PART_ID]         VARCHAR (20)    NOT NULL,
    [EFFECTIVE_PRICE] NUMERIC (15, 6) NULL,
    [LAST_PRICE]      NUMERIC (15, 6) NULL,
    [EFFECTIVE_DATE]  SMALLDATETIME   NULL,
    [USER_ID]         VARCHAR (10)    NULL,
    [IS_VAT]          BIT             NOT NULL,
    [LAST_IS_VAT]     BIT             NOT NULL,
    [UNIT_UM]         VARCHAR (6)     NULL,
    [QTY_MAX]         NUMERIC (15, 6) NULL,
    [QTY_MIN]         NUMERIC (15, 6) NULL,
    [AMOUNT_PRICE]    VARCHAR (2)     NULL
);

