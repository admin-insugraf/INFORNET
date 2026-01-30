
create procedure [dbo].[INV_INS_MOREMES]
	@pc nvarchar(80),
	@almacen char(2),
	@codigo char(20),
	@mespro char(6),
	@saldo numeric(15,6),
	@presoles numeric(19,10),
	@predolares numeric(19,10)
as
	declare @STRquery nvarchar(2000)
	declare @tabla nvarchar(80)
	set @tabla='[tempdb].dbo.'+@pc
	set @STRquery='insert into '+@tabla+'(WAREHOUSE_ID,PART_ID,YEAR_MONTH,QTY_INITIAL,
										AMOUNT,AMOUNT_US)
					values(@almacen,@codigo,@mespro,@saldo,@presoles,@predolares)'
	exec sp_executesql @STRquery,N'@pc nvarchar(80),@almacen char(2),@codigo char(20),
							@mespro char(6),@saldo numeric(15,6),@presoles numeric(19,10),
							@predolares numeric(19,10),@tabla nvarchar(80)',@pc,@almacen,
							@codigo,@mespro,@saldo,@presoles,@predolares,@tabla
