CREATE TABLE [dbo].[KARDEX_VAL_CLON] (
    [COD_ART]    VARCHAR (20)  NULL,
    [FEC_DOC]    SMALLDATETIME NULL,
    [HOR_DOC]    VARCHAR (8)   NULL,
    [COD_MOV]    VARCHAR (2)   NULL,
    [TIP_TRANSA] VARCHAR (2)   NULL,
    [NUM_DOC]    VARCHAR (20)  NULL,
    [CAN_ART]    FLOAT (53)    NULL,
    [PRE_UNIT]   FLOAT (53)    NULL,
    [COS_PRO]    FLOAT (53)    NULL,
    [SAL_STOCK]  FLOAT (53)    NULL,
    [COD_FAM]    VARCHAR (10)  NULL,
    [SER_LOT]    VARCHAR (20)  NULL,
    [ASIENTO]    BIT           NULL,
    [ING_SAL]    VARCHAR (20)  NULL,
    [ALMACEN]    VARCHAR (2)   NULL,
    [DEITEM]     INT           NULL,
    [ID]         INT           IDENTITY (1, 1) NOT NULL
);

