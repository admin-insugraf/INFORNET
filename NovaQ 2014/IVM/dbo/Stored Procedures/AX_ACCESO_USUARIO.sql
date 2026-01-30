create PROCEDURE [dbo].[AX_ACCESO_USUARIO]   
     (@codigo varchar(15))  
AS  
select @codigo cod_usuario,cod_opcion,
     isnull((select habilitado_sn from usuarios_opcion uo
	where uo.cod_opcion=m.cod_opcion
        and cod_usuario=@codigo),'N') habilitado_sn
from menu_sistema m
order by orden