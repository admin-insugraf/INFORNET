
create procedure [dbo].[INV_TEMP_MESLOTE]
	@pc nvarchar(80)
as
	declare @STRquery nvarchar(1500)
	declare @tabla nvarchar(80)
	if exists(select * from tempdb.dbo.sysobjects where name=@pc)
		begin
		   set @tabla='[tempdb].dbo.'+@pc
		   set @STRquery='drop table '+ @tabla
		exec sp_executesql @STRquery,N'@pc nvarchar(80),@tabla nvarchar(80)',
							@pc,@tabla				
		end
	set @tabla='[tempdb].dbo.'+@pc
	set @STRquery='create table '+@tabla+ ' (idL int IDENTITY(1,1),FECHAS DATETIME)'	
	exec sp_executesql @STRquery,N'@pc nvarchar(80),@tabla nvarchar(80)',
							@pc,@tabla


