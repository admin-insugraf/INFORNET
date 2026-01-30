--******* CREADO 11/06/2007 *********
--****** PROC - MOSTRAR LOS REQUERIMIENTOS DETALLES*****
CREATE procedure [dbo].[PUR_LIST_REQUIREMENT_LINE]
--declare
@codigo char(10),@tipo char(2),@opcion char(1)
/*
set @codigo='00000001'
set @tipo='RQ'
set @fechaini=39229
set @fechaini=39229
set @opcionTODOS='TODOS'
set @opcion='2'
*/
as
	declare @STRquery nvarchar(1000)
	declare @criterio nvarchar(1000)
	SET @criterio=N' WHERE 1=1'	
	if len(@codigo)>0
		set @criterio=@criterio + N' and R.ID=@codigo'

	if len(@tipo)>0
		set @criterio=@criterio + N' and  R.TYPE=@tipo'


        if @opcion='0'   --Buscar si existe el código del requerimiento
    	   set @STRquery='Select ID from REQUIREMENT R'

        if @opcion='1'   -- Editar datos de requerimiento
    	   set @STRquery='Select *  from REQUIREMENT R'

	set @STRquery=@STRquery + @criterio

     exec sp_executesql @STRquery,N'@codigo char(10),@tipo char(2),@opcion char(1)'
               ,@codigo,@tipo,@opcion