--Creado  05/06/2007
--Mantenimiento de Area
CREATE   procedure [dbo].[PUR_MANT_AREA]
--declare   
@codigo varchar(6), @nombre varchar(80),@opcion char(1)
/* 
SET @codigo='02'  
SET @nombre=''  
SET @OPCION='3'
*/
as  
declare @STRquery nvarchar(4000)
declare @Errores int

  if @OPCION='1' --Insertar  
    Set @STRquery='INSERT INTO AREA (ID, DESCRIPTION)    
                  VALUES (@codigo,@nombre)'  
  if @OPCION='2'  --Modificar  
     Set @STRquery='UPDATE AREA SET DESCRIPTION=@nombre  WHERE ID=@codigo'  

  if @OPCION='3'  --Eliminar
     Set @STRquery='DELETE FROM AREA WHERE ID=@codigo'  
  
Begin Tran Mant_Area
   Set @Errores=0     --Para insertar
          exec sp_executesql @STRquery,N'@codigo varchar(6), @nombre varchar(80),@opcion char(1) ',   
                  @codigo, @nombre,@opcion     
          set @Errores = @@Error  
 
if @errores<>0 
   BEGIN  
         ROLLBACK TRAN Mant_Area
    END   
else  
   BEGIN  
         COMMIT TRAN Mant_Area
   END