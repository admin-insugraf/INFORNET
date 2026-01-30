CREATE TABLE [dbo].[ACCOUNT_ENTRY_TYPE] (
    [ID]               NVARCHAR (2)  NOT NULL,
    [NAME]             NVARCHAR (30) NULL,
    [ABBREVIATION]     NVARCHAR (3)  NULL,
    [IS_OPENING_ENTER] BIT           NOT NULL
);

