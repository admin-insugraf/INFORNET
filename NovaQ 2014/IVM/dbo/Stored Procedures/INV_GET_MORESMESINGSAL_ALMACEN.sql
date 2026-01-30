
create procedure [dbo].[INV_GET_MORESMESINGSAL_ALMACEN]
	@pc nvarchar(80)
as
	declare @STRquery nvarchar(500)
	declare @tabla nvarchar(80)
	set @tabla='[tempdb].dbo.'+@pc
	set @STRquery='select distinct(WAREHOUSE_ID) from '+@tabla+ ' order by WAREHOUSE_ID'
	exec sp_executesql @STRquery,N'@pc nvarchar(80)',@pc
