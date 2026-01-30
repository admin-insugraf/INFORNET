


CREATE PROC [dbo].[CO_SP_I_SALDO_CUENTA1]                
@P_ANHO INT = 2013,					--numero de año              
@P_MES INT = 3,						--numero de mes              
@P_IDCUENTA varchar(20) = '104125',   --codigo id de cuenta              
@P_PC VARCHAR(100) = 'OMS',			--nombre de la pc              
@P_MONEDA INT = 1          
AS                
          
  IF @P_MES  = 1               
  BEGIN              
                 
    DECLARE @PSUBDIARIO_APE VARCHAR(2)              
    set @PSUBDIARIO_APE =(SELECT SD_ID FROM CO_TB_SUBDIARIO SCTS WHERE  SD_ES_APER = 1 AND SD_ISTATUS = 1)              
                   
   INSERT INTO CO_TB_TMP_SALDO_CUENTA(SC_IDCUENTA,SC_SALDO_D,SC_SALDO_H,SC_PC)                
   SELECT   @P_IDCUENTA,          
          
          
ISNULL(SUM(        
(case when AD_DEBE > 0 then           
(case when @P_MONEDA = 1 then          
AD_DEBE           
else           
--(case when AD_TCAM = 0 then AD_DEBE / TC_VENTA else AD_MONTO_ORI end)          
AD_MONTO_ORI   
end) else 0 end)),0),          
          
ISNULL(SUM(        
(case when AD_haber > 0 then           
(case when @P_MONEDA = 1 then          
AD_HABER           
else           
--(case when AD_TCAM = 0 then AD_HABER / TC_VENTA else AD_MONTO_ORI end)          
AD_MONTO_ORI   
end) else 0 end)),0),@P_PC                    

	FROM CO_TB_ASIENTO_CAB a      
	INNER JOIN CO_TB_ASIENTO_DET b ON  a.AC_ID  = b.AD_IDCAB      
	INNER JOIN (select * from CO_TB_PLANCTAS where pc_periodo = @P_ANHO) AS p             
	ON b.AD_CUENTA = p.PC_NUM_CTA           
	WHERE AC_ANHO = @P_ANHO AND AC_MES = @P_MES 
	AND AD_CUENTA = @P_IDCUENTA AND AC_IDSUBDIARIO = @PSUBDIARIO_APE  AND AC_ESTADO = 1      
          
              
 END               
 ELSE               
 BEGIN              
            
   INSERT INTO CO_TB_TMP_SALDO_CUENTA(SC_IDCUENTA,SC_SALDO_D,SC_SALDO_H,SC_PC)                
   SELECT   @P_IDCUENTA,          
          
ISNULL(SUM(        
(case when AD_DEBE > 0 then           
(case when @P_MONEDA = 1 then          
AD_DEBE           
else           
 AD_MONTO_ORI   
end) else 0 end)),0),          
          
ISNULL(SUM(        
(case when AD_haber > 0 then           
(case when @P_MONEDA = 1 then AD_HABER else AD_MONTO_ORI end)   
else 0 end)),0),           
          
@P_PC
   FROM CO_TB_ASIENTO_CAB SCTAC                 
   INNER JOIN CO_TB_ASIENTO_DET SCTAD ON SCTAD.AD_IDCAB = SCTAC.AC_ID                
   INNER JOIN (select * from CO_TB_PLANCTAS where pc_periodo = @P_ANHO ) AS A             
      ON SCTAD.AD_CUENTA = A.PC_NUM_CTA                
--LEFT JOIN  (select * from SG_CO_TB_TIPOCAMBIO where TC_IDEMPRESA = @P_IDEMPRESA ) tc on SCTAC.AC_FEC_VOUCHER = tc.TC_FECHA          
   WHERE SCTAC.AC_ANHO = @P_ANHO AND SCTAC.AC_MES < @P_MES 
   AND SCTAD.AD_CUENTA = @P_IDCUENTA        and ac_estado = 1      
         
         
         
  END             

