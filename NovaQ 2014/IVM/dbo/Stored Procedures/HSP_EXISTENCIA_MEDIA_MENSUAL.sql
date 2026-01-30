CREATE procedure [dbo].[HSP_EXISTENCIA_MEDIA_MENSUAL]  
 --declare  
 @EMP varchar(3),  
 @COD_DMAY varchar(10),  
 @FEC_INICIO varchar(10),  
 @FEC_FINAL varchar(10),  
 @PC varchar(80)  
  
/*set @EMP='002'  
set @COD_DMAY='58137'  
set @FEC_INICIO='01/10/2007'  
set @FEC_FINAL='31/10/2007'  
set @PC='developer03'  
--*/as  
  
 declare @inicio int  
 declare @fin int  
 declare @mes varchar(2)  
 declare @anyo varchar(4)  
 declare @fecha_find varchar(10)  
   
 set @mes=right(replicate('0',2) + cast(month(@fec_inicio) as varchar(2)),2)  
 set @anyo=cast(year(@fec_inicio) as varchar(4))   
  
 set @inicio=cast(left(@fec_inicio,2) as int)  
 set @fin=cast(left(@fec_final,2) as int)   
  
 if exists(select * from tempdb.dbo.sysobjects WHERE NAME='STOCK_DIARIO_MEDIA'+@PC)  
  EXEC('drop table [tempdb].dbo.STOCK_DIARIO_MEDIA'+@PC+'')  
  
  exec('create table [tempdb].dbo.STOCK_DIARIO_MEDIA'+@PC+'  
    (COD_OPER varchar(10),  
    COD_MAYOR int,  
    COD_OSINERG varchar(10),  
    FECHA varchar(10),  
    COD_PRODUCTO varchar(20),  
    DES_PRODUCTO varchar(64),  
    COD_ALMACEN varchar(2),  
    CANT_INGRESO numeric(15,6),  
    CANT_SALIDA numeric(15,6),  
    SALDO numeric(15,6),  
    VOLUMEN_FONDOS varchar(1),  
    FACTOR numeric(15,6)  
    )')  
  
 WHILE @inicio<=@fin  
  BEGIN  
   set @fecha_find=right(replicate('0',2) + cast(@inicio as varchar (2)),2) + '/' + @mes + '/' + @anyo  
   --Calculo el stock diario del producto  
   set quoted_identifier off  
   exec('insert into [tempdb].dbo.STOCK_DIARIO_MEDIA'+@PC+' (COD_OPER,COD_MAYOR,COD_OSINERG,FECHA,COD_PRODUCTO,DES_PRODUCTO,COD_ALMACEN,CANT_INGRESO,CANT_SALIDA,  
       SALDO,VOLUMEN_FONDOS,FACTOR)  
    select AO.COD_OPER,'+@COD_DMAY+' as COD_MAYOR,PO.COD_OSINERG,'''+@fecha_find+''' as FECHA,B.PART_ID,C.DESCRIPTION,B.WAREHOUSE_ID,  
    sum(case when A.TYPE_TRANS=''I'' then B.QTY else 0 END)AS INGRESO,      
    sum(case when A.TYPE_TRANS=''S'' then B.QTY else 0 END)as SALIDA,      
    (sum(case when A.TYPE_TRANS=''I'' then B.QTY else 0 END)-sum(CASE WHEN A.TYPE_TRANS=''S'' THEN B.QTY else 0 END)) / PO.FACTOR AS SALDOMOV,  
    0 as VOLUMEN_FONDOS,PO.FACTOR  
    from WAREHOUSE_TRANS A   
    inner join WAREHOUSE_TRANS_LINE B ON A.WAREHOUSE_ID=B.WAREHOUSE_ID AND A.DOCUMENT_ID=B.DOCUMENT_ID AND A.NUMBER_DOCUMENT=B.NUMBER_DOCUMENT   
    inner join PART C ON B.PART_ID=C.ID  
    inner join PRODUCTOS_OSINERG PO on B.PART_ID=PO.COD_PRODUCTO  
    inner join ALMACEN_OSINERG AO on AO.COD_DMAY='+@COD_DMAY+' and AO.COD_ALMACEN=A.WAREHOUSE_ID AND AO.TIPO_ALMACEN=''C''   
    where A.STATUS_GUIA<>''A'' and not (A.DOCUMENT_ID=''GS'' and A.TRANS_ID=''GF'' and A.STATUS_GUIA=''F'')       
    and not (C.IS_STOCKED=''N'' and C.SERIES=''N'' and C.IS_LOT=''N'') and (B.PART_ID<>''TEXTO'')      
    and A.DATE_DOCUMENT<'''+@fecha_find+'''    
    group by AO.COD_OPER,PO.COD_OSINERG,B.PART_ID,C.DESCRIPTION,B.WAREHOUSE_ID,PO.FACTOR order by B.PART_ID asc')  
  
   exec('insert into [tempdb].dbo.STOCK_DIARIO_MEDIA'+@PC+' (COD_OPER,COD_MAYOR,COD_OSINERG,FECHA,COD_PRODUCTO,DES_PRODUCTO,COD_ALMACEN,CANT_INGRESO,CANT_SALIDA,  
       SALDO,VOLUMEN_FONDOS,FACTOR)  
    select AO.COD_OPER,'+@COD_DMAY+' as COD_MAYOR,PO.COD_OSINERG,'''+@fecha_find+''' as FECHA,B.PART_ID,C.DESCRIPTION,B.WAREHOUSE_ID,  
    sum(case when A.TYPE_TRANS=''I'' then B.QTY else 0 END)AS INGRESO,      
    sum(case when A.TYPE_TRANS=''S'' then B.QTY else 0 END)as SALIDA,      
    (sum(case when A.TYPE_TRANS=''I'' then B.QTY else 0 END)-sum(CASE WHEN A.TYPE_TRANS=''S'' THEN B.QTY else 0 END)) / PO.FACTOR AS SALDOMOV,  
    0 as VOLUMEN_FONDOS,PO.FACTOR  
    from WAREHOUSE_TRANS A   
    inner join WAREHOUSE_TRANS_LINE B ON A.WAREHOUSE_ID=B.WAREHOUSE_ID AND A.DOCUMENT_ID=B.DOCUMENT_ID AND A.NUMBER_DOCUMENT=B.NUMBER_DOCUMENT   
    inner join PART C ON B.PART_ID=C.ID 
    inner join PRODUCTOS_OSINERG PO on B.PART_ID=PO.COD_PRODUCTO  
    inner join ALMACEN_OSINERG AO on AO.COD_DMAY='+@COD_DMAY+' and AO.COD_ALMACEN=A.WAREHOUSE_ID AND AO.TIPO_ALMACEN=''F''   
    where A.STATUS_GUIA<>''A'' and not (A.DOCUMENT_ID=''GS'' and A.TRANS_ID=''GF'' and A.STATUS_GUIA=''F'')       
    and not (C.IS_STOCKED=''N'' and C.SERIES=''N'' and C.IS_LOT=''N'') and (B.PART_ID<>''TEXTO'')      
    and A.DATE_DOCUMENT<'''+@fecha_find+'''    
    group by AO.COD_OPER,PO.COD_OSINERG,B.PART_ID,C.DESCRIPTION,B.WAREHOUSE_ID,PO.FACTOR order by B.PART_ID asc')  
  
   set @inicio=@inicio + 1  
  END  /*LISTO!!! */
  