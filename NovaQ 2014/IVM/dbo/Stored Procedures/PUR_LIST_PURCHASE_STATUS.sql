--******* CREADO 08/06/2007 *********
--****** PROC - MOSTRAR ESTADOS DE ORDEN *****
CREATE procedure [dbo].[PUR_LIST_PURCHASE_STATUS]
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

        if @opcion='0'   --Buscar si existe el código estado de orden
    	   set @STRquery='Select ID from PURCHASE_STATUS P'

        if @opcion='1'   -- Editar datos de estado de orden
    	   set @STRquery='Select *  from PURCHASE_STATUS P'

        if @opcion='2'   -- Mostrar datos para el GRID
	set @STRquery='Select ID,DESCRIPTION   from PURCHASE_STATUS'

        if @opcion='3'   -- Mostrar datos en las ayuda con F1
	set @STRquery='Select ID,DESCRIPTION  from PURCHASE_STATUS'
       

	set @STRquery=@STRquery + @criterio
	exec sp_executesql @STRquery,N'@codigo char(2),@opcion char(1)',@codigo,@opcion