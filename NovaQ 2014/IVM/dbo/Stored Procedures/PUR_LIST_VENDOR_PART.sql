--******* CREADO 06/06/2007 *********
--****** PROC - MOSTRAR DATOS RELACION CLASE PROVEEDOR*****
CREATE procedure [dbo].[PUR_LIST_VENDOR_PART]
--declare
@codigo char(20),@codproveedor char(11),@opcion char(1)
/*
set @codigo=''
set @opcion='2'
*/
as
	declare @STRquery nvarchar(1000)
	declare @criterio nvarchar(1000)
	SET @criterio=N' WHERE 1=1'	
	if len(@codigo)>0
		set @criterio=@criterio + N' and VP.PART_ID=@codigo'
	if len(@codproveedor)>0
		set @criterio=@criterio + N' and VP.VENDOR_ID=@codproveedor'

        if @opcion='2'   -- Mostrar datos para el GRID
	set @STRquery='Select VP.VENDOR_ID,V.NAME from VENDOR_PART VP  INNER JOIN VENDOR V ON VP.VENDOR_ID=V.ID'

        set @STRquery=@STRquery + @criterio
        exec sp_executesql @STRquery,N'@codigo char(20),@codproveedor char(11),@opcion char(1)',@codigo,@codproveedor,@opcion