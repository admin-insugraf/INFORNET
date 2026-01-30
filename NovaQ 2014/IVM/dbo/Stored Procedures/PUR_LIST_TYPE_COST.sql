--******* CREADO 07/06/2007 *********
--****** PROC - MOSTRAR GASTOS DE IMPORTACION*****
CREATE procedure [dbo].[PUR_LIST_TYPE_COST]
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

        if @opcion='0'   --Buscar si existe el código tipo de orden de importacion
    	   set @STRquery='Select ID from TYPE_COST P'

        if @opcion='1'   -- Editar datos de tipo de orden de importacion
    	   set @STRquery='Select *  from TYPE_COST P'

        if @opcion='2'   -- Mostrar datos para el GRID
	set @STRquery='Select ID,DESCRIPTION,DESCRIPTION_ABRE   from TYPE_COST'

        if @opcion='3'   -- Mostrar datos en las ayuda con F1
	set @STRquery='Select ID,DESCRIPTION  from TYPE_COST'
       

	set @STRquery=@STRquery + @criterio
	exec sp_executesql @STRquery,N'@codigo char(2),@opcion char(1)',@codigo,@opcion