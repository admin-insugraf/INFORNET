CREATE PROCEDURE [dbo].[ADM_DATOS_USUARIO]   
     (@codigo varchar(15))  
AS  
select u.codusuario,u.nomusuario,
       u.passusuario,u.fecha_inicio,u.fecha_fin,
       u.estado,u.nivel_acceso
from usuarios u
where codusuario=@codigo