--******* CREADO  23/04/2007 *********
--****** PROC - MOSTRAR DATOS DE GRUPOS DE ARTICULOS*****
CREATE procedure [dbo].[PUR_LIST_GROUPS]
--declare
@codigo char(8),@codigo1 char(8),@codigo2 char(11),@opcion char(1)
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
		set @criterio=@criterio + N' and P.FAMILY_ID=@codigo '
	if len(@codigo1)>0
		set @criterio=@criterio + N' and P.LINE_ID = @codigo1 '
	if len(@codigo2)>0
                      set @criterio=@criterio + N' and ID = @codigo2 '

        if @opcion='0'   --Buscar si existe el grupo 
    	   set @STRquery='Select id  from GROUPS P '

        if @opcion='1'   -- Editar datos del grupo
    	   set @STRquery='Select *  from GROUPS P '

        if @opcion='2'   -- Mostrar datos para el GRID
	set @STRquery='Select ID,NAME,LINE_ID from GROUPS P '

        if @opcion='3'   -- Mostrar datos en las ayuda con F1
	set @STRquery='Select ID,NAME  from GROUPS P '
       

	set @STRquery=@STRquery + @criterio
	exec sp_executesql @STRquery,N'@codigo char(8),@codigo1 char(8),@codigo2 char(11),@opcion char(1)',@codigo,@codigo1,@codigo2,@opcion