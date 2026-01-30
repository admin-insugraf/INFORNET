--******* CREADO 23/04/2007 *********
--****** PROC - MOSTRAR PARTIDAS ARANCELARIAS*****
CREATE procedure [dbo].[PUR_LIST_CUSTOMS_TARIFF]
--declare
@codigo char(14),@opcion char(1)
/*
set @codigo=''
set @opcion='2'
*/
as
	declare @STRquery nvarchar(1000)
	declare @criterio nvarchar(1000)
	SET @criterio=N' WHERE 1=1'	
	if len(@codigo)>0
		set @criterio=@criterio + N' and P.CUSTOMSTARIFF_ID=@codigo'

        if @opcion='0'   --Buscar si existe el código de la partida arancelaria
    	   set @STRquery='Select CUSTOMSTARIFF_ID  from CUSTOMS_TARIFF P'

        if @opcion='1'   -- Editar datos de la marca
    	   set @STRquery='Select *  from CUSTOMS_TARIFF P'

        if @opcion='2'   -- Mostrar datos para el GRID
	set @STRquery='Select CUSTOMSTARIFF_ID,NAME, CUSTOMS_MEASURE from CUSTOMS_TARIFF P'

        if @opcion='3'   -- Mostrar datos en las ayuda con F1
	set @STRquery='Select CUSTOMSTARIFF_ID,NAME  from CUSTOMS_TARIFF P'
       

	set @STRquery=@STRquery + @criterio
	exec sp_executesql @STRquery,N'@codigo char(14),@opcion char(1)',@codigo,@opcion