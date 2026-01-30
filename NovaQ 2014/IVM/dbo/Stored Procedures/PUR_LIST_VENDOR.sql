CREATE procedure [dbo].[PUR_LIST_VENDOR]
--declare
  @codigo char(11),@opcion char(1)
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

        if @opcion='0'   --Buscar si existe el código del proveedor
    	   set @STRquery='Select id  from VENDOR P'

        if @opcion='1'   -- Editar datos del articulo
    	   set @STRquery='Select *  from VENDOR P'

        if @opcion='2'   -- Mostrar datos para el GRID
    	   set @STRquery='Select ID,NAME,VAT_REGISTRATION,ADDR,PHONE,FAX_NUMBER,STATUS FROM VENDOR '

	set @STRquery=@STRquery + @criterio
	exec sp_executesql @STRquery,N'@codigo char(11),@opcion char(1)',@codigo,@opcion