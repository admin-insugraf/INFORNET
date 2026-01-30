create procedure [dbo].[INV_SAVE_SERIES_TEMP]
	@pc nvarchar(80),
	@almacen char(3),
	@codigo char(20),
	@serie char(20),
	@cantidad numeric(15,6),
	@precio numeric(15,6)
as
	declare @STRquery nvarchar(2000)
	declare @tabla nvarchar(80)	

	set @tabla='[tempdb].dbo.'+@pc
	set @STRquery='insert into ' + @tabla + '(ALMA,ACODIGO,SERIE,CANTID,
				PUNITARIO) values (@almacen,@codigo,@serie,@cantidad,@precio)'
	exec sp_executesql @STRquery,N'@pc nvarchar(80),@almacen char(3),
			@codigo char(20),@serie char(20),@cantidad numeric(15,6),@precio numeric(15,6),
			@tabla nvarchar(80)',
			@pc,@almacen,@codigo,@serie,@cantidad,@precio,@tabla
