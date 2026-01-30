CREATE procedure [dbo].[INV_SALDO_ARTICULO]
	@almacen char(2),
	@codigo char(20)
as
	declare @STRquery nvarchar(200)
	set @STRquery='SELECT QTY_ON_HAND FROM PART_QTY 
				where WAREHOUSE_ID=@almacen
				AND PART_ID=@codigo'
	exec sp_executesql @STRquery,N'@almacen char(2),@codigo char(20)',@almacen,@codigo


