

      
                 
                      
CREATE PROC [dbo].[CO_SP_S_BANCOS]                      
@P_ANHO INT = 2013,    --numero de año                
@P_MES INT = 3,     --numero de mes                
@P_PC VARCHAR(100) = 'OMS',  --nombre de pc                
@P_MONEDA INT = 1          
AS                        
          
--BUSCAMOS EL SUBDIARIO DE APERTURA                    
DECLARE @PSUBDIARIO_APE VARCHAR(2)                    
set @PSUBDIARIO_APE= (SELECT SD_ID FROM CO_TB_SUBDIARIO WHERE SD_ES_APER = 1 AND SD_ISTATUS = 1)                    
                    
                    
                        
SELECT                           
AC_IDSUBDIARIO+'-'+ cast(AC_NUM_VOUCHER as varchar(5)) as 'AC_NUM_VOUCHER',                                       
SCTAC.AC_FEC_VOUCHER,                      
SCTAD.AD_IDMEDIOPAGO,                      
SCTAC.AC_GLOSA_VOU,                      
SCTAD.AD_NDOC,                      
'' AS RAZON,          
          
(case when   SCTAD.AD_DEBE > 0 then         
(case when @P_MONEDA = 1 then          
SCTAD.AD_DEBE           
else           
--(case when SCTAD.AD_TCAM = 0 then AD_DEBE / TC_VENTA else AD_MONTO_ORI end)          
AD_MONTO_ORI   
end)         
else 0 end)as 'AD_DEBE',                       
        
(case when   SCTAD.AD_haber > 0 then           
(case when @P_MONEDA = 1 then          
SCTAD.AD_HABER           
else           
--(case when SCTAD.AD_TCAM = 0 then AD_HABER / TC_VENTA else AD_MONTO_ORI end)          
AD_MONTO_ORI   
end)         
else 0 end) as 'AD_HABER',                      
          
          
SCTTSC.SC_SALDO_D,                       
SCTTSC.SC_SALDO_H,                      
          
ban.name as 'BA_NOMBRE',                      
SCTAD.AD_CUENTA,                      
ban.ACCOUNT_BANK_ID ,                      
ban.ACCOUNT_BANK_DES                       
          
FROM      
   CO_TB_ASIENTO_CAB SCTAC                         
INNER JOIN CO_TB_ASIENTO_DET SCTAD   ON SCTAD.AD_IDCAB  = SCTAC.AC_ID                        
INNER JOIN (select PC_NUM_CTA,PC_DES_CTA     
   from CO_TB_PLANCTAS where pc_periodo = @P_ANHO ) AS A    ON SCTAD.AD_CUENTA = A.PC_NUM_CTA                        
INNER JOIN CO_TB_TMP_SALDO_CUENTA SCTTSC ON SCTAD.AD_CUENTA = SCTTSC.SC_IDCUENTA 
INNER JOIN (SELECT A.*,B.* FROM BANK A     
   inner join account_bank b on a.ID = b.bank_id ) ban on SCTAD.AD_CUENTA = ban.number_account
--INNER JOIN SG_CO_TB_BANCO SCTB ON SCTB.BA_ID = SCTBC.BC_IDBANCO                  
--INNER JOIN SG_CO_TB_BANCO_CTACTE SCTBC   ON SCTAD.AD_CUENTA =  SCTBC.BC_NUM_CTA_CONTA                       
--LEFT JOIN  (select * from SG_CO_TB_TIPOCAMBIO where TC_IDEMPRESA = 1 ) tc on SCTAC.AC_FEC_VOUCHER = tc.TC_FECHA          
WHERE                         
  SCTAC.AC_ANHO  = @P_ANHO                         
 AND SCTAC.AC_MES  = @P_MES                         
 AND SCTTSC.SC_PC  = @P_PC                        
 AND SCTAD.AD_CUENTA  IN                         
    ( SELECT CODIGO                       
     FROM CO_TB_CODIGOS_TMP                       
     WHERE PC = @P_PC)                      
 AND SCTAC.AC_IDSUBDIARIO <> (CASE WHEN @P_MES = 1 THEN @PSUBDIARIO_APE ELSE '' END)           
 AND SCTAC.AC_IDSUBDIARIO <> (CASE WHEN @P_MONEDA = 2 THEN '17' ELSE '' END) 
 
 

