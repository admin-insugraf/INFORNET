CREATE procedure [dbo].[INV_AUTONUM]
	@pc nvarchar(80),
	@pc2 nvarchar(80)
as
	declare @STRquery nvarchar(500)
	declare @tabla nvarchar(80)
	declare @tabla2 nvarchar(80)

	if exists(select * from tempdb.dbo.sysobjects where name=@pc2)
		begin
		   set @tabla2='[tempdb].dbo.'+@pc2
		   set @STRquery='drop table '+ @tabla2
		   exec sp_executesql @STRquery,N'@pc nvarchar(80),@pc2 nvarchar(80),
							@tabla nvarchar(80),@tabla2 nvarchar(80)',
						@pc,@pc2,@tabla,@tabla2
		end

	set @tabla='[tempdb].dbo.'+@pc
	set @tabla2='[tempdb].dbo.'+@pc2
	set @STRquery='select max(ID) AS IDX into '+@tabla2+ ' from '+@tabla+ ' group by PART_ID,ANOMES'
	exec sp_executesql @STRquery,N'@pc nvarchar(80),@pc2 nvarchar(80),
							@tabla nvarchar(80),@tabla2 nvarchar(80)',
						@pc,@pc2,@tabla,@tabla2