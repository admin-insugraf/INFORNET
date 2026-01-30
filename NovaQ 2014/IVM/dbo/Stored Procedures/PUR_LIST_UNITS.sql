--******* CREADO 21/04/2007 *********
--****** PROC - MOSTRAR DATOS DE UNIDAD DE MEDIDA*****
CREATE procedure [dbo].[PUR_LIST_UNITS]
--declare
@codigo char(6),@opcion char(1)
/*
set @codigo=''
set @opcion='2'
*/
as
	declare @STRquery nvarchar(1000)
	declare @criterio nvarchar(1000)
	SET @criterio=N' WHERE 1=1'	
	if len(@codigo)>0
		set @criterio=@criterio + N' and P.ID=@codigo'

        if @opcion='0'   --Buscar si existe el código del unidad de medida
    	   set @STRquery='Select id  from UNITS P'

        if @opcion='1'   -- Editar datos de la unidad de medida
    	   set @STRquery='Select *  from UNITS P'

        if @opcion='2'   -- Mostrar datos para el GRID
	set @STRquery='Select ID,NAME,STATUS from UNITS'

        if @opcion='3'   -- Mostrar datos en las ayuda con F1
	set @STRquery='Select ID,NAME  from UNITS'
       

	set @STRquery=@STRquery + @criterio


	exec sp_executesql @STRquery,N'@codigo char(6),@opcion char(1)',@codigo,@opcion