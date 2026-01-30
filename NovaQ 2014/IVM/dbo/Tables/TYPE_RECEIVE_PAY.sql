CREATE TABLE [dbo].[TYPE_RECEIVE_PAY] (
    [TYPE]           VARCHAR (1)   NULL,
    [RECEIVE_ID]     VARCHAR (2)   NULL,
    [DESCRIPTION]    VARCHAR (50)  NULL,
    [CURRENCY_ID]    VARCHAR (2)   NULL,
    [ACCOUNT]        VARCHAR (18)  NULL,
    [VENDOR_ID]      BIT           NOT NULL,
    [BANK_ID]        BIT           NOT NULL,
    [USER_ID]        VARCHAR (8)   NULL,
    [DATE]           SMALLDATETIME NULL,
    [EFFECTIVE_DATE] SMALLDATETIME NULL,
    [IS_CHECK_DIF]   BIT           NOT NULL,
    [IS_APPL]        BIT           NOT NULL,
    [TRANS_TYPE]     INT           NULL,
    [IS_CREDIT_CARD] BIT           NULL
);

