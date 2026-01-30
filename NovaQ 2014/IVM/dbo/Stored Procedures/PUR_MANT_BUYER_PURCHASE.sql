--Creado  05/06/2007
--Mantenimiento de partidas arancelarias
CREATE   procedure [dbo].[PUR_MANT_BUYER_PURCHASE]
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
    Set @STRquery='INSERT INTO BUYER_PURCHASE (ID, NAME )    
                  VALUES (@codigo,@nombre)'  
  if @OPCION='2'  --Modificar  
     Set @STRquery='UPDATE BUYER_PURCHASE SET NAME=@nombre  WHERE ID=@codigo'  

  if @OPCION='3'  --Eliminar
     Set @STRquery='DELETE FROM BUYER_PURCHASE WHERE ID=@codigo'  
  
Begin Tran Mant_BUYER_PURCHASE
   Set @Errores=0     --Para insertar
          exec sp_executesql @STRquery,N'@codigo varchar(2), @nombre varchar(40),@opcion char(1) ',   
                  @codigo, @nombre,@opcion     
          set @Errores = @@Error  
 
if @errores<>0 
   BEGIN  
         ROLLBACK TRAN Mant_BUYER_PURCHASE
    END   
else  
   BEGIN  
         COMMIT TRAN Mant_BUYER_PURCHASE
   END