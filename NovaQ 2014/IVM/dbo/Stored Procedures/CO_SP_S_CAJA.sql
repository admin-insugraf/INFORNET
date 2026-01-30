

/*        
Libro caja bancos ( detalle del Efectivo)         
para el formato sunat 2010 >        
*/                  
CREATE PROC [dbo].[CO_SP_S_CAJA]                  
@P_ANHO INT = 2013,     --numero de año            
@P_MES INT = 3,      --numero de mes            
@P_PC VARCHAR(100)='OMS',  --nombre de pc            
@P_MONEDA INT = 1  
AS                    
                    
--BUSCAMOS EL SUBDIARIO DE APERTURA                
DECLARE @PSUBDIARIO_APE VARCHAR(2)                
set @PSUBDIARIO_APE= (SELECT SD_ID FROM CO_TB_SUBDIARIO WHERE SD_ES_APER = 1 AND SD_ISTATUS = 1)                
                
                
                    
SELECT                       
 AC_IDSUBDIARIO+'-'+ cast(AC_NUM_VOUCHER as varchar(5)) as 'AC_NUM_VOUCHER',                  
AC_FEC_VOUCHER,                  
AC_GLOSA_VOU,                  
(case when @P_MONEDA = 1 then  
AD_DEBE   
else   
(case when AD_TCAM = 0 then AD_DEBE / AD_TCAM else AD_MONTO_ORI end)  
end) as 'AD_DEBE',               
  
(case when @P_MONEDA = 1 then  
b.AD_HABER   
else   
(case when b.AD_TCAM = 0 then AD_HABER / AD_TCAM else AD_MONTO_ORI end)  
end) as 'AD_HABER',              
                 
SCTTSC.SC_SALDO_D,                   
SCTTSC.SC_SALDO_H,                  
AD_CUENTA,                  
PC_DES_CTA         
FROM                     
   CO_TB_ASIENTO_CAB a                     
INNER JOIN CO_TB_ASIENTO_DET b ON b.AD_IDCAB  = a.AC_ID                    
INNER JOIN CO_TB_PLANCTAS c ON b.AD_CUENTA = c.PC_NUM_CTA                    
INNER JOIN CO_TB_TMP_SALDO_CUENTA SCTTSC ON b.AD_CUENTA = SCTTSC.SC_IDCUENTA 
--LEFT JOIN  (select * from SG_CO_TB_TIPOCAMBIO where TC_IDEMPRESA = 1 ) tc on a.AC_FEC_VOUCHER = tc.TC_FECHA  
        
WHERE                     
  a.AC_ANHO  = @P_ANHO                     
 AND a.AC_MES  = @P_MES                     
  AND SCTTSC.SC_PC  = @P_PC                    
 AND b.AD_CUENTA  IN                     
    ( SELECT CODIGO                   
     FROM CO_TB_CODIGOS_TMP                   
     WHERE PC = @P_PC)                  
 AND a.AC_IDSUBDIARIO <> (CASE WHEN @P_MES = 1 THEN @PSUBDIARIO_APE ELSE '' END) 

