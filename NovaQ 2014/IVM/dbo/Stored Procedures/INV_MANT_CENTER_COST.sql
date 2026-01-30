create procedure [dbo].[INV_MANT_CENTER_COST]      
--declare         
@codigo varchar(2), @nombre varchar(100),@direccion varchar(10),@distrito varchar(100),        
@tipoarticulo varchar(2),@telefono varchar(10), @ultcorrelativoNI numeric,    
@ultcorrelativoNS numeric, @estado varchar(1),      
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
    Set @STRquery='INSERT INTO CENTER_COST (COST_CENTER_ID,COST_CENTER_DESCRIPTION,CREATE_DATE,IS_STATUS,USER_ID)          
                  VALUES (@CODIGO,@NOMBRE,@DIRECCION,@ESTADO,@distrito)'        
  if @OPCION='2'  --Modificar        
     Set @STRquery='UPDATE CENTER_COST SET COST_CENTER_DESCRIPTION=@NOMBRE,IS_STATUS=@ESTADO,LAST_MODIFY_DATE=@DIRECCION,USER_MODIFIED=@distrito       
                     WHERE COST_CENTER_ID=@CODIGO'        
      
  if @OPCION='3'  --Eliminar      
     Set @STRquery='DELETE FROM CENTER_COST WHERE COST_CENTER_ID=@CODIGO'        
        
Begin Tran Mant_Warehouse      
   Set @Errores=0     --Para insertar      
          exec sp_executesql @STRquery,N'@codigo varchar(2), @nombre varchar(100),@direccion varchar(10),@distrito varchar(100),        
     @tipoarticulo varchar(3),@telefono varchar(30), @ultcorrelativoNI numeric,@ultcorrelativoNS numeric, @estado varchar(1),      
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