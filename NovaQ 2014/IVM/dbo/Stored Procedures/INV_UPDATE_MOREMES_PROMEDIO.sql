
create procedure [dbo].[INV_UPDATE_MOREMES_PROMEDIO]
	@pc nvarchar(80),
	@presoles numeric(19,10),
	@predolares numeric(19,10),
	@codigo char(20),
	@mespro char(6)
as
	declare @STRquery nvarchar(2000)
	declare @tabla nvarchar(80)
	set @tabla='[tempdb].dbo.'+@pc
	set @STRquery='update '+@tabla+ ' set AMOUNT=@presoles,AMOUNT_US=@predolares
				where PART_ID=@codigo and YEAR_MONTH>=@mespro'
	exec sp_executesql @STRquery,N'@pc nvarchar(80),@presoles numeric(19,10),
						@predolares numeric(19,10),@codigo char(20),@mespro char(6),
						@tabla nvarchar(80)',@pc,@presoles,@predolares,@codigo,@mespro,@tabla
