--Creado  07/06/2007
--Mantenimiento de banco
CREATE   procedure [dbo].[PUR_MANT_TB_BANK]
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
    Set @STRquery='INSERT INTO TB_BANK (BANK_ID, NAME )    
                  VALUES (@codigo,@nombre)'  
  if @OPCION='2'  --Modificar  
     Set @STRquery='UPDATE TB_BANK SET NAME=@nombre  WHERE BANK_ID=@codigo'  

  if @OPCION='3'  --Eliminar
     Set @STRquery='DELETE FROM TB_BANK WHERE BANK_ID=@codigo'  
  
Begin Tran Mant_Country
   Set @Errores=0     --Para insertar
          exec sp_executesql @STRquery,N'@codigo varchar(3), @nombre varchar(50),@opcion char(1) ',   
                  @codigo, @nombre,@opcion     
          set @Errores = @@Error  
 
if @errores<>0 
   BEGIN  
         ROLLBACK TRAN Mant_Bank
    END   
else  
   BEGIN  
         COMMIT TRAN Mant_Bank
   END