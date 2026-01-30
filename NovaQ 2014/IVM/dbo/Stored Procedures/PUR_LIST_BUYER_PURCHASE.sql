--******* CREADO 05/06/2007 *********
--****** PROC - MOSTRAR DATOS TIPO DE MONEDAS DE IMPORTACION*****
CREATE procedure [dbo].[PUR_LIST_BUYER_PURCHASE]
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

        if @opcion='0'   --Buscar si existe el código de familia
    	   set @STRquery='Select id  from BUYER_PURCHASE P'

        if @opcion='1'   -- Editar datos de la familia
    	   set @STRquery='Select *  from BUYER_PURCHASE P'

        if @opcion='2'   -- Mostrar datos para el GRID
	set @STRquery='Select ID,NAME   from BUYER_PURCHASE'

        if @opcion='3'   -- Mostrar datos en las ayuda con F1
	set @STRquery='Select ID,NAME  from BUYER_PURCHASE'
       

	set @STRquery=@STRquery + @criterio
	exec sp_executesql @STRquery,N'@codigo char(2),@opcion char(1)',@codigo,@opcion