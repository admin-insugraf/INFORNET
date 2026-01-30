--Creado 10/05/2007  
--Mantenimiento de Tipo de transaccion
CREATE procedure [dbo].[INV_MANT_TRANSACTION_TYPE]
--declare     
@tipomov char(1),@codigo varchar(2),@descripcion varchar(40),@valorizado char(1), @proveedor char(1),@docref char(1),
@personalautorizado char(1), @centrocostos char(1),@ordencompra char(1), @comentario char(1),@almacen char(1),
@cliente char(1),@ordenfabricacion char(1),@asientoconsumo bit,@cuentacontable char(1), @contador as integer,@opcion char(1)
/*
set @codigo = '00100' 
set @nombre='ssssssss'
set @telefono =''
set @direccion =''
set @ruc=''
set @estado =''
set @fechacreacion =''
set @Nombreemp=''
set @rucemp =''
set @direccionemp =''
set @telefonoemp =''
set @placa =''
set @brevete =''
set @modelo =''
set @nroinscripcion =''
set @dni =''
set @opcion='1'
*/
as    
declare @STRquery nvarchar(4000)  
declare @STRquery1 nvarchar(1000)  
declare @Errores int  
declare  @Error1 integer  
  
  if @OPCION='1' --Insertar    
    Set @STRquery='INSERT INTO TRANSACTION_TYPE (TYPE_ID,MOV_ID,NAME,IS_VALUED,IS_VENDOR,IS_DOC_REF,IS_AUTHORIZED,
   		     IS_CCOST,IS_ORDER_PURCHASE,IS_COMMENT,IS_WHO,IS_CUSTOMER, IS_ORDER_MANUFACT,IS_POST,IS_ACCOUNT,VAR_COUNT)      
                                VALUES (@tipomov,@codigo,@descripcion,@valorizado, @proveedor,@docref,@personalautorizado, @centrocostos,@ordencompra,
                               @comentario,@almacen,@cliente,@ordenfabricacion,@asientoconsumo,@cuentacontable,@contador)'    
  if @OPCION='2'  --Modificar    
     Set @STRquery='UPDATE TRANSACTION_TYPE SET NAME=@descripcion,IS_VALUED=@valorizado,IS_VENDOR=@proveedor,IS_DOC_REF=@docref,
                                IS_AUTHORIZED=@personalautorizado, IS_CCOST=@centrocostos,IS_ORDER_PURCHASE=@ordencompra,IS_COMMENT=@comentario,
                                IS_WHO=@almacen,IS_CUSTOMER=@cliente, IS_ORDER_MANUFACT=@ordenfabricacion,IS_POST=@asientoconsumo,
                                IS_ACCOUNT=@cuentacontable, VAR_COUNT=@contador  WHERE TYPE_ID=@tipomov AND MOV_ID=@codigo'    
  
  if @OPCION='3'  --Eliminar  
     Set @STRquery='DELETE FROM TRANSACTION_TYPE WHERE TYPE_ID=@tipomov AND MOV_ID=@codigo'    
    
Begin Tran Mant_Transaction_Type
   Set @Errores=0     --Para insertar  
         exec sp_executesql @STRquery,N'@tipomov char(1),@codigo varchar(2),@descripcion varchar(40),@valorizado char(1), @proveedor char(1),@docref char(1),
	@personalautorizado char(1), @centrocostos char(1),@ordencompra char(1), @comentario char(1),@almacen char(1),
	@cliente char(1),@ordenfabricacion char(1),@asientoconsumo bit,@cuentacontable char(1),@contador integer,@opcion char(1)',     
	@tipomov,@codigo,@descripcion,@valorizado, @proveedor,@docref,@personalautorizado, @centrocostos,@ordencompra, @comentario,
             @almacen,@cliente,@ordenfabricacion,@asientoconsumo,@cuentacontable,@contador,@opcion
         set @Errores = @@Error    
  
   Set @ERROR1=0   -- Para eliminar  
           exec sp_executesql @STRquery1,N'@tipomov char(1),@codigo varchar(2)', @tipomov,@codigo   
           set @ERROR1 = @@Error    
   
if @errores<>0  or @error1<>0  
   BEGIN    
         ROLLBACK TRAN Mant_Transaction_Type
    END     
else    
   BEGIN    
         COMMIT TRAN Mant_Transaction_Type
   END