

          
CREATE PROC [dbo].[CO_SP_S_DOC_PENDIENTE]
@P_CUENTA VARCHAR(50)='421201',
@P_IDANEXO varchar(20) = '02353550391',
@P_ANHO INT = 2013        
AS                  
            
          
          
  SELECT        
  MIN(AD_FDOC) AS FEC_EMISION,AD_TDOC,AD_SDOC,AD_NDOC,                  
  (CASE WHEN SUM(AD_DEBE)-SUM(AD_HABER)>0 THEN SUM(AD_DEBE)-SUM(AD_HABER) ELSE 0 END) AS DEBE,                        
  (CASE WHEN SUM(AD_HABER)-SUM(AD_DEBE)>0 THEN SUM(AD_HABER)-SUM(AD_DEBE) ELSE 0 END) AS HABER,                    
  (CASE WHEN SUM(AD_DEBE)-SUM(AD_HABER)>0 THEN SUM(AD_DEBE) ELSE SUM(AD_HABER) END) AS TOTAL_DEUDA                        
            
  FROM CO_TB_ASIENTO_DET A                   
  INNER JOIN CO_TB_ASIENTO_CAB B ON A.AD_IDCAB = B.AC_ID                    
  WHERE AD_IDANEXO  = @P_IDANEXO                   
  AND AD_CUENTA   = @P_CUENTA                  
  and AC_ANHO = @P_ANHO        
  GROUP BY AD_IDANEXO,AD_TDOC,AD_SDOC,AD_NDOC                  
  HAVING SUM(AD_DEBE)-SUM(AD_HABER)<>0               
  order by 2,AD_SDOC,AD_NDOC 

