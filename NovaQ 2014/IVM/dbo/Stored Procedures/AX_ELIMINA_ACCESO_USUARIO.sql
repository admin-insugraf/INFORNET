CREATE PROCEDURE [dbo].[AX_ELIMINA_ACCESO_USUARIO]   
 (@codigo varchar(15))  
AS  
     delete from usuarios_opcion
    where cod_usuario=@codigo