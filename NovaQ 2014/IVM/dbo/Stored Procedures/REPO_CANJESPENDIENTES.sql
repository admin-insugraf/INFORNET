
--REPO_CANJESPENDIENTES 'COMERCIAL','DEVELOPER02','01','08','01','20533984992','ME','LT','CH','FT','COMERCIAL'



    /*CREADO : 18/05/2007: REPORTE DE CANJES PENDIENTES */    
CREATE  PROCEDURE [dbo].[REPO_CANJESPENDIENTES]          
--DECLARE           
@BASE AS VARCHAR(10),@IDE AS VARCHAR(80), @CODVEN1 AS VARCHAR(2), @CODVEN2 AS VARCHAR(2),
@CODCLIE1 AS VARCHAR(11), @CODCLIE2 AS VARCHAR(11),  
@MONEDA AS VARCHAR(2), @OPCIONLT  VARCHAR(2),@OPCIONCH  VARCHAR(2),@OPCIONFT  VARCHAR(2),    
@BASE1 AS VARCHAR(10)    
  
/*
SET @BASE='COMERCIAL'            
SET @IDE='DEVELOPER02'            
SET @CODVEN1='01'            
SET @CODVEN2='08'        
SET @CODCLIE1='01'            
SET @CODCLIE2='20533984992'        
SET @MONEDA='ME'    
SET @OPCIONLT='LT'    
SET @OPCIONCH='CH'    
SET @OPCIONFT='FT'    
SET @BASE1='COMERCIAL'    
*/
  
