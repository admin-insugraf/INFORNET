--Creado  07/06/2007
--Mantenimiento de estado de documento
CREATE   procedure [dbo].[PUR_MANT_DOCUMENT_STATUS]
--declare   
@codigo varchar(1), @nombre varchar(40),@obligatorio bit, @opcion char(1)
/* 
SET @codigo='02'  
SET @nombre=''  
SET @OPCION='3'
*/
as  
declare @STRquery nvarchar(4000)
declare @Errores int

  if @OPCION='1' --Insertar  
    Set @STRquery='INSERT INTO DOCUMENT_STATUS (ID, DESCRIPTION,DOCUM_OBLIG)    
                  VALUES (@codigo,@nombre,@obligatorio)'  
  if @OPCION='2'  --Modificar  
     Set @STRquery='UPDATE DOCUMENT_STATUS SET DESCRIPTION=@nombre, DOCUM_OBLIG=@obligatorio  WHERE ID=@codigo'  

  if @OPCION='3'  --Eliminar
     Set @STRquery='DELETE FROM DOCUMENT_STATUS WHERE ID=@codigo'  
  
Begin Tran Mant_DOCUMENT_STATUS
   Set @Errores=0     --Para insertar
          exec sp_executesql @STRquery,N'@codigo varchar(1), @nombre varchar(40),@obligatorio bit,@opcion char(1) ',   
                  @codigo, @nombre,@obligatorio,@opcion     
          set @Errores = @@Error  
 
if @errores<>0 
   BEGIN  
         ROLLBACK TRAN Mant_DOCUMENT_STATUS
    END   
else  
   BEGIN  
         COMMIT TRAN Mant_DOCUMENT_STATUS
   END