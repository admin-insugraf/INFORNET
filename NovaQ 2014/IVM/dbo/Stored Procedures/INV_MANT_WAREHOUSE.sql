  
--Creado por EVG - 09/05/2007      
--Mantenimiento de Almacenes      
CREATE procedure [dbo].[INV_MANT_WAREHOUSE]      
--declare         
@codigo varchar(2), @nombre varchar(25),@direccion varchar(40),@distrito varchar(8),        
@tipoarticulo varchar(2),@telefono varchar(10), @ultcorrelativoNI numeric,    
@ultcorrelativoNS numeric, @estado char(1),      
@opcion char(1),@defecto char(1)      
/*       
SET @codigo='09'        
SET @nombre='Almacen nuevo'    
SET @direccion='acccccc'    
SET @distrito='001'    
SET @tipoarticulo='1'    
SET @telefono='2121-4454'    
SET @ultcorrelativoNI=121545454    
SET @ultcorrelativoNS=121545454    
SET @estado ='V'        
SET @opcion ='1'  
SET @DEFECTO='1'        
 */     
as        
declare @STRquery nvarchar(4000)      
declare @STRquery1 nvarchar(1000)      
declare @Errores int      
declare  @Error1 integer      
      
  if @OPCION='1' --Insertar        
    Set @STRquery='INSERT INTO WAREHOUSE (ID,NAME,ADDR_WHO,STATE_ID,TYPE_PART,PHONE,LAST_NUM_IN,LAST_NUM_OUT,STATUS,IS_DEFAULT)          
                  VALUES (@CODIGO,@NOMBRE,@DIRECCION,@DISTRITO,@TIPOARTICULO,@TELEFONO,@ULTCORRELATIVONI,@ULTCORRELATIVONS,@ESTADO,@DEFECTO)'        
  if @OPCION='2'  --Modificar        
     Set @STRquery='UPDATE WAREHOUSE SET NAME=@NOMBRE,ADDR_WHO=@DIRECCION,STATE_ID=@DISTRITO,TYPE_PART=@TIPOARTICULO,      
                     PHONE=@TELEFONO, LAST_NUM_IN=@ULTCORRELATIVONI, LAST_NUM_OUT=@ULTCORRELATIVONS,STATUS=@ESTADO,IS_DEFAULT=@DEFECTO      
                     WHERE ID=@CODIGO'        
      
  if @OPCION='3'  --Eliminar      
     Set @STRquery='DELETE FROM WAREHOUSE WHERE ID=@CODIGO'        
        
Begin Tran Mant_Warehouse      
   Set @Errores=0     --Para insertar      
          exec sp_executesql @STRquery,N'@codigo varchar(11), @nombre varchar(100),@direccion varchar(100),@distrito varchar(8),        
     @tipoarticulo varchar(3),@telefono varchar(30), @ultcorrelativoNI numeric,@ultcorrelativoNS numeric, @estado char(1),      
        @opcion char(1),@defecto char(1) ',         
     @codigo, @nombre,@direccion,@distrito,@tipoarticulo,@telefono,@ultcorrelativoNI,@ultcorrelativoNS,@estado,@opcion,@defecto       
        set @Errores = @@Error        
      
   Set @ERROR1=0   -- Para eliminar      
           exec sp_executesql @STRquery1,N'@codigo varchar(11)', @codigo       
           set @ERROR1 = @@Error        
       
if @errores<>0  or @error1<>0      
   BEGIN        
         ROLLBACK TRAN Mant_Warehouse      
    END         
else        
   BEGIN        
         COMMIT TRAN Mant_Warehouse      
   END    