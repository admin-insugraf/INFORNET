CREATE PROCEDURE  ACT_QTY_LOTE_2010_AL_CON_ARTICULO  
@ALMACEN VARCHAR(10),  
@ARTICULO VARCHAR(10)      
  
AS     
--=====================================================================    
-- 1. CREAR TABLA TEMPORAL DE DATOS FILTRADOS (INGRESOS)    
--=====================================================================    
IF EXISTS (SELECT * FROM DBO.SYSOBJECTS WHERE ID = OBJECT_ID(N'[DBO].[TABI]') AND OBJECTPROPERTY(ID, N'ISTABLE') = 1)      
DROP TABLE [DBO].[TABI]      
CREATE TABLE TABI (    
WAREHOUSE_ID VARCHAR(30)  NULL,    
ID VARCHAR(30) NULL,    
NUMBER_LOT VARCHAR(30) NULL,    
QTY DECIMAL(22,9))      
--=====================================================================      
-- 2. CREAR TABLA TEMPORAL DE DATOS FILTRADOS   (SALIDAS)    
--=====================================================================     
IF EXISTS (SELECT * FROM DBO.SYSOBJECTS WHERE ID = OBJECT_ID(N'[DBO].[TABS]') AND OBJECTPROPERTY(ID, N'ISTABLE') = 1)      
DROP TABLE [DBO].[TABS]       
CREATE TABLE TABS (WAREHOUSE_ID VARCHAR(30)  NULL,    
ID VARCHAR(30) NULL,    
NUMBER_LOT VARCHAR(30) NULL,    
QTY DECIMAL(22,9))      
--=====================================================================       
-- CASO 1: INCERTAR DATOS DE INGRESO  EN LA TABLAS DE INGRESOS    
--=====================================================================     
INSERT INTO TABI     
(    
WAREHOUSE_ID,    
ID,    
NUMBER_LOT,    
QTY    
)       
SELECT     
WT.WAREHOUSE_ID ,     
P.ID ,    
WL.NUMBER_LOT,    
SUM(WL.QTY) AS QTY       
FROM WAREHOUSE_TRANS WT     
INNER JOIN WAREHOUSE_TRANS_LINE WL      
ON WT.WAREHOUSE_ID=WL.WAREHOUSE_ID AND WT.DOCUMENT_ID=WL.DOCUMENT_ID AND WT.NUMBER_DOCUMENT=WL.NUMBER_DOCUMENT     
INNER JOIN  PART P      
ON P.ID=WL.PART_ID     
WHERE WT.TYPE_TRANS='I' AND P.IS_LOT='S'  AND WT.WAREHOUSE_ID=@ALMACEN AND  WT.TRANS_ID<>'GF' AND WT.STATUS_GUIA<>'A'  AND WL.PART_ID=@ARTICULO  
GROUP BY WT.WAREHOUSE_ID , P.ID ,WL.NUMBER_LOT     
ORDER BY WL.NUMBER_LOT        
--=====================================================================     
-- CASO 2: INCERTAR DATOS DE SALIDA  EN LA TABLA DE SALIDAS    
--=====================================================================      
INSERT INTO TABS     
(    
WAREHOUSE_ID,    
ID,    
NUMBER_LOT,    
QTY    
)       
SELECT     
WT.WAREHOUSE_ID ,     
P.ID ,    
WL.NUMBER_LOT,    
SUM(WL.QTY) AS QTY       
FROM WAREHOUSE_TRANS WT     
INNER JOIN WAREHOUSE_TRANS_LINE WL      
ON WT.WAREHOUSE_ID=WL.WAREHOUSE_ID AND WT.DOCUMENT_ID=WL.DOCUMENT_ID AND WT.NUMBER_DOCUMENT=WL.NUMBER_DOCUMENT     
INNER JOIN  PART P      
ON P.ID=WL.PART_ID     
WHERE WT.TYPE_TRANS='S' AND P.IS_LOT='S' AND WT.WAREHOUSE_ID=@ALMACEN AND  WT.TRANS_ID<>'GF' AND WT.STATUS_GUIA<>'A'  AND WL.PART_ID=@ARTICULO  
GROUP BY WT.WAREHOUSE_ID , P.ID ,WL.NUMBER_LOT     
ORDER BY WL.NUMBER_LOT       
--=====================================================================       
-- 3. CREAR TABLA DE RESULTADOS      
--=====================================================================     
IF EXISTS (SELECT * FROM DBO.SYSOBJECTS WHERE ID = OBJECT_ID(N'[DBO].[TAB2]') AND OBJECTPROPERTY(ID, N'ISTABLE') = 1)      
DROP TABLE [DBO].[TAB2]      
CREATE TABLE TAB2 (    
WAREHOUSE_ID VARCHAR(30)  NULL,    
ID VARCHAR(30) NULL,    
NUMBER_LOT VARCHAR(30) NULL,    
QTY DECIMAL(22,9))      
--=====================================================================        
-- INSERTAR CALCULO DE CANTIDADES INGRESO-SALIDA      
--=====================================================================    
INSERT INTO TAB2     
(    
WAREHOUSE_ID,    
ID,    
NUMBER_LOT,    
QTY    
)      
SELECT     
I.WAREHOUSE_ID,    
I.ID,    
I.NUMBER_LOT,    
(I.QTY-S.QTY)AS QTY     
FROM TABI I     
INNER JOIN TABS S     
ON I.WAREHOUSE_ID= S.WAREHOUSE_ID AND S.ID=I.ID AND  I.NUMBER_LOT=S.NUMBER_LOT       
--=====================================================================      
-- INSERTO DATOS QUE SOLO EXISTEN EN INGREOS      
--=====================================================================      
INSERT INTO TAB2 (    
WAREHOUSE_ID,    
ID,    
NUMBER_LOT,    
QTY    
)      
SELECT     
I.WAREHOUSE_ID,    
I.ID,    
I.NUMBER_LOT,    
I.QTY     
FROM TABI I     
LEFT JOIN TABS S     
ON I.WAREHOUSE_ID= S.WAREHOUSE_ID AND S.ID=I.ID AND  I.NUMBER_LOT=S.NUMBER_LOT      
WHERE  S.WAREHOUSE_ID IS NULL AND S.ID IS NULL AND   S.NUMBER_LOT IS NULL        
--=====================================================================      
--ACTUALIZO LA TABLA LOT CON LOS DATOS DE TAB2 (TABLA RESULTADOS)    
--=====================================================================        
UPDATE LOT SET  QTY_ON_HAND= T.QTY       
FROM TAB2 T     
INNER JOIN LOT L     
ON T.WAREHOUSE_ID=L.WHO_ID AND T.ID=L.PART_ID AND T.NUMBER_LOT=L.LOT_ID       
WHERE T.WAREHOUSE_ID=L.WHO_ID AND T.ID=L.PART_ID AND T.NUMBER_LOT=L.LOT_ID    
--==============================================================================        
--ACTUALIZO LA TABLA PART_QTY CON LOS DATOS DE LA TABLA TAB2(TABLA RESULTADOS)    
--==============================================================================    
/*ESTE ES EL CURSOR QUE ACTUALIZA LOS DATOS DE LA TABLA    
PART_QTY CON LOS DATOS DE LA TABLA LOT*/    
--DECLARAMOS NUESTRAS VARIABLES QUE VAN A RECEPCIONAR LOS DATOS Q NOS DEVUELVE NUESTRA CONSULTA    
DECLARE @PARTICULO AS VARCHAR(15)    
DECLARE @PSUMA_ARTICULO AS NUMERIC(15,6)    
    
DECLARE  ACTUALIZA CURSOR FOR    
 SELECT DISTINCT PART_ID FROM LOT    
 WHERE WHO_ID=@ALMACEN  AND PART_ID=@ARTICULO  
 ORDER BY PART_ID    
OPEN ACTUALIZA    
FETCH NEXT FROM ACTUALIZA    
INTO @PARTICULO    
WHILE  @@FETCH_STATUS=0    
 BEGIN    
      
  SELECT @PSUMA_ARTICULO=SUM(QTY_ON_HAND) FROM LOT    
  WHERE WHO_ID=@ALMACEN AND PART_ID=@PARTICULO    
      
  UPDATE  PART_QTY SET QTY_ON_HAND=@PSUMA_ARTICULO    
  WHERE PART_ID=@PARTICULO AND WAREHOUSE_ID=@ALMACEN    
      
  FETCH NEXT FROM ACTUALIZA    
  INTO @PARTICULO    
 END    
CLOSE ACTUALIZA    
DEALLOCATE ACTUALIZA