AS                
SET NOCOUNT ON            
SET QUOTED_IDENTIFIER off            
            
 IF EXISTS(SELECT * FROM tempdb.dbo.SYSOBJECTS WHERE XTYPE='U' AND NAME=''+@IDE+'CANJESPENDIENTES')            
 BEGIN               
     EXEC('DROP TABLE TEMPDB.DBO.'+@IDE+'CANJESPENDIENTES')            
 END          
            
 EXEC ('CREATE TABLE TEMPDB.DBO.'+@IDE+'CANJESPENDIENTES(CODVEN VARCHAR(2),NOMVEN VARCHAR(30) NULL,            
 CODCLIE VARCHAR(11) NULL,NOMCLIE VARCHAR(70) NULL,TIPDOC VARCHAR(2), NUMDOC VARCHAR(10), FECEMI DATETIME,          
 FECVTO DATETIME, MONTO NUMERIC(15,6) DEFAULT(0))')              
    
 EXEC ('UPDATE C SET C.TERMS=F.TERMS_ID  FROM ['+@BASE+'].dbo.RECEIVABLE F INNER JOIN ['+@BASE+'].dbo.CUSTOMER_BALANCE C ON   
       F.DOCUMENT_ID=C.DOCUMENT_ID AND F.NUMBER_SERIE+F.NUMBER_DOCUMENT=C.NUMBER_DOC AND F.CUSTOMER_ID = C.CUSTOMER_ID WHERE C.TERMS IS NULL')  
  
IF @OPCIONLT='LT'          
 EXEC ('SET QUOTED_IDENTIFIER off INSERT INTO tempdb.dbo.'+@ide+'CANJESPENDIENTES           
        select V.ID,V.NAME,C1.CUSTOMER_ID,M.NAME,C1.DOCUMENT_ID,C1.NUMBER_DOC,C1.DOC_DATE,C1.CADUCATE_DATE,    
        (CASE '''+@MONEDA+''' when ''ME'' THEN (CASE C1.CURRENCY_ID WHEN ''ME'' THEN C1.AMOUNT_BALANCE ELSE C1.AMOUNT_BALANCE/(CASE C1.SELL_RATE WHEN 0 THEN 1 ELSE C1.SELL_RATE END) END)            
        else (CASE C1.CURRENCY_ID WHEN ''MN'' THEN C1.AMOUNT_BALANCE ELSE C1.AMOUNT_BALANCE*C1.SELL_RATE END) END) AS SALDO       
        from ['+@BASE+'].dbo.LETTER_EXCHANGE c INNER join ['+@BASE+'].dbo.LETTER_EXCHANGE_LINE d on           
        c.ID=d.ID LEFT join ['+@BASE+'].dbo.CUSTOMER_BALANCE c1 on           
        c1.DOCUMENT_ID=d.TYPE_DOC and c1.NUMBER_DOC=d.NUMBER_DOC            
        LEFT join ['+@BASE+'].dbo.SALES_REP v on c1.SALES_ID=v.ID           
        LEFT join ['+@BASE+'].dbo.CUSTOMER m on m.ID=c1.CUSTOMER_ID          
        LEFT join ['+@BASE1+'].dbo.FORMAPAGO f on f.CODFP=c1.TERMS  
        where d.IS_ORIG=''S'' AND C.STATUS=''P'' and C1.SALES_ID>='''+@codven1+''' and C1.SALES_ID<='''+@codven2+''' AND C1.CUSTOMER_ID>='''+@codclie1+''' and C1.CUSTOMER_ID<='''+@codclie2+'''  
      ')   
 IF @OPCIONCH ='CH'       
  EXEC ('SET QUOTED_IDENTIFIER off INSERT INTO tempdb.dbo.'+@ide+'CANJESPENDIENTES           
        select V.ID,V.NAME,C1.CUSTOMER_ID,M.NAME,C1.DOCUMENT_ID,C1.NUMBER_DOC,C1.DOC_DATE,C1.CADUCATE_DATE,    
        (CASE '''+@MONEDA+''' when ''ME'' THEN (CASE C1.CURRENCY_ID WHEN ''ME'' THEN C1.AMOUNT_BALANCE ELSE C1.AMOUNT_BALANCE/(CASE C1.SELL_RATE WHEN 0 THEN 1 ELSE C1.SELL_RATE END) END)            
        else (CASE C1.CURRENCY_ID WHEN ''MN'' THEN C1.AMOUNT_BALANCE ELSE C1.AMOUNT_BALANCE*C1.SELL_RATE END) END) AS SALDO       
        from  ['+@BASE+'].dbo.CUSTOMER_BALANCE c1                 
        inner join ['+@BASE+'].dbo.SALES_REP v on c1.SALES_ID=v.ID           
        inner join ['+@BASE+'].dbo.CUSTOMER m on m.ID=c1.CUSTOMER_ID          
        inner join ['+@BASE1+'].dbo.FORMAPAGO f on f.CODFP=c1.TERMS  
        where C1.SALES_ID>='''+@codven1+''' and C1.SALES_ID<='''+@codven2+''' AND C1.CUSTOMER_ID>='''+@codclie1+''' and C1.CUSTOMER_ID<='''+@codclie2+''' AND abs(C1.AMOUNT_BALANCE)>0.01  AND F.TIPOFP=''CH''       
      ')        
    
 IF @OPCIONFT ='FT'       
  PRINT ('SET QUOTED_IDENTIFIER off INSERT INTO tempdb.dbo.'+@ide+'CANJESPENDIENTES           
        select V.ID,V.NAME,C1.CUSTOMER_ID,M.NAME,C1.DOCUMENT_ID,C1.NUMBER_DOC,C1.DOC_DATE,C1.CADUCATE_DATE,    
        (CASE '''+@MONEDA+''' when ''ME'' THEN (CASE C1.CURRENCY_ID WHEN ''ME'' THEN C1.AMOUNT_BALANCE ELSE C1.AMOUNT_BALANCE/(CASE C1.SELL_RATE WHEN 0 THEN 1 ELSE C1.SELL_RATE END) END)            
        else (CASE C1.CURRENCY_ID WHEN ''MN'' THEN C1.AMOUNT_BALANCE ELSE C1.AMOUNT_BALANCE*C1.SELL_RATE END) END) AS SALDO       
        from  ['+@BASE+'].dbo.CUSTOMER_BALANCE c1   
        inner join ['+@BASE+'].dbo.SALES_REP v on c1.SALES_ID=v.ID           
        inner join ['+@BASE+'].dbo.CUSTOMER m on m.ID=c1.CUSTOMER_ID          
        inner join ['+@BASE1+'].dbo.formapago f on f.codfp=c1.TERMS  
        where C1.SALES_ID>='''+@codven1+''' and C1.SALES_ID<='''+@codven2+''' AND c1.CUSTOMER_ID>='''+@codclie1+''' and c1.CUSTOMER_ID<='''+@codclie2+''' AND abs(C1.AMOUNT_BALANCE)>0.01  AND F.TIPOFP=''FT''       
      ')        
              
   declare @STRquery nvarchar(1500)          
   SET @STRquery='select * from  tempdb.dbo.'+@ide+'CANJESPENDIENTES ORDER BY NOMVEN, TIPDOC,NUMDOC'          
   exec sp_executesql @STRquery,N'@ide AS varchar(80),@codven1 AS varchar(2), @codven2 AS varchar(2), @codclie1 as varchar(11), @codclie2 as varchar(11),@moneda as varchar(2),  
        @BASE1 AS VARCHAR(10),@OPCIONLT AS VARCHAR(2),@OPCIONCH AS VARCHAR(2), @OPCIONFT AS VARCHAR(2)',  
        @IDE,@codven1,@codven2,@codclie1,@codclie2,@moneda,@base1,@opcionlt,@opcionch, @opcionft  
  
  
  
  
  
  