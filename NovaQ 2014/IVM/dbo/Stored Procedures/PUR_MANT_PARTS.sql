
CREATE  procedure [dbo].[PUR_MANT_PARTS]  
--declare   
@codigo varchar(20), @codigofab varchar(20),@descripcion varchar(64), @descripcionalt varchar(64),@unidad varchar(6),  
@unidadref varchar(64),@familia varchar(8),@linea varchar(8),@grupo varchar(11),@peso numeric(15,6),  
@tipoarticulo varchar(2),@usuario varchar(8),@estado varchar(1),@fechacreacion varchar(10),@serie varchar(1),@lote varchar(1),@moneda varchar(2),  
@igvpor numeric(15,6),@flagigv bit,@clase varchar(20),@color varchar(20),@talla varchar(10),@foto varchar(255),@ficha varchar(2000),  
@stock varchar(1),@partidarancelaria varchar(14),@fechabaja varchar(10),@opcion varchar(1),@Errores int   
/* 
set @codigo='PROD001'  
set @codigofab='CODFABRICANTE'  
set @descripcion='DESCRIPCION DEL ARTICULO'  
set @descripcionALT='DESCRIPCION ALTERNA'  
set @UNIDAD='KG'  
set @UNIDADREF='LT'  
SET @familia='01'   
SET @linea ='01'  
SET @grupo ='01'  
SET @peso =1000  
SET @tipoarticulo ='1'  
SET @usuario ='1'  
SET @estado ='V'  
SET @fechacreacion ='27/04/2007'  
SET @serie ='N'  
SET @lote ='N'  
SET @moneda ='MN'  
SET @igvpor=0   
SET @flagigv =0  
SET @clase ='02'  
SET @color ='02'  
SET @talla ='TALLA'  
SET @foto ='D:\FUENTES_ERIKA\PersonalizadoVtas(BestBrands)\Imagenes\95.ICO'  
SET @ficha ='Text1'  
SET @stock ='S'  
SET @partidarancelaria =''  
SET @fechabaja =''  
SET @opcion ='3'  
*/
as  
declare @STRquery nvarchar(4000)
declare @STRquery1 nvarchar(1000)
DECLARE @ERROR1 integer
  if @OPCION='1' --Insertar  
    Set @STRquery='INSERT INTO PART (ID,ID_FAB,DESCRIPTION,DESCRIPTION_OPT,UNIT_OF_MEASUREMENT,REFERENCE,FAMILY,  
                  MODEL,GROUP_ID,WEIGHT,TYPE_PART,CREATE_USER,STATUS,CREATE_DATE,SERIES,IS_LOT,CURRENCY_ID,  
                  VAT_POR,IS_VAT,MARK,COLOR,HEIGHT,PICTURE,COMMENT,IS_STOCKED,CUSTOMS_TARIFF_ID,DATE_CADUCATE )    
                  VALUES (@CODIGO,@CODIGOFAB,@DESCRIPCION,@DESCRIPCIONALT,@UNIDAD,@UNIDADREF,@FAMILIA,@LINEA,@GRUPO,@PESO,@TIPOARTICULO,  
                  @USUARIO,@ESTADO,@FECHACREACION,@SERIE,@LOTE,@MONEDA,@IGVPOR,@FLAGIGV,@CLASE,@COLOR,@TALLA,@FOTO,  
                  @FICHA,@STOCK,@PARTIDARANCELARIA,@FECHABAJA)'  

  if @OPCION='2'  --Modificar  
     Set @STRquery='UPDATE PART SET ID_FAB=@CODIGOFAB,DESCRIPTION=@DESCRIPCION,DESCRIPTION_OPT=@DESCRIPCIONALT,
                   UNIT_OF_MEASUREMENT=@UNIDAD,REFERENCE=@UNIDADREF,FAMILY=@FAMILIA,MODEL=@LINEA,GROUP_ID=@GRUPO,
                   WEIGHT=@PESO,TYPE_PART=@TIPOARTICULO,STATUS=@ESTADO,HOUR_UPDATE=@FECHACREACION,SERIES=@SERIE,
                   IS_LOT=@LOTE,CURRENCY_ID=@MONEDA,VAT_POR=@IGVPOR,IS_VAT=@FLAGIGV,MARK=@CLASE,COLOR=@COLOR,
                   HEIGHT=@TALLA,PICTURE=@FOTO,COMMENT=@FICHA,IS_STOCKED=@STOCK,CUSTOMS_TARIFF_ID=@PARTIDARANCELARIA,
                   DATE_CADUCATE=@FECHABAJA WHERE ID=@CODIGO'  

  if @OPCION='3'  --Eliminar
     Set @STRquery='DELETE FROM PART WHERE ID=@CODIGO'  
     Set @STRquery1='Delete from PART_QTY where PART_ID=@CODIGO'

  
Begin Tran Mant_Articulo  
   SET @Errores=0  

   exec sp_executesql @STRquery,N'@codigo varchar(20),@codigofab varchar(20),@descripcion varchar(64),@descripcionalt varchar(64),  
        @unidad varchar(6),@unidadref varchar(6),@tipoarticulo varchar(2),@familia varchar(8),@linea varchar(8),  
        @grupo varchar(11),@peso numeric(15,6),@talla varchar(10),@color varchar(20),@clase varchar(20),  
        @partidarancelaria varchar(14),@estado varchar(1),@usuario varchar(8),@fechacreacion varchar(10),  
        @serie varchar(1),@lote varchar(1),@moneda varchar(2),@igvpor numeric(15,6),@flagigv bit,@foto varchar(255),@ficha varchar(2000),  
        @stock varchar(1),@fechabaja varchar(10),@OPCION varchar(1)',   
        @codigo,@codigofab,@descripcion,@descripcionalt,@unidad,@unidadref,@tipoarticulo,@familia,@linea,  
        @grupo,@peso,@talla,@color,@clase, @partidarancelaria,@estado,@usuario,@fechacreacion,@serie,@lote,  
        @moneda,@igvpor,@flagigv,@foto,@ficha,@stock,@fechabaja,@OPCION    
        set @Errores = @@Error  

  SET @ERROR1=0  
   exec sp_executesql @STRquery1,N'@codigo varchar(20)', @codigo 
   set @ERROR1 = @@Error  

  
if @errores<>0  
--AND @ERROR1<>0
  BEGIN  
   ROLLBACK TRAN Mant_Articulo  
  END   
else  
  BEGIN  
   COMMIT TRAN Mant_Articulo  
  END

