
create procedure [dbo].[INV_GET_MOV_MORESMES]
	@pc nvarchar(80),
	@almacen char(2)
as
	declare @STRquery nvarchar(500)
	declare @tabla nvarchar(80)
	set @tabla='[tempdb].dbo.'+@pc
	set @STRquery='select * from '+@tabla+ ' where WAREHOUSE_ID=@almacen 
			order by PART_ID,YEAR_MONTH DESC'
	exec sp_executesql @STRquery,N'@pc nvarchar(80),@almacen char(2)',@pc,@almacen
