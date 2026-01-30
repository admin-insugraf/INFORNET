--******* CREADO 07/06/2007 *********
--****** PROC - MOSTRAR DATOS DE MONEDAS DE IMPORTACION*****
CREATE procedure [dbo].[PUR_LIST_CURRENCY_IMPORT]
--declare
@mes char(2),@anno char(4), @opcion char(1)
/*
set @codigo=''
set @opcion='2'
*/
as
	declare @STRquery nvarchar(1000)
	declare @criterio nvarchar(1000)
	SET @criterio=N' WHERE 1=1'	
	if len(@mes)>0 and len(@anno)>0
		set @criterio=@criterio + N' and C.CURRENCY_MONTH=@mes AND C.CURRENCY_YEAR=@anno '

        if @opcion='2'   -- Mostrar datos para el GRID
	set @STRquery='Select c.CURRTIPIMP_ID,DESCRIPTION,EQUIVALENCE FROM  CURRENCY_IMPORT C  inner join 
                                         CURRENCY_IMPORT_TYPE T ON C.CURRTIPIMP_ID=T.CURRTIPIMP_ID'

	set @STRquery=@STRquery + @criterio
	exec sp_executesql @STRquery,N'@mes char(2),@anno char(4),@opcion char(1)',@mes,@anno,@opcion