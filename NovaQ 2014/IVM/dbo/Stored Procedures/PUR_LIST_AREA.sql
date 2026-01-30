--******* CREADO 05/06/2007 *********
--****** PROC - MOSTRAR DATOS AREA*****
CREATE procedure [dbo].[PUR_LIST_AREA]
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

        if @opcion='0'   --Buscar si existe el código de familia
    	   set @STRquery='Select id  from AREA P'

        if @opcion='1'   -- Editar datos de la familia
    	   set @STRquery='Select *  from AREA P'

        if @opcion='2'   -- Mostrar datos para el GRID
	set @STRquery='Select ID,DESCRIPTION   from AREA'

        if @opcion='3'   -- Mostrar datos en las ayuda con F1
	set @STRquery='Select ID,DESCRIPTION  from AREA'
       

	set @STRquery=@STRquery + @criterio
	exec sp_executesql @STRquery,N'@codigo char(6),@opcion char(1)',@codigo,@opcion