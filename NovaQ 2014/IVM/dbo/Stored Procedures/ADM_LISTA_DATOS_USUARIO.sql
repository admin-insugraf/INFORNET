create procedure [dbo].[ADM_LISTA_DATOS_USUARIO]  
as  
   begin  
  	select codusuario,nomusuario,
	       passusuario, feccreausuario, 
	       fecha_inicio, fecha_fin, estado, 
           nivel_acceso
	        from usuarios
                order by codusuario
   end