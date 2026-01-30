CREATE procedure [dbo].[ADM_ACCESO_PERFIL]
	 (@codperfil varchar(20))
as
	select @codperfil codperfil,cod_opcion,
		ISNULL((select habilitado_sn from adm_perfil_opcion po
			where po.cod_opcion=m.cod_opcion
			and po.COD_PERFIL=@codperfil),'N') habilitado_sn
	from MENU_SISTEMA m
	order by ORDEN