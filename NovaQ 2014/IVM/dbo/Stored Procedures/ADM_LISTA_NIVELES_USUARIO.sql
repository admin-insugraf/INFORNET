CREATE procedure [dbo].[ADM_LISTA_NIVELES_USUARIO]
	(@codigo char(2))
as
    if @codigo is null or len(@codigo)=0
       begin
	  select cod_nivel,des_nivel,admin_sn
          from ADM_niveles
	  order by cod_nivel
       end
    else
       begin
          select cod_nivel,des_nivel,admin_sn
          from ADM_niveles
          where cod_nivel=@codigo
       end