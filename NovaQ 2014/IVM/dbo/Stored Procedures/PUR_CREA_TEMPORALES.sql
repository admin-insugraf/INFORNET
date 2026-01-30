CREATE procedure [dbo].[PUR_CREA_TEMPORALES]
--DECLARE
@OPCION AS INTEGER,
@IDE AS VARCHAR(80)
/*SET @OPCION=1
SET @IDE='DEVELOPER04'*/
as
      declare @STRquery nvarchar(4000)
       IF @OPCION=1
	set @STRquery='CREATE TABLE TEMPDB.dbo.'+@IDE+'PURCHASE_QUOTE_LINE (
		           [ID] [varchar] (10) NULL,
			   [ITEM] [tinyint] NULL ,
		   	   [PART_ID] [varchar] (20)  NULL ,
		   	   [PART_DESCRIPTION] [varchar] (64) NULL ,
		  	   [UNIT] [varchar] (6) NULL ,
		   	   [QTY] [numeric](15, 6) NULL DEFAULT(0),
		                [PRICE] [numeric](15, 6) NULL DEFAULT(0) ,
		   	   [AMOUNT_TAX] [numeric](15, 6) NULL DEFAULT(0),
		                [AMOUNT] [numeric](15, 6) NULL DEFAULT(0),
		                [GUARANTEE] [varchar] (80) NULL ,
        		                [QUALITY] [varchar] (80) NULL ,
   			   [MARK] [varchar] (80) NULL ,
   			   [COMMENT] [varchar] (20)  NULL ,
   			   [CURRENCY_ID] [varchar] (2)   NULL ,
   			   [DISCOUNT] [numeric](15, 6) NULL DEFAULT(0),
  			   [DLV_DATE] [smalldatetime] NULL,
			   [IS_VAT] [bit] NULL,
			   [PROJECT_ID] [varchar] (20)   NULL ,
			   [CC_ID] [varchar] (20)   NULL ,
			   [AREA_ID] [varchar] (20)   NULL ,
			   [REQUI_ID] [varchar] (20)   NULL ) ON [PRIMARY]'
--PRINT @STRquery
             exec sp_executesql @STRquery,N'@OPCION varchar(2), @IDE varchar(50)',
                  @OPCION, @IDE
