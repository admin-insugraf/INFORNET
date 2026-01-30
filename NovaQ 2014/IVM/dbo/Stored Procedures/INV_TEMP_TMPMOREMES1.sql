

create procedure [dbo].[INV_TEMP_TMPMOREMES1]
	@mores nvarchar(80),
	@mores1 nvarchar(80)
as
	declare @STRquery nvarchar(500)
	declare @tabla nvarchar(80)
	declare @tabla2 nvarchar(80)

	if exists(select * from tempdb.dbo.sysobjects where name=@mores1)
		begin
		   set @tabla2='[tempdb].dbo.'+@mores1
		   set @STRquery='drop table '+ @tabla2
		exec sp_executesql @STRquery,N'@mores nvarchar(80),@mores1 nvarchar(80),
				@tabla nvarchar(80),@tabla2 nvarchar(80)',@mores,@mores1,@tabla,@tabla2
		end
	set @tabla='[tempdb].dbo.'+@mores
	set @tabla2='[tempdb].dbo.'+@mores1
	set @STRquery='select * into '+@tabla2+ ' from '+@tabla
	exec sp_executesql @STRquery,N'@mores nvarchar(80),@mores1 nvarchar(80),
				@tabla nvarchar(80),@tabla2 nvarchar(80)',@mores,@mores1,@tabla,@tabla2
