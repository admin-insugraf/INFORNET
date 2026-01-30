CREATE PROC [dbo].[CO_SP_S_BAL_COMPRO]              
@PANHO INT = 2013,     --NUMERO DE AÑO                            
@PMES INT = 7,      --NUMERO DE MES                            
@DIGITOS INT = 2,    --NUMERO DE DIGITOS PARA AGRUPAR LAS CUENTAS  DE TITULO                
@ACUMULADO INT =1,   --1=ACUMULADO; 0=MENSUAL                  
@CON_CTAS_TIT INT = 1    --INDICA SI MUESTRA CUENTAS TITULO                
AS                              
     
     declare @num_dig_cta int
     set @num_dig_cta = 8
                    
IF @ACUMULADO = 1 BEGIN                  
                
IF @CON_CTAS_TIT = 0 BEGIN                
                  
  SELECT C.PC_NUM_CTA AS CUENTA,C.PC_DES_CTA AS DESCRIPCION,  R.DEBE,R.HABER,R.SALDO_DEUDOR,R.SALDO_ACREEDOR                               
  FROM CO_TB_PLANCTAS C INNER JOIN                              
  (                              
  SELECT                               
                      
  LEFT(AD_CUENTA,@num_dig_cta) AS 'AD_CUENTA',SUM(AD_DEBE)AS DEBE,SUM(AD_HABER)  AS HABER,                              
  (CASE WHEN SUM(AD_DEBE) - SUM(AD_HABER) > 0 THEN  ABS(SUM(AD_DEBE) - SUM(AD_HABER)) ELSE 0 END) AS SALDO_DEUDOR,                              
  (CASE WHEN SUM(AD_DEBE) - SUM(AD_HABER) < 0 THEN  ABS(SUM(AD_DEBE) - SUM(AD_HABER)) ELSE 0 END) AS SALDO_ACREEDOR                              
                                
                                
  FROM  CO_TB_ASIENTO_CAB A INNER JOIN CO_TB_ASIENTO_DET B ON A.AC_ID=B.AD_IDCAB                              
  WHERE  AC_ANHO  = @PANHO                               
    AND AC_MES  <= @PMES                               
  GROUP BY LEFT(AD_CUENTA,@num_dig_cta)                        
  ) R ON left(C.PC_NUM_CTA,@num_dig_cta) = left(R.AD_CUENTA,@num_dig_cta)    
  WHERE  C.PC_PERIODO = @PANHO                    
  ORDER BY CUENTA                   
                
                
END ELSE BEGIN  --DE DIGITOS  ___________________________                
                
                
  SELECT C.PC_NUM_CTA AS CUENTA,C.PC_DES_CTA AS DESCRIPCION,  R.DEBE,R.HABER,R.SALDO_DEUDOR,R.SALDO_ACREEDOR                               
  FROM CO_TB_PLANCTAS C INNER JOIN                              
  (                              
  SELECT                               
                      
  LEFT(AD_CUENTA,@num_dig_cta) AS 'AD_CUENTA',SUM(AD_DEBE)AS DEBE,SUM(AD_HABER)  AS HABER,                              
  (CASE WHEN SUM(AD_DEBE) - SUM(AD_HABER) > 0 THEN  ABS(SUM(AD_DEBE) - SUM(AD_HABER)) ELSE 0 END) AS SALDO_DEUDOR,                              
  (CASE WHEN SUM(AD_DEBE) - SUM(AD_HABER) < 0 THEN  ABS(SUM(AD_DEBE) - SUM(AD_HABER)) ELSE 0 END) AS SALDO_ACREEDOR                              
                                
                                
  FROM  CO_TB_ASIENTO_CAB A INNER JOIN CO_TB_ASIENTO_DET B ON A.AC_ID=B.AD_IDCAB                              
  WHERE  AC_ANHO  = @PANHO                               
    AND AC_MES  <= @PMES                               
                                   
  GROUP BY LEFT(AD_CUENTA,@num_dig_cta)                        
  ) R ON left(C.PC_NUM_CTA,@num_dig_cta) = left(R.AD_CUENTA,@num_dig_cta)              
  WHERE  C.PC_PERIODO = @PANHO              
  UNION                
  SELECT C.PC_NUM_CTA AS CUENTA,C.PC_DES_CTA AS DESCRIPCION,  R.DEBE,R.HABER,R.SALDO_DEUDOR,R.SALDO_ACREEDOR                               
  FROM CO_TB_PLANCTAS C INNER JOIN                              
  (                              
  SELECT                               
  LEFT(AD_CUENTA,@DIGITOS) AS 'AD_CUENTA',SUM(AD_DEBE)AS DEBE,SUM(AD_HABER)  AS HABER,                        
  (CASE WHEN SUM(AD_DEBE) - SUM(AD_HABER) > 0 THEN  ABS(SUM(AD_DEBE) - SUM(AD_HABER)) ELSE 0 END) AS SALDO_DEUDOR,                       
  (CASE WHEN SUM(AD_DEBE) - SUM(AD_HABER) < 0 THEN  ABS(SUM(AD_DEBE) - SUM(AD_HABER)) ELSE 0 END) AS SALDO_ACREEDOR                              
  FROM  CO_TB_ASIENTO_CAB A INNER JOIN CO_TB_ASIENTO_DET B ON A.AC_ID=B.AD_IDCAB                              
  WHERE  AC_ANHO  = @PANHO                
    AND AC_MES  <= @PMES                
    GROUP BY LEFT(AD_CUENTA,@DIGITOS)                        
  ) R ON C.PC_NUM_CTA = R.AD_CUENTA     
  WHERE C.PC_PERIODO = @PANHO        
  ORDER BY CUENTA                   
 END     
                
