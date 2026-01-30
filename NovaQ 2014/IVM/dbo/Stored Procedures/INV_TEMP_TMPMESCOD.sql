
create procedure [dbo].[INV_TEMP_TMPMESCOD]
	@moremes nvarchar(80),
	@mescod nvarchar(80)
as
	declare @STRquery nvarchar(500)
	declare @tabla nvarchar(80)
	declare @tabla2 nvarchar(80)

	if exists(select * from tempdb.dbo.sysobjects where name=@mescod)
		begin
		   set @tabla2='[tempdb].dbo.'+@mescod
		   set @STRquery='drop table '+ @tabla2
		exec sp_executesql @STRquery,N'@moremes nvarchar(80),@mescod nvarchar(80),
				@tabla nvarchar(80),@tabla2 nvarchar(80)',
				@moremes,mescod,@tabla,@tabla2
		end
	set @tabla='[tempdb].dbo.'+@moremes
	set @tabla2='[tempdb].dbo.'+@mescod
	set @STRquery='select max(YEAR_MONTH) as MESPRO,PART_ID,WAREHOUSE_ID 
				into '+@tabla2+ ' from '+@tabla+ ' group by PART_ID,WAREHOUSE_ID'
	exec sp_executesql @STRquery,N'@moremes nvarchar(80),@mescod nvarchar(80),
				@tabla nvarchar(80),@tabla2 nvarchar(80)',
				@moremes,mescod,@tabla,@tabla2
