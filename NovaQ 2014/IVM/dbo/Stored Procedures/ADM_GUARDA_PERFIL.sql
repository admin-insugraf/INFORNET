create procedure ADM_GUARDA_PERFIL
	(@COD_PERFIL VARCHAR(20),
	 @DES_PERFIL VARCHAR(60),
	 @COD_USUARIO VARCHAR(15),
	 @HABILITADO CHAR(1),
	 @INS_UPD CHAR(1)
	 )
as
	if @INS_UPD='I'
		begin
		    insert into ADM_PERFILES
					(
					COD_PERFIL,
					DES_PERFIL,
					FECHA_CREACION,
					COD_USUARIO,
					HABILITADO_SN
					)
			VALUES
				(@COD_PERFIL,
				 @DES_PERFIL,
				 GETDATE(),
				 @COD_USUARIO,
				 @HABILITADO
				 )
		  end
    else
		  begin
		    update adm_perfiles
				set DES_PERFIL=@DES_PERFIL,
				    fecha_modificacion=GETDATE(),
				    COD_USUARIO=@COD_USUARIO,
				    HABILITADO_SN=@HABILITADO
		    where COD_PERFIL=@COD_PERFIL
		  end