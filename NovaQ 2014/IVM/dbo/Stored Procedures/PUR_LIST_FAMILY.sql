--******* CREADO 23/04/2007 *********
--****** PROC - MOSTRAR DATOS DE FAMILIA DE ARTICULOS*****
CREATE procedure [dbo].[PUR_LIST_FAMILY]
--declare
@codigo char(8),@opcion char(1)
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
    	   set @STRquery='Select id  from FAMILY P'

        if @opcion='1'   -- Editar datos de la familia
    	   set @STRquery='Select *  from FAMILY P'

        if @opcion='2'   -- Mostrar datos para el GRID
	set @STRquery='Select ID, NAME, ACCOUNT, ACCOUNT_DR, ACCOUNT_CR, ACCOUNT_PURCHASE, ACCOUNT_EXISTENCE, 
                                         ACCOUNT_DR_AC, ACCOUNT_CR_AC  from FAMILY'

        if @opcion='3'   -- Mostrar datos en las ayuda con F1
	set @STRquery='Select ID,NAME  from FAMILY'
       

	set @STRquery=@STRquery + @criterio
	exec sp_executesql @STRquery,N'@codigo char(8),@opcion char(1)',@codigo,@opcion