
create procedure [dbo].[INV_TEMP_STKART]
	@pc nvarchar(80)
as
	declare @STRquery nvarchar(2000)
	declare @tabla nvarchar(80)
	if exists(select * from tempdb.dbo.sysobjects where name=@pc)
		begin
		   set @tabla='[tempdb].dbo.'+@pc
		   set @STRquery='drop table '+ @tabla
		   exec sp_executesql @STRquery,N'@pc nvarchar(80),@tabla nvarchar(80)',
						@pc,@tabla
		end
		set @tabla='[tempdb].dbo.'+@pc
		set @STRquery='select * into '+ @tabla +' from PART_QTY'
		exec sp_executesql @STRquery,N'@pc nvarchar(80),@tabla nvarchar(80)',
						@pc,@tabla
