CREATE TABLE [dbo].[CO_TB_ASIENTO_CAB] (
    [AC_ID]           INT           IDENTITY (1, 1) NOT NULL,
    [AC_IDSUBDIARIO]  VARCHAR (2)   NULL,
    [AC_NUM_VOUCHER]  INT           NULL,
    [AC_ANHO]         INT           NULL,
    [AC_MES]          INT           NULL,
    [AC_FEC_VOUCHER]  DATETIME      NULL,
    [AC_IDMONEDA]     INT           NULL,
    [AC_DEBE]         FLOAT (53)    NULL,
    [AC_HABER]        FLOAT (53)    NULL,
    [AC_ESTADO]       INT           NULL,
    [AC_GLOSA_VOU]    VARCHAR (100) NULL,
    [AC_ES_INTERFACE] INT           NULL,
    [AC_IDPLANILLA]   VARCHAR (6)   NULL,
    CONSTRAINT [PK_CO_TB_ASIENTO_CAB] PRIMARY KEY CLUSTERED ([AC_ID] ASC)
);