END   --DE @ACUMULADO                  
                
                
                
                
IF @ACUMULADO = 0 BEGIN                  
 --PRINT @ACUMULADO                
 IF @CON_CTAS_TIT = 0 BEGIN                
                 
   SELECT C.PC_NUM_CTA AS CUENTA,C.PC_DES_CTA AS DESCRIPCION,  R.DEBE,R.HABER,R.SALDO_DEUDOR,R.SALDO_ACREEDOR                               
  FROM CO_TB_PLANCTAS C INNER JOIN                              
  (                              
  SELECT                               
  LEFT(AD_CUENTA,@num_dig_cta) AS 'AD_CUENTA',SUM(AD_DEBE)AS DEBE,SUM(AD_HABER)  AS HABER,                              
  (CASE WHEN SUM(AD_DEBE) - SUM(AD_HABER) > 0 THEN  ABS(SUM(AD_DEBE) - SUM(AD_HABER)) ELSE 0 END) AS SALDO_DEUDOR,                              
  (CASE WHEN SUM(AD_DEBE) - SUM(AD_HABER) < 0 THEN  ABS(SUM(AD_DEBE) - SUM(AD_HABER)) ELSE 0 END) AS SALDO_ACREEDOR                              
  FROM  CO_TB_ASIENTO_CAB A INNER JOIN CO_TB_ASIENTO_DET B ON A.AC_ID = B.AD_IDCAB                              
  WHERE  AC_ANHO  = @PANHO                               
    AND AC_MES = @PMES                               
      
  GROUP BY LEFT(AD_CUENTA,@num_dig_cta)                        
  ) R ON left(C.PC_NUM_CTA,@num_dig_cta) = left(R.AD_CUENTA,@num_dig_cta)  
  WHERE  C.PC_PERIODO = @PANHO                    
  ORDER BY CUENTA                   
                 
 END ELSE BEGIN                
                 
                 
   SELECT C.PC_NUM_CTA AS CUENTA,C.PC_DES_CTA AS DESCRIPCION,  R.DEBE,R.HABER,R.SALDO_DEUDOR,R.SALDO_ACREEDOR                               
  FROM CO_TB_PLANCTAS C INNER JOIN                              
  (                              
  SELECT                               
   LEFT(AD_CUENTA,@num_dig_cta) AS 'AD_CUENTA',SUM(AD_DEBE)AS DEBE,SUM(AD_HABER)  AS HABER,                              
  (CASE WHEN SUM(AD_DEBE) - SUM(AD_HABER) > 0 THEN  ABS(SUM(AD_DEBE) - SUM(AD_HABER)) ELSE 0 END) AS SALDO_DEUDOR,                              
  (CASE WHEN SUM(AD_DEBE) - SUM(AD_HABER) < 0 THEN  ABS(SUM(AD_DEBE) - SUM(AD_HABER)) ELSE 0 END) AS SALDO_ACREEDOR                              
  FROM  CO_TB_ASIENTO_CAB A INNER JOIN CO_TB_ASIENTO_DET B ON A.AC_ID=B.AD_IDCAB                              
  WHERE  AC_ANHO  = @PANHO                               
    AND AC_MES = @PMES                               
  GROUP BY LEFT(AD_CUENTA,@num_dig_cta)                        
  ) R ON left(C.PC_NUM_CTA,@num_dig_cta) = left(R.AD_CUENTA,@num_dig_cta)      
  WHERE  C.PC_PERIODO = @PANHO                    
  UNION                
  SELECT C.PC_NUM_CTA AS CUENTA,C.PC_DES_CTA AS DESCRIPCION,  R.DEBE,R.HABER,R.SALDO_DEUDOR,R.SALDO_ACREEDOR                               
  FROM CO_TB_PLANCTAS C INNER JOIN                              
  (SELECT                               
  LEFT(AD_CUENTA,@DIGITOS) AS 'AD_CUENTA',SUM(AD_DEBE)AS DEBE,SUM(AD_HABER)  AS HABER,                              
  (CASE WHEN SUM(AD_DEBE) - SUM(AD_HABER) > 0 THEN  ABS(SUM(AD_DEBE) - SUM(AD_HABER)) ELSE 0 END) AS SALDO_DEUDOR,                              
  (CASE WHEN SUM(AD_DEBE) - SUM(AD_HABER) < 0 THEN  ABS(SUM(AD_DEBE) - SUM(AD_HABER)) ELSE 0 END) AS SALDO_ACREEDOR                       
  FROM  CO_TB_ASIENTO_CAB A INNER JOIN CO_TB_ASIENTO_DET B ON A.AC_ID=B.AD_IDCAB                              
  WHERE  AC_ANHO  = @PANHO                               
    AND AC_MES = @PMES                               
  GROUP BY LEFT(AD_CUENTA,@DIGITOS)                        
  ) R ON C.PC_NUM_CTA = R.AD_CUENTA      
  WHERE  C.PC_PERIODO = @PANHO                    
  ORDER BY CUENTA                   
                 
 END                
END