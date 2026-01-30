CREATE PROC [dbo].[CO_SP_S_ANALISIS1]                  
@P_FECHA1 DATETIME='01/01/2013',--fecha inicio                  
@P_FECHA2 DATETIME='12/30/2013',  --fecha fin                
@P_CUENTA1 VARCHAR(50)='121201',  --nuemero de cuenta inicio                
@P_CUENTA2 VARCHAR(50)='121201',  --numero de cuenta fin                
@P_ANEXO1 varchar(15) = '20518053052',  --anexo inicio                
@P_ANEXO2 varchar(15) = '20518053052',  --anexo fin                
@P_PENDIENTES INT = 1,  --indicador flag si es pendiente                
@P_ANHO INT = 2013  --numero de año                
AS                  
                  
IF @P_PENDIENTES = 1 BEGIN                  
                  
if @P_ANEXO1 = '' begin                  
                  
  SELECT AD_CUENTA,AD_IDANEXO,'' as 'AN_DESCRIPCION',AD_TDOC,left(NAME,4) as 'DO_DESCRIPCION',AD_SDOC,AD_NDOC,AC_FEC_VOUCHER,AC_IDSUBDIARIO,AC_GLOSA_VOU,                  
  (CASE WHEN AD_IDMONEDA = 2 THEN AD_MONTO_ORI ELSE 0 END) as 'DOLARES', AD_DEBE,AD_HABER,0 AS 'SALDO',AC_NUM_VOUCHER ,'' as 'AN_NUM_DOC'                 
  FROM CO_TB_ASIENTO_CAB A                   
   INNER JOIN CO_TB_ASIENTO_DET B ON A.AC_ID = B.AD_IDCAB                  
   left join (SELECT TYPE_ID,NAME FROM   DOCUMENT_TYPE  ) c on b.AD_TDOC = c.TYPE_ID  
     
 WHERE A.AC_ANHO = @P_ANHO   
 AND a.AC_FEC_VOUCHER >= @P_FECHA1                  
 AND a.AC_FEC_VOUCHER <= @P_FECHA2                  
 AND b.AD_CUENTA >= @P_CUENTA1 AND  b.AD_CUENTA <= @P_CUENTA2                  
 AND AD_IDANEXO +isnull(AD_TDOC,'')+isnull(AD_SDOC,'')+isnull(AD_NDOC,'')  IN                   
                      
    (/**/                  
     SELECT AD_IDANEXO +isnull(AD_TDOC,'')+isnull(AD_SDOC,'')+isnull(AD_NDOC,'')                          
     FROM CO_TB_ASIENTO_DET A                             
     INNER JOIN CO_TB_ASIENTO_CAB B ON A.AD_IDCAB = B.AC_ID                            
     WHERE AC_ANHO = @P_ANHO                       
     AND A.AD_CUENTA >= @P_CUENTA1 AND  A.AD_CUENTA <= @P_CUENTA2                       
     GROUP BY AD_IDANEXO,isnull(AD_TDOC,''),AD_SDOC,AD_NDOC                            
     HAVING SUM(AD_DEBE)-SUM(AD_HABER) <> 0                                
    )                  
  ORDER BY AD_IDANEXO,isnull(AD_TDOC,''),AD_SDOC,AD_NDOC,AC_FEC_VOUCHER                  
                  
 end else begin --@P_ANEXO1                  
                  
                  
   SELECT AD_CUENTA,AD_IDANEXO,'' as 'AN_DESCRIPCION',AD_TDOC,left(NAME,4) as DO_DESCRIPCION,AD_SDOC,AD_NDOC,AC_FEC_VOUCHER,AC_IDSUBDIARIO,AC_GLOSA_VOU,                  
   (CASE WHEN AD_IDMONEDA = 2 THEN AD_MONTO_ORI ELSE 0 END)DOLARES, AD_DEBE,AD_HABER,0 AS SALDO,AC_NUM_VOUCHER ,'' as 'AN_NUM_DOC'  
   FROM CO_TB_ASIENTO_CAB A                   
   INNER JOIN CO_TB_ASIENTO_DET B ON A.AC_ID = B.AD_IDCAB                  
   left join (SELECT TYPE_ID,NAME FROM   DOCUMENT_TYPE) c on b.AD_TDOC = c.TYPE_ID                  
   --inner join sg_co_tb_anexo d on b.AD_IDANEXO = d.AN_IDANEXO                  
   WHERE A.AC_ANHO = @P_ANHO   
   AND a.AC_FEC_VOUCHER >= @P_FECHA1                  
   AND a.AC_FEC_VOUCHER <= @P_FECHA2                  
   AND b.AD_CUENTA >= @P_CUENTA1 AND  b.AD_CUENTA <= @P_CUENTA2                  
   AND AD_IDANEXO +isnull(AD_TDOC,'')+isnull(AD_SDOC,'')+isnull(AD_NDOC,'')  IN                   
   (                  
   SELECT  AD_IDANEXO +isnull(AD_TDOC,'')+isnull(AD_SDOC,'')+isnull(AD_NDOC,'')                          
   FROM CO_TB_ASIENTO_DET A                        
   INNER JOIN CO_TB_ASIENTO_CAB B ON A.AD_IDCAB = B.AC_ID                            
   WHERE AC_ANHO = @P_ANHO      
   AND AD_IDANEXO BETWEEN @P_ANEXO1 AND @P_ANEXO2                  
   AND A.AD_CUENTA >= @P_CUENTA1 AND  A.AD_CUENTA <= @P_CUENTA2                  
   GROUP BY AD_IDANEXO,isnull(AD_TDOC,''),AD_SDOC,AD_NDOC                          
   HAVING SUM(AD_DEBE)-SUM(AD_HABER) <> 0                                
   )                  
   ORDER BY AD_IDANEXO,isnull(AD_TDOC,''),AD_SDOC,AD_NDOC,AC_FEC_VOUCHER                  
                  
                  
 end                   
END ELSE BEGIN --@P_PENDIENTES                  
                  
 if @P_ANEXO1 = '' begin                  
                  
                  
   SELECT AD_CUENTA,AD_IDANEXO,'' as 'AN_DESCRIPCION',AD_TDOC,left(NAME,4)as DO_DESCRIPCION,AD_SDOC,AD_NDOC,AC_FEC_VOUCHER,AC_IDSUBDIARIO,AC_GLOSA_VOU,                  
   (CASE WHEN AD_IDMONEDA = 2 THEN AD_MONTO_ORI ELSE 0 END)DOLARES, AD_DEBE,AD_HABER,0 AS SALDO,AC_NUM_VOUCHER        ,'' as 'AN_NUM_DOC'          
   FROM CO_TB_ASIENTO_CAB A INNER JOIN CO_TB_ASIENTO_DET B ON A.AC_ID = B.AD_IDCAB                  
   left join (SELECT TYPE_ID,NAME FROM   DOCUMENT_TYPE) c on b.AD_TDOC = c.TYPE_ID  
   --inner join sg_co_tb_anexo d on b.AD_IDANEXO = d.AN_IDANEXO                  
   WHERE A.AC_ANHO = @P_ANHO   
 AND B.AD_CUENTA >= @P_CUENTA1 AND  B.AD_CUENTA <= @P_CUENTA2                     
   AND AD_IDANEXO+isnull(AD_TDOC,'')+isnull(AD_SDOC,'')+isnull(AD_NDOC,'')  IN                   
   (                  
    SELECT AD_IDANEXO +isnull(AD_TDOC,'')+isnull(AD_SDOC,'')+isnull(AD_NDOC,'')                             
    FROM CO_TB_ASIENTO_DET A                             
    INNER JOIN CO_TB_ASIENTO_CAB B ON A.AD_IDCAB = B.AC_ID                            
    WHERE AC_ANHO = @P_ANHO         
    AND A.AD_CUENTA >= @P_CUENTA1 AND  A.AD_CUENTA <= @P_CUENTA2                  
    AND B.AC_FEC_VOUCHER >= @P_FECHA1                  
    AND B.AC_FEC_VOUCHER <= @P_FECHA2                  
    GROUP BY AD_IDANEXO,isnull(AD_TDOC,''),AD_SDOC,AD_NDOC                            
      
   )                  
   ORDER BY AD_IDANEXO,isnull(AD_TDOC,''),AD_SDOC,AD_NDOC,AC_FEC_VOUCHER                  
                  
                  
 end else begin                  
                  
                  
   SELECT AD_CUENTA,AD_IDANEXO,'' as 'AN_DESCRIPCION',AD_TDOC,left(NAME,4)as DO_DESCRIPCION,AD_SDOC,AD_NDOC,AC_FEC_VOUCHER,AC_IDSUBDIARIO,AC_GLOSA_VOU,                  
   (CASE WHEN AD_IDMONEDA = 2 THEN AD_MONTO_ORI ELSE 0 END)DOLARES, AD_DEBE,AD_HABER,0 AS SALDO,AC_NUM_VOUCHER       ,'' as 'AN_NUM_DOC'           
   FROM CO_TB_ASIENTO_CAB A INNER JOIN CO_TB_ASIENTO_DET B ON A.AC_ID = B.AD_IDCAB                  
   left join (SELECT TYPE_ID,NAME FROM DOCUMENT_TYPE) c on b.AD_TDOC = c.TYPE_ID  
   --inner join sg_co_tb_anexo d on b.AD_IDANEXO = d.AN_IDANEXO                  
   WHERE A.AC_ANHO = @P_ANHO   
 AND b.AD_CUENTA >= @P_CUENTA1 AND  b.AD_CUENTA <= @P_CUENTA2                  
     
   AND AD_IDANEXO +isnull(AD_TDOC,'')+isnull(AD_SDOC,'')+isnull(AD_NDOC,'')  IN                   
   (                  
    SELECT AD_IDANEXO +isnull(AD_TDOC,'')+isnull(AD_SDOC,'')+isnull(AD_NDOC,'')                 
    FROM CO_TB_ASIENTO_DET A                             
    INNER JOIN CO_TB_ASIENTO_CAB B ON A.AD_IDCAB = B.AC_ID                            
    WHERE AD_IDANEXO BETWEEN @P_ANEXO1 AND @P_ANEXO2                  
    AND A.AD_CUENTA >= @P_CUENTA1 AND  A.AD_CUENTA <= @P_CUENTA2                  
    and AC_ANHO = @P_ANHO      
    AND B.AC_FEC_VOUCHER >= @P_FECHA1                  
    AND B.AC_FEC_VOUCHER <= @P_FECHA2                  
    GROUP BY AD_IDANEXO,isnull(AD_TDOC,''),AD_SDOC,AD_NDOC                            
    --HAVING SUM(AD_DEBE)-SUM(AD_HABER) <> 0                                
   )                  
    ORDER BY AD_IDANEXO,isnull(AD_TDOC,''),AD_SDOC,AD_NDOC,AC_FEC_VOUCHER                  
                  
 end                  
END   
  