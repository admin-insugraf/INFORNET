CREATE procedure [dbo].[ADM_LISTAR_USUARIOS]
	(@codigo varchar(30),
	 @nombre varchar(80))
as
	if (@codigo is null or @codigo='') and (@nombre is null or @nombre='')
		begin
			select codusuario,nomusuario
				   pass_usuario
			from USUARIOS
		end
	else
		begin
			if @codigo is not null or @codigo<>''
				begin
					select codusuario,nomusuario
					from USUARIOS
					where codusuario like '%' + @codigo + '%'
					order by codusuario
				end
			else
				begin
					select codusuario,nomusuario
					from USUARIOS
					where nomusuario like '%' + @nombre + '%'
					order by nomusuario
				end
		end