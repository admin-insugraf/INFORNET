CREATE TABLE [dbo].[bdnovaq] (
    [USER_ID]          CHAR (10)     NOT NULL,
    [USER_NAME]        CHAR (15)     NOT NULL,
    [PASSWORD]         CHAR (15)     NULL,
    [DESCRIPTION_USER] VARCHAR (60)  NULL,
    [CREATE_DATE]      DATETIME      NULL,
    [LAST_MODIFY_DATE] DATETIME      NULL,
    [USER_MODIFIED]    VARCHAR (100) NULL,
    [COMPUTER_ID]      VARCHAR (100) NULL,
    [IS_ACTIVE]        CHAR (1)      NULL
);

