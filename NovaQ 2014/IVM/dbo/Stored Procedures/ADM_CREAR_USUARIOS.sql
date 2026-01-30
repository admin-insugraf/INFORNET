CREATE PROCEDURE [dbo].[ADM_CREAR_USUARIOS]
    (@cod_usuario varchar(50),
     @nom_usuario varchar(80),
     @pass_usuario varchar(15),
     @fecha_inicio datetime=null,
     @fecha_fin datetime=null,
     @estado char(1),
     @nivel_acceso char(2),
     @ins_upd char(1)
     )  
as
     declare @fec_ini datetime
     declare @fec_fin datetime
     if @fecha_inicio is not null
         begin
            set @fec_ini=@fecha_inicio
            set @fec_fin=@fecha_fin
         end
     else
         begin
	    set @fec_ini=null
                 set @fec_fin=null
         end     

     if @ins_upd='I'
        begin
          insert into usuarios(codusuario,nomusuario,passusuario,
                               FECCREAUSUARIO,fecha_inicio,fecha_fin,
                               estado,nivel_acceso)
          values(@cod_usuario,@nom_usuario,@pass_usuario,
                 getdate(),@fec_ini,@fec_fin,
                 @estado,@nivel_acceso)
        end
     else
        begin
	   update usuarios
               set nomusuario=@nom_usuario,
                   passusuario=@pass_usuario,
                   fecha_inicio=@fec_ini,
                   fecha_fin=@fec_fin,
                   estado=@estado,
                   fecha_modificacion=getdate(),
                   nivel_acceso=@nivel_acceso
           where codusuario=@cod_usuario
        end