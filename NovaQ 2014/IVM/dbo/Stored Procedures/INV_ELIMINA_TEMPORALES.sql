create procedure [dbo].[INV_ELIMINA_TEMPORALES]
	@nombre nvarchar(100)
as
	declare @STRquery nvarchar(1500)
	declare @tabla nvarchar(80)
	if exists(select * from tempdb.dbo.sysobjects where name=@nombre)
      begin
         set @tabla=N'[tempdb].dbo.'+@nombre
         set @STRquery='drop table '+ @tabla
         	exec sp_executesql @STRquery,N'@nombre nvarchar(100)',
						@nombre
      end
