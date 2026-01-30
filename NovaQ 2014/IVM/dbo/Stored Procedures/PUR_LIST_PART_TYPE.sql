--******* CREADO 23/04/2007 *********
--****** PROC - MOSTRAR DATOS DE TIPO DE ARTICULO*****
CREATE procedure [dbo].[PUR_LIST_PART_TYPE]
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

        if @opcion='0'   --Buscar si existe el código del tipo de articulo
    	   set @STRquery='Select id  from PART_TYPE P'

        if @opcion='1'   -- Editar datos del tipo de articulo
    	   set @STRquery='Select *  from PART_TYPE P'

        if @opcion='2'   -- Mostrar datos para el GRID
	set @STRquery='Select ID,NAME from PART_TYPE'

        if @opcion='3'   -- Mostrar datos en las ayuda con F1
	set @STRquery='Select ID,NAME  from PART_TYPE'
       

	set @STRquery=@STRquery + @criterio
	exec sp_executesql @STRquery,N'@codigo char(2),@opcion char(1)',@codigo,@opcion