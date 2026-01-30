
create procedure [dbo].[INV_GET_ALMACEN_TMPMOREMES]
	@mores nvarchar(80)
as
	declare @STRquery nvarchar(500)
	declare @tabla nvarchar(80)
	set @tabla='[tempdb].dbo.'+@mores
	set @STRquery='select distinct(WAREHOUSE_ID) from '+@tabla
	exec sp_executesql @STRquery,N'@mores nvarchar(80),@tabla nvarchar(80)',
			@mores,@tabla
