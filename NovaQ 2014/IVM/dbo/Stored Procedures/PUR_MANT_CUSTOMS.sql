--Creado  07/06/2007
--Mantenimiento de agencia de aduana
CREATE   procedure [dbo].[PUR_MANT_CUSTOMS]
--declare   
@codigo varchar(3), @nombre varchar(50),@opcion char(1)
/* 
SET @codigo='02'  
SET @nombre=''  
SET @OPCION='3'
*/
as  
declare @STRquery nvarchar(4000)
declare @Errores int

  if @OPCION='1' --Insertar  
    Set @STRquery='INSERT INTO CUSTOMS (CUSTOMS_ID, NAME )    
                  VALUES (@codigo,@nombre)'  
  if @OPCION='2'  --Modificar  
     Set @STRquery='UPDATE CUSTOMS SET NAME=@nombre  WHERE CUSTOMS_ID=@codigo'  

  if @OPCION='3'  --Eliminar
     Set @STRquery='DELETE FROM CUSTOMS WHERE CUSTOMS_ID=@codigo'  
  
Begin Tran Mant_Customs
   Set @Errores=0     --Para insertar
          exec sp_executesql @STRquery,N'@codigo varchar(3), @nombre varchar(50),@opcion char(1) ',   
                  @codigo, @nombre,@opcion     
          set @Errores = @@Error  
 
if @errores<>0 
   BEGIN  
         ROLLBACK TRAN Mant_Customs
    END   
else  
   BEGIN  
         COMMIT TRAN Mant_Customs
   END