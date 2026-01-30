create procedure [dbo].[INV_ACTUALIZAR_LOTE]
	--declare
	@ingsal char(1),
	@cantidad numeric(15,6),
	@almacen char(2),
	@codigo char(20),
	@codlote char(20)

/*set @ingsal='0'
set @cantidad=1
set @almacen='01'
set @codigo='003'
set @codlote='lot125'
--*/as
	declare @STRquery nvarchar(400)
	if @ingsal=1
		set @STRquery='update LOT set QTY_ON_HAND=QTY_ON_HAND + @cantidad 
			where WHO_ID=@almacen and PART_ID=@codigo and LOT_ID=@codlote'

	if @ingsal=0
		set @STRquery='update LOT set QTY_ON_HAND=QTY_ON_HAND - @cantidad 
			where WHO_ID=@almacen and PART_ID=@codigo and LOT_ID=@codlote'

	exec sp_executesql @STRquery,N'@ingsal char(1),@cantidad numeric(15,6),
				@almacen char(2),@codigo char(20),@codlote char(20)',
				@ingsal,@cantidad,@almacen,@codigo,@codlote
