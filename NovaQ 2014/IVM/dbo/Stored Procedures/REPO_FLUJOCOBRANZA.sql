

--REPO_FLUJOCOBRANZA 'COMERCIAL','DEVELOPER02','CH','LT','FT','VE','S',8,1,'39564','01','08''01','20533984992'
/*CREADO : 18/05/2007: REPORTE DE FLUJO DE COBRANZA */            
CREATE PROCEDURE [dbo].[REPO_FLUJOCOBRANZA]            
--DECLARE                   
@BASE AS VARCHAR(10),@IDE AS VARCHAR(80), @TIPODOCCH AS VARCHAR(2),             
@TIPODOCLT AS VARCHAR(2), @TIPODOCFT AS VARCHAR(2),@TIPOVENCIDOS AS VARCHAR(2),      
@AGRUPADO AS VARCHAR(1),@NRODIASLETRAS AS INT,@NRODIASVENCIDOS AS INT,              
@FECHAACTUAL AS NUMERIC(15,6), @VEN1 AS VARCHAR(2), @VEN2 AS VARCHAR(2),
 @CLIE1  AS VARCHAR(11), @CLIE2 AS VARCHAR(11)  
 /*   
SET @BASE='002BDCOMUN'                    
SET @IDE='developer04'                    
SET @NRODIASLETRAS=8       
SET @TIPODOCCH=''      
SET @TIPODOCLT=''      
SET @TIPODOCFT=''      
set @TIPOVENCIDOS='VE'            
SET @AGRUPADO='S'                
SET @NRODIASLETRAS=8      
SET @NRODIASVENCIDOS=30    
SET @FECHAACTUAL=39229      
--*/    
AS       
  SET NOCOUNT ON                    
  SET  QUOTED_IDENTIFIER off                         
                    
  IF EXISTS(SELECT * FROM tempdb.dbo.SYSOBJECTS WHERE XTYPE='U' AND NAME=''+@IDE+'FLUJOCOBRANZA')                    
  BEGIN                       
     EXEC('DROP TABLE TEMPDB.DBO.'+@IDE+'FLUJOCOBRANZA')                    
  END                  
                  
  EXEC ('CREATE TABLE TEMPDB.DBO.'+@IDE+'FLUJOCOBRANZA(CODVEN VARCHAR(2),NOMVEN VARCHAR(30) NULL,                    
  CODCLIE VARCHAR(11) NULL,NOMCLIE VARCHAR(70) NULL,TIPDOC VARCHAR(2), NUMDOC VARCHAR(10), FECEMI DATETIME,                  
  FECVTO SMALLDATETIME, SALDOMN NUMERIC(15,6) DEFAULT(0),SALDOME NUMERIC(15,6) DEFAULT(0),       
  NRODIASLETRAS NUMERIC(15,6) DEFAULT(0),TIPODOCAGRU VARCHAR(2),NROSEMANA NUMERIC(15,0) DEFAULT(0))')                      
    
  declare @fecha AS varchar(10)    
  declare @Nrodiasletras1 as varchar(10)          
  declare @Nrodiasvencidos1 as varchar(10)          
  set @fecha=str(@fechaactual)        
  set @Nrodiasletras1=str(@Nrodiasletras)        
  set @Nrodiasvencidos1=str(@Nrodiasvencidos)        
    
 IF @AGRUPADO='N'              
    exec (' INSERT INTO tempdb.dbo.'+@ide+'FLUJOCOBRANZA       
            select V.ID,V.NAME,C.CUSTOMER_ID,M.NAME,C.DOCUMENT_ID,C.NUMBER_DOC,C.DOC_DATE,C.CADUCATE_DATE,            
            (CASE C.CURRENCY_ID WHEN ''MN'' THEN C.AMOUNT_BALANCE ELSE 0  END) AS SALDOMN,     
            (CASE C.CURRENCY_ID WHEN ''ME'' THEN C.AMOUNT_BALANCE ELSE 0  END) AS SALDOME,                       
             0,'''',cast(cast(year(C.CADUCATE_DATE) as varchar(4))+           
            (case Len(cast(datepart(week,C.CADUCATE_DATE) as varchar(20))) when  1           
             then ''0'' + cast(datepart(week,C.CADUCATE_DATE) as varchar(20))           
             else cast(datepart(week,C.CADUCATE_DATE) as varchar(20)) end) as numeric(15,0)) AS NROSEMANA            
             FROM ['+@BASE+'].dbo.CUSTOMER_BALANCE c inner join ['+@BASE+'].dbo.SALES_REP v on c.SALES_ID=v.ID                   
             inner join ['+@BASE+'].dbo.CUSTOMER m on m.ID=c.CUSTOMER_ID                  
             where abs(C.AMOUNT_BALANCE)>0.01 and C.SALES_ID>='''+@ven1+''' and C.SALES_ID<='''+@ven2+''' and C.CUSTOMER_ID>='''+@clie1+''' and C.CUSTOMER_ID<='''+@clie2+''' ')                
 ELSE      
  BEGIN      
   IF @TIPODOCCH='CH'      
    exec (' INSERT INTO tempdb.dbo.'+@ide+'FLUJOCOBRANZA       
            select V.ID,V.NAME,C.CUSTOMER_ID,M.NAME,C.DOCUMENT_ID,C.NUMBER_DOC,C.DOC_DATE,C.CADUCATE_DATE,            
            (CASE C.CURRENCY_ID WHEN ''MN'' THEN C.AMOUNT_BALANCE ELSE 0  END) AS SALDOMN,  (CASE C.CURRENCY_ID WHEN ''ME'' THEN C.AMOUNT_BALANCE ELSE 0  END) AS SALDOME,                       
             0,''CH'',cast(cast(year(C.CADUCATE_DATE) as varchar(4))+           
            (case Len(cast(datepart(week,C.CADUCATE_DATE) as varchar(20))) when  1           
             then ''0'' + cast(datepart(week,C.CADUCATE_DATE) as varchar(20))           
             else cast(datepart(week,C.CADUCATE_DATE) as varchar(20)) end) as numeric(15,0)) AS NROSEMANA            
             FROM ['+@BASE+'].dbo.CUSTOMER_BALANCE c inner join ['+@BASE+'].dbo.SALES_REP v on c.SALES_ID=v.ID                   
             inner join ['+@BASE+'].dbo.CUSTOMER m on m.ID=c.CUSTOMER_ID                  
             where abs(C.AMOUNT_BALANCE)>0.01 AND C.DOCUMENT_ID=''CH'' AND C.CADUCATE_DATE +'+@NRODIASVENCIDOS1+'>'+@fecha+' and C.SALES_ID>='''+@ven1+''' and C.SALES_ID<='''+@ven2+''' and C.CUSTOMER_ID>='''+@clie1+''' and C.CUSTOMER_ID<='''+@clie2+'''')                
    
   IF @TIPODOCLT='LT'      
    exec (' INSERT INTO tempdb.dbo.'+@ide+'FLUJOCOBRANZA       
            select V.ID,V.NAME,C.CUSTOMER_ID,M.NAME,C.DOCUMENT_ID,C.NUMBER_DOC,C.DOC_DATE,C.CADUCATE_DATE,            
            (CASE C.CURRENCY_ID WHEN ''MN'' THEN C.AMOUNT_BALANCE ELSE 0  END) AS SALDOMN,  (CASE C.CURRENCY_ID WHEN ''ME'' THEN C.AMOUNT_BALANCE ELSE 0  END) AS SALDOME,                       
             '+@NRODIASLETRAS1+',''LT'',cast(cast(year(C.CADUCATE_DATE) as varchar(4))+           
            (case Len(cast(datepart(week,C.CADUCATE_DATE) as varchar(20))) when  1           
             then ''0'' + cast(datepart(week,C.CADUCATE_DATE) as varchar(20))           
             else cast(datepart(week,C.CADUCATE_DATE) as varchar(20)) end) as numeric(15,0)) AS NROSEMANA            
             FROM ['+@BASE+'].dbo.CUSTOMER_BALANCE c inner join ['+@BASE+'].dbo.SALES_REP v on c.SALES_ID=v.ID                   
             inner join ['+@BASE+'].dbo.CUSTOMER m on m.ID=c.CUSTOMER_ID                  
             where abs(C.AMOUNT_BALANCE)>0.01 AND C.DOCUMENT_ID=''LT'' AND C.CADUCATE_DATE +'+@NRODIASLETRAS1+'+'+@NRODIASVENCIDOS1+'>'+@fecha+' and C.SALES_ID>='''+@ven1+''' and C.SALES_ID<='''+@ven2+''' and C.CUSTOMER_ID>='''+@clie1+''' and C.CUSTOMER_ID<='''+@clie2+'''')         
       
      
   IF @TIPODOCFT='FT'      
    exec (' INSERT INTO tempdb.dbo.'+@ide+'FLUJOCOBRANZA       
            select V.ID,V.NAME,C.CUSTOMER_ID,M.NAME,C.DOCUMENT_ID,C.NUMBER_DOC,C.DOC_DATE,C.CADUCATE_DATE,            
            (CASE C.CURRENCY_ID WHEN ''MN'' THEN C.AMOUNT_BALANCE ELSE 0  END) AS SALDOMN,  (CASE C.CURRENCY_ID WHEN ''ME'' THEN C.AMOUNT_BALANCE ELSE 0  END) AS SALDOME,                       
             0,''FT'',cast(cast(year(C.CADUCATE_DATE) as varchar(4))+           
            (case Len(cast(datepart(week,C.CADUCATE_DATE) as varchar(20))) when  1           
             then ''0'' + cast(datepart(week,C.CADUCATE_DATE) as varchar(20))           
             else cast(datepart(week,C.CADUCATE_DATE) as varchar(20)) end) as numeric(15,0)) AS NROSEMANA            
             FROM ['+@BASE+'].dbo.CUSTOMER_BALANCE c inner join ['+@BASE+'].dbo.SALES_REP v on c.SALES_ID=v.ID                   
             inner join ['+@BASE+'].dbo.CUSTOMER m on m.ID=c.CUSTOMER_ID                  
             where abs(C.AMOUNT_BALANCE)>0.01 AND C.DOCUMENT_ID<>''CH'' AND C.DOCUMENT_ID<>''LT'' AND C.CADUCATE_DATE +'+@NRODIASVENCIDOS1+'>'+@fecha+' and C.SALES_ID>='''+@ven1+''' and C.SALES_ID<='''+@ven2+''' and C.CUSTOMER_ID>='''+@clie1+''' and C.CUSTOMER_ID<='''+@clie2+'''')      
  
    
   IF @TIPOVENCIDOS='VE'        
    EXEC (' INSERT INTO tempdb.dbo.'+@ide+'FLUJOCOBRANZA       
            select V.ID,V.NAME,C.CUSTOMER_ID,M.NAME,C.DOCUMENT_ID,C.NUMBER_DOC,C.DOC_DATE,C.CADUCATE_DATE,            
            (CASE C.CURRENCY_ID WHEN ''MN'' THEN C.AMOUNT_BALANCE ELSE 0  END) AS SALDOMN,  (CASE C.CURRENCY_ID WHEN ''ME'' THEN C.AMOUNT_BALANCE ELSE 0  END) AS SALDOME,                       
            (CASE C.DOCUMENT_ID WHEN ''LT'' THEN '+@NRODIASLETRAS1+' ELSE 0 END),''VE'',cast(cast(year(C.CADUCATE_DATE) as varchar(4))+           
            (case Len(cast(datepart(week,C.CADUCATE_DATE) as varchar(20))) when  1           
             then ''0'' + cast(datepart(week,C.CADUCATE_DATE) as varchar(20))           
             else cast(datepart(week,C.CADUCATE_DATE) as varchar(20)) end) as numeric(15,0)) AS NROSEMANA            
             FROM ['+@BASE+'].dbo.CUSTOMER_BALANCE c inner join ['+@BASE+'].dbo.SALES_REP v on c.SALES_ID=v.ID                   
             inner join ['+@BASE+'].dbo.CUSTOMER m on m.ID=c.CUSTOMER_ID                  
             where abs(C.AMOUNT_BALANCE)>0.01 AND C.CADUCATE_DATE + (CASE C.DOCUMENT_ID WHEN ''LT'' THEN '+@NRODIASLETRAS1+'+'+@NRODIASVENCIDOS1+' ELSE  '+@NRODIASVENCIDOS1+' END)<='+@fecha+' and C.SALES_ID>='''+@ven1+''' and C.SALES_ID<='''+@ven2+''' and C.CUSTOMER_ID>='''+@clie1+''' and C.CUSTOMER_ID<='''+@clie2+'''')      
  
/*  
     IF NOT(@TIPODOCCH='CH' AND @TIPODOCLT='LT' AND @TIPODOCFT='FT')        
        PRINT (' INSERT INTO ['+@BASE+'].dbo.cartera c    
             select cod_ven,des_ven,cdocodcli,cnomcli,cdotipdoc,cdonrodoc,cdofecdoc,cdofecven,            
            (CASE CDOTIPMON WHEN ''MN'' THEN cdosaldo ELSE 0  END) AS SALDOMN,  (CASE CDOTIPMON WHEN ''ME'' THEN cdosaldo ELSE 0  END) AS SALDOME,                       
             0,''VE'',cast(cast(year(cdofecven) as varchar(4))+           
            (case Len(cast(datepart(week,cdofecven) as varchar(20)))     
             when  1 Then ''0'' + cast(datepart(week,cdofecven) as varchar(20))           
             else cast(datepart(week,cdofecven) as varchar(20)) end) as numeric(15,0)) AS NROSEMANA            
             FROM ['+@BASE+'].dbo.cartera c inner join ['+@BASE+'].dbo.vendedor v on c.cdocodven=v.cod_ven                   
             inner join ['+@BASE+'].dbo.maecli m on m.ccodcli=c.cdocodcli                  
             where abs(CDOSALDO)>0.01 AND CDOFECVEN + (CASE CDOTIPDOC WHEN ''LT'' THEN '+@NRODIASLETRAS1+'+'+@NRODIASVENCIDOS1+' ELSE  '+@NRODIASVENCIDOS1+' END)<'+@fecha+'')      
      ELSE      
       EXEC (' UPDATE T SET TIPODOCAGRU=''VE'' FROM tempdb.dbo.'+@ide+'FLUJOCOBRANZA T                   
              where FECVTO +'+@NRODIASLETRAS1+'+'+@NRODIASVENCIDOS1+'<'+@fecha+'')      
*/  
   END         
    
   declare @STRquery nvarchar(4000)                  
   SET @STRquery='select * from  tempdb.dbo.'+@ide+'FLUJOCOBRANZA'                  
   exec sp_executesql @STRquery,N'@ide AS varchar(80),@NRODIASLETRAS AS INT,@base as varchar(10),      
      @NRODIASVENCIDOS AS INT,@fecha AS VARCHAR(10), @ven1 as varchar(2), @ven2 as varchar(2), @clie1 as varchar(11), @clie2 as varchar(11)',            
      @IDE,@NRODIASLETRAS,@base,@NRODIASVENCIDOS,@fecha,@ven1,@ven2,@clie1,@clie2    