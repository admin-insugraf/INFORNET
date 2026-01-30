--******* CREADO POR EVG - 10/05/2007 *********
--****** PROC - MOSTRAR DATOS DE TRANSPORTISTA*****
CREATE procedure [dbo].[INV_LIST_CARRIER]
--declare
  @codigo char(11),@opcion char(1)
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

        if @opcion='0'   --Buscar si existe el código del transportista
    	   set @STRquery='SELECT ID FROM CARRIER P'

        if @opcion='1'   -- Editar datos del transportista
    	   set @STRquery='SELECT * FROM CARRIER P'

        if @opcion='2'   -- Mostrar datos para el GRID
    	   set @STRquery='SELECT * FROM CARRIER P '

	set @STRquery=@STRquery + @criterio
	exec sp_executesql @STRquery,N'@codigo char(11),@opcion char(1)',@codigo,@opcion