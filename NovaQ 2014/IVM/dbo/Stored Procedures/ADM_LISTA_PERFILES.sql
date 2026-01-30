CREATE procedure [dbo].[ADM_LISTA_PERFILES]
	as
	select cod_perfil,des_perfil,HABILITADO_SN
	from ADM_PERFILES
	where HABILITADO_SN='S'
	order by DES_PERFIL