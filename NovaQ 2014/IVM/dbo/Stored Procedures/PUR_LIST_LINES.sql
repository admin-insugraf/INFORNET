--******* CREADO 23/04/2007 *********
--****** PROC - MOSTRAR DATOS DE GRUPOS DE ARTICULOS*****
CREATE procedure [dbo].[PUR_LIST_LINES]
--declare
@codigo char(8),@codigo1 char(8),@opcion char(1)
/*
set @codigo=''
set @opcion='2'
set @opcion1='2'
*/
as
	declare @STRquery nvarchar(1000)
	declare @criterio nvarchar(1000)
	SET @criterio=N' WHERE 1=1'	
             if len(@codigo)>0
		set @criterio=@criterio + N' and P.FAMILY_ID=@codigo'
	if len(@codigo1)>0
		set @criterio=@criterio + N' and ID= @codigo1'

           if @opcion='0'   --Buscar si existe la linea
    	   set @STRquery='Select id  from LINES P '

          if @opcion='1'   -- Editar datos de la linea
    	   set @STRquery='Select *  from LINES P '

          if @opcion='2'   -- Mostrar datos para el GRID
	set @STRquery='Select ID,NAME from LINES P '

          if @opcion='3'   -- Mostrar datos en las ayuda con F1
	set @STRquery='Select ID,NAME  from LINES P '
       

	set @STRquery=@STRquery + @criterio
	exec sp_executesql @STRquery,N'@codigo char(8),@codigo1 char(8),@opcion char(1)',@codigo,@codigo1,@opcion