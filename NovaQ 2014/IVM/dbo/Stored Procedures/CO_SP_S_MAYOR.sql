

   
CREATE PROC [dbo].[CO_SP_S_MAYOR]                      
@P_ANHO INT = 2013,		--NUMERO DE AÑO                
@P_MES INT = 3,			--NUMERO DE MES                
@P_PC VARCHAR(100)='OMS'  --NOMBRE DE PC                
AS                      
                     
 --BUSCAMOS EL SUBDIARIO DE APERTURA                    
 DECLARE @PSUBDIARIO_APE VARCHAR(2)                    
 SET @PSUBDIARIO_APE = (SELECT SD_ID FROM CO_TB_SUBDIARIO SCTS WHERE SD_ES_APER = 1 AND SD_ISTATUS = 1)                
                          
 SELECT                         
 SC_IDCUENTA AS 'AD_CUENTA',PC_DES_CTA,               
 AC_FEC_VOUCHER, 
AC_IDSUBDIARIO + '-'+cast(AC_NUM_VOUCHER as varchar(5))as 'AC_NUM_VOUCHER',   
  AC_GLOSA_VOU, ISNULL(AD_DEBE,0) AS 'AD_DEBE', ISNULL(AD_HABER,0) AS 'AD_HABER',              
 SC_SALDO_D, SC_SALDO_H                      
              
 FROM                       
 (SELECT * FROM CO_TB_TMP_SALDO_CUENTA WHERE SC_PC = @P_PC) S               
 LEFT JOIN               
 (              
 SELECT AC_IDSUBDIARIO,AC_FEC_VOUCHER,AC_NUM_VOUCHER,AC_GLOSA_VOU,B.* FROM CO_TB_ASIENTO_CAB A INNER JOIN CO_TB_ASIENTO_DET B ON A.AC_ID = B.AD_IDCAB               
 WHERE   AC_ANHO   = @P_ANHO               
   AND AC_MES   = @P_MES               
   AND AD_CUENTA  IN (SELECT CODIGO FROM CO_TB_CODIGOS_TMP WHERE PC = @P_PC)                    
   AND AC_IDSUBDIARIO <> (CASE WHEN @P_MES = 1 THEN @PSUBDIARIO_APE ELSE '' END)                 
 ) D               
 ON S.SC_IDCUENTA = D.AD_CUENTA              
              
 INNER JOIN (SELECT PC_NUM_CTA,PC_DES_CTA     
 FROM CO_TB_PLANCTAS WHERE PC_PERIODO = @P_ANHO 
AND PC_NUM_CTA IN (SELECT CA_CTA FROM CO_TB_CTAS_ANT_MES_TMP WHERE CA_PC = @P_PC )
          
)AS P   ON SC_IDCUENTA = PC_NUM_CTA                  


