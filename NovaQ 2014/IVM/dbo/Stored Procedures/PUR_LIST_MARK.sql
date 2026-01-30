--******* CREADO  21/04/2007 *********
--****** PROC - MOSTRAR CLASE DE ARTICULOS*****
CREATE procedure [dbo].[PUR_LIST_MARK]
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

        if @opcion='0'   --Buscar si existe el código de la clase de artículos
    	   set @STRquery='Select id  from MARK P'

        if @opcion='1'   -- Editar datos de la marca
    	   set @STRquery='Select *  from MARK P'

        if @opcion='2'   -- Mostrar datos para el GRID
	set @STRquery='Select ID,NAME from MARK'

        if @opcion='3'   -- Mostrar datos en las ayuda con F1
	set @STRquery='Select ID,NAME  from MARK'
       

	set @STRquery=@STRquery + @criterio
	exec sp_executesql @STRquery,N'@codigo char(20),@opcion char(1)',@codigo,@opcion