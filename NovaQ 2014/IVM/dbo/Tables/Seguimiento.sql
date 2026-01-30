CREATE TABLE [dbo].[Seguimiento] (
    [IdSeg]        VARCHAR (6)     NOT NULL,
    [NomProT]      VARCHAR (50)    NULL,
    [LocalOcu]     VARCHAR (50)    NULL,
    [DirecOcu]     VARCHAR (50)    NULL,
    [FecOcu]       DATETIME        NULL,
    [MovSol]       DECIMAL (10, 4) NULL,
    [MovDol]       DECIMAL (10, 4) NULL,
    [Stado]        VARCHAR (30)    NULL,
    [ID]           VARCHAR (11)    NOT NULL,
    [IdUser]       VARCHAR (6)     NOT NULL,
    [IdOcu]        VARCHAR (6)     NOT NULL,
    [EmailAddress] VARCHAR (50)    NULL,
    [Phone]        VARCHAR (15)    NULL,
    [Fax]          VARCHAR (15)    NULL,
    [Revisado]     VARCHAR (10)    NULL
);

