CREATE PROC [dbo].[CO_SP_S_DIARIO]          
@P_ANHO INT = 2013,    --numero de año        
@P_MES INT = 5,     --numero de mes        
@P_PC varchar(100)='OMS'  --nombre de pc        
AS          
    
SELECT AC_IDSUBDIARIO + '-'+  right('00000'+cast(AC_NUM_VOUCHER as varchar(5)),5)  as 'AC_NUM_VOUCHER',          
AC_FEC_VOUCHER ,          
AC_GLOSA_VOU,          
AD_CUENTA,          
PC_DES_CTA,          
AD_DEBE,          
AD_HABER,      
AD_TDOC,      
AD_SDOC,      
AD_NDOC          
FROM CO_TB_ASIENTO_CAB a    
INNER JOIN CO_TB_ASIENTO_DET d ON d.AD_IDCAB = a.AC_ID          
INNER JOIN CO_TB_PLANCTAS b ON d.AD_CUENTA = b.PC_NUM_CTA          
WHERE           
AC_ANHO = @P_ANHO          
AND AC_MES = @P_MES          
AND AC_IDSUBDIARIO IN (SELECT CODIGO FROM CO_TB_CODIGOS_TMP where PC = @P_PC)          
ORDER BY AC_NUM_VOUCHER    