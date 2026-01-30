--******* CREADO 07/06/2007 *********
--****** PROC - MOSTRAR DATOS BANCO*****
CREATE procedure [dbo].[PUR_LIST_CUSTOMS]
--declare
@codigo char(3),@opcion char(1)
/*
set @codigo=''
set @opcion='2'
*/
as
	declare @STRquery nvarchar(1000)
	declare @criterio nvarchar(1000)
	SET @criterio=N' WHERE 1=1'	
	if len(@codigo)>0
		set @criterio=@criterio + N' and P.CUSTOMS_ID=@codigo'

        if @opcion='0'   --Buscar si existe el código agencia aduana
    	   set @STRquery='Select CUSTOMS_ID from CUSTOMS P'

        if @opcion='1'   -- Editar datos del banco
    	   set @STRquery='Select *  from CUSTOMS P'

        if @opcion='2'   -- Mostrar datos para el GRID
	set @STRquery='Select CUSTOMS_ID,NAME   from CUSTOMS'

        if @opcion='3'   -- Mostrar datos en las ayuda con F1
	set @STRquery='Select CUSTOMS_ID,NAME  from CUSTOMS'
       

	set @STRquery=@STRquery + @criterio
	exec sp_executesql @STRquery,N'@codigo char(3),@opcion char(1)',@codigo,@opcion