CREATE TABLE [dbo].[WAREHOUSE] (
    [ID]           VARCHAR (2)     NOT NULL,
    [NAME]         VARCHAR (25)    NULL,
    [ADDR_WHO]     VARCHAR (40)    NULL,
    [STATE_ID]     VARCHAR (8)     NULL,
    [TYPE_PART]    VARCHAR (2)     NULL,
    [PHONE]        VARCHAR (10)    NULL,
    [LAST_NUM_IN]  NUMERIC (20, 6) NULL,
    [LAST_NUM_OUT] NUMERIC (20, 6) NULL,
    [STATUS]       VARCHAR (1)     NULL,
    [IS_DEFAULT]   VARCHAR (1)     NULL
);



