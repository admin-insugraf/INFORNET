--Creado  07/06/2007
--Mantenimiento de tipo de orden de importacion
CREATE   procedure [dbo].[PUR_MANT_PURCHASE_STATUS]
--declare   
@codigo varchar(2), @nombre varchar(40),@opcion char(1)
/* 
SET @codigo='02'  
SET @nombre=''  
SET @OPCION='3'
*/
as  
declare @STRquery nvarchar(4000)
declare @Errores int

  if @OPCION='1' --Insertar  
    Set @STRquery='INSERT INTO PURCHASE_STATUS (ID, DESCRIPTION)    
                  VALUES (@codigo,@nombre)'  
  if @OPCION='2'  --Modificar  
     Set @STRquery='UPDATE PURCHASE_STATUS SET DESCRIPTION=@nombre  WHERE ID=@codigo'  

  if @OPCION='3'  --Eliminar
     Set @STRquery='DELETE FROM PURCHASE_STATUS WHERE ID=@codigo'  
  
Begin Tran Mant_PURCHASE_STATUS
   Set @Errores=0     --Para insertar
          exec sp_executesql @STRquery,N'@codigo varchar(2), @nombre varchar(40),@opcion char(1) ',   
                  @codigo, @nombre,@opcion     
          set @Errores = @@Error  
 
if @errores<>0 
   BEGIN  
         ROLLBACK TRAN Mant_PURCHASE_STATUS
    END   
else  
   BEGIN  
         COMMIT TRAN Mant_PURCHASE_STATUS
   END