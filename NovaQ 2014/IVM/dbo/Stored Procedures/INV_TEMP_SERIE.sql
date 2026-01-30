create procedure [dbo].[INV_TEMP_SERIE]
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

	set @STRquery='create table '+ @tabla+'(ALMA char(3),ACODIGO char(20),
			SERIE char(20),CANTID numeric(15,6),ITEM char(10),
			PUNITARIO numeric(15,6))'
	exec sp_executesql @STRquery,N'@pc nvarchar(80),@tabla nvarchar(80)',
						@pc,@tabla