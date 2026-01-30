create procedure [dbo].[INV_UNI_MEDIDA]
		@codigo char(6),
		@estado char(1)
as
	declare @STRquery nvarchar(200)
	set @STRquery='select NAME from UNITS where ID=@codigo AND STATUS=@estado'
	exec sp_executesql @STRquery,N'@codigo char(6),@estado char(1)',@codigo,@estado
