CREATE TABLE [dbo].[TRANSACTION_TYPE] (
    [TYPE_ID]           VARCHAR (1)  NOT NULL,
    [MOV_ID]            VARCHAR (2)  NOT NULL,
    [NAME]              VARCHAR (40) NULL,
    [IS_VALUED]         VARCHAR (1)  NULL,
    [IS_VENDOR]         VARCHAR (1)  NULL,
    [IS_DOC_REF]        VARCHAR (1)  NULL,
    [IS_AUTHORIZED]     VARCHAR (1)  NULL,
    [IS_CCOST]          VARCHAR (1)  NULL,
    [IS_ORDER_PURCHASE] VARCHAR (1)  NULL,
    [IS_COMMENT]        VARCHAR (1)  NULL,
    [IS_WHO]            VARCHAR (1)  NULL,
    [IS_CUSTOMER]       VARCHAR (1)  NULL,
    [IS_ORDER_MANUFACT] VARCHAR (1)  NULL,
    [IS_POST]           BIT          NULL,
    [IS_ACCOUNT]        VARCHAR (1)  NULL,
    [VAR_COUNT]         DECIMAL (18) NULL
);



