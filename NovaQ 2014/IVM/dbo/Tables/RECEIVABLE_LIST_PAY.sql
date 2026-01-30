CREATE TABLE [dbo].[RECEIVABLE_LIST_PAY] (
    [ID]               VARCHAR (6)     NOT NULL,
    [DATE]             SMALLDATETIME   NOT NULL,
    [AMOUNT]           NUMERIC (15, 6) NULL,
    [AMOUNT_US]        NUMERIC (15, 6) NULL,
    [AMOUNT_CH_DIF]    NUMERIC (15, 6) NULL,
    [AMOUNT_CH_DIF_US] NUMERIC (15, 6) NULL,
    [VOUCHER_ID]       VARCHAR (6)     NULL,
    [STATUS]           VARCHAR (1)     NOT NULL,
    [CREATE_DATE]      SMALLDATETIME   NULL,
    [USER_ID]          VARCHAR (8)     NULL,
    [SALES_ID]         VARCHAR (2)     NOT NULL,
    [VOUCHER_ID_US]    VARCHAR (6)     NULL
);

