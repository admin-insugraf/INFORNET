
  /*CREADO POR EVG - 13/03/2007*/        
CREATE  PROC [dbo].[HSP_LIST_PEDIDOS_DET]        
--DECLARE        
  @EMP AS VARCHAR(50),        
  @NUMPED AS VARCHAR(7),        
  @OPCION AS VARCHAR(1)        
/*        
  SET @OPCION='1'        
  SET @EMP='BDNOVAQ'          
  SET @NUMPED='0000007'        
  */      
AS        
  DECLARE @STRcadena NVARCHAR(1000)        
        
 IF @OPCION='1'         
    SET @STRcadena='SELECT D.WAREHOUSE_ID,D.PART_ID,(CASE WHEN D.PART_ID<>''TEXTO'' THEN D.PART_DESCRIPTION ELSE D.TEXT_COMMENT END)  AS COL1,D.UNIT,         
    (CASE WHEN D.SERIE <> '''' THEN D.SERIE ELSE (CASE WHEN D.LOT <> '''' THEN D.LOT ELSE D.LOT END)END)AS COL2,        
     D.QTY,D.BALANCE,D.PRICE_SALES,(CASE WHEN C.CURRENCY_ID=''ME'' THEN D.AMOUNT_US ELSE D.AMOUNT END) AS COL3,D.PRICE_ORI,  
     D.QTY_REF,D.UNIT,D.DISCOUNT_CUST,D.DISCOUNT_SP,D.PERCENT_DISCOUNT,D.DISCOUNT,D.PERCENT_TAX,D.IS_PART_TAX     
     FROM ' + @EMP + '.dbo.ORDER_LINE D INNER JOIN ' + @EMP + '.dbo.ORDERS C ON D.ID=C.ID   
     WHERE D.ID='''+@NUMPED+''''        
                                         
 IF @OPCION='2'         
    SET @STRcadena='SELECT * FROM ' + @EMP + '.DBO.ORDER_LINE WHERE ID='''+@NUMPED+''''        
       
        
 SET @STRcadena=@strcadena+' ORDER BY ITEM'        
        
EXEC SP_EXECUTESQL @STRcadena,N'@EMP VARCHAR(3),@NUMPED VARCHAR(7),@OPCION VARCHAR(1)'        
                  ,@EMP,@NUMPED,@OPCION        
      
    
  
  
