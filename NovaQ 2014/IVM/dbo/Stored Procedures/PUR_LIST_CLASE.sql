--******* CREADO 21/04/2007 *********
--****** PROC - MOSTRAR COLOR*****
CREATE procedure [dbo].[PUR_LIST_CLASE]
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

        if @opcion='0'   --Buscar si existe el código del color
    	   set @STRquery='Select id  from COLOR P'

        if @opcion='1'   -- Editar datos del color
    	   set @STRquery='Select *  from COLOR P'

        if @opcion='2'   -- Mostrar datos para el GRID
	set @STRquery='Select ID,NAME from COLOR'

        if @opcion='3'   -- Mostrar datos en las ayuda con F1
	set @STRquery='Select ID,NAME  from COLOR'
       

	set @STRquery=@STRquery + @criterio
	exec sp_executesql @STRquery,N'@codigo char(20),@opcion char(1)',@codigo,@opcion