CREATE TABLE [dbo].[ADDR_CUSTOMER] (
    [CUSTOMER_ID] VARCHAR (11)  NULL,
    [ADDR]        VARCHAR (100) NULL,
    [ZONE_ID]     VARCHAR (2)   NULL,
    [ITEM]        INT           IDENTITY (1, 1) NOT NULL
);

