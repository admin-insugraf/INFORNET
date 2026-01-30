CREATE procedure [dbo].[INV_LIST_CENTER_COST]
--declare
  @codigo char(2),@opcion char(1)
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

        if @opcion='0'   --Buscar si existe el código del almacen
    	   set @STRquery='Select COST_CENTER_ID  from CENTER_COST P'

        if @opcion='1'   -- Editar datos del almacen
    	   set @STRquery='Select *  from CENTER_COST P'

        if @opcion='2'   -- Mostrar datos para el GRID
    	   set @STRquery='Select * FROM CENTER_COST '

	set @STRquery=@STRquery + @criterio
	exec sp_executesql @STRquery,N'@codigo char(2),@opcion char(1)',@codigo,@opcion