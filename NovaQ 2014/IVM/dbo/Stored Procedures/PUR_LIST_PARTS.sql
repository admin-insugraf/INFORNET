--******* CREADO 21/04/2007 *********
--****** PROC - MOSTRAR DATOS DE ARTICULOS*****
CREATE procedure [dbo].[PUR_LIST_PARTS]
--declare
@codigo char(20),@opcion char(1)
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

        if @opcion='0'   --Buscar si existe el código del articulo
    	   set @STRquery='Select id  from PART P'

        if @opcion='1'   -- Editar datos del articulo
    	   set @STRquery='Select *  from PART P'

        if @opcion='2'   -- Mostrar datos para el GRID
    	   set @STRquery='Select ID,DESCRIPTION,UNIT_OF_MEASUREMENT,ID_FAB,DESCRIPTION_OPT,SERIES,IS_LOT,
			FAMILY,MODEL,GROUP_ID,TYPE_PART,MARK,COMMENT from PART '

	set @STRquery=@STRquery + @criterio
	exec sp_executesql @STRquery,N'@codigo char(20),@opcion char(1)',@codigo,@opcion