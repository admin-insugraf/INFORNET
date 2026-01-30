CREATE procedure [dbo].[INV_TEMP_TMPSTKARTFINAL]
	@stkfinal nvarchar(80),
	@moremes nvarchar(80),
	@mescod nvarchar(80)
as
	declare @STRquery nvarchar(500)
	declare @tabla nvarchar(80)
	declare @tabla2 nvarchar(80)
	declare @tabla3 nvarchar(80)

	if exists(select * from tempdb.dbo.sysobjects where name=@stkfinal)
		begin
		   set @tabla3='[tempdb].dbo.'+@stkfinal
		   set @STRquery='drop table '+ @tabla3
		exec sp_executesql @STRquery,N'@stkfinal nvarchar(80),@moremes nvarchar(80),
				@mescod nvarchar(80),@tabla nvarchar(80),@tabla2 nvarchar(80),
				@tabla3 nvarchar(80)',
				@stkfinal,@moremes,mescod,@tabla,@tabla2,@tabla3
		end
	set @tabla='[tempdb].dbo.'+@moremes
	set @tabla2='[tempdb].dbo.'+@mescod
	set @tabla3='[tempdb].dbo.'+@stkfinal

	set @STRquery='select a.* into '+@tabla3+ ' from '+@tabla+ ' A 
		inner join '+@tabla2+ ' B on A.YEAR_MONTH=B.MESPRO
		and A.PART_ID=B.PART_ID AND A.WAREHOUSE_ID=B.WAREHOUSE_ID'
	exec sp_executesql @STRquery,N'@stkfinal nvarchar(80),@moremes nvarchar(80),
				@mescod nvarchar(80),@tabla nvarchar(80),@tabla2 nvarchar(80),
				@tabla3 nvarchar(80)',
				@stkfinal,@moremes,mescod,@tabla,@tabla2,@tabla3	
