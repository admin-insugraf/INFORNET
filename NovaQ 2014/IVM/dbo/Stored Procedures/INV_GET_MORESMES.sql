
create procedure [dbo].[INV_GET_MORESMES]
	@pc nvarchar(80)
as
	declare @STRquery nvarchar(500)
	declare @tabla nvarchar(80)
	set @tabla='[tempdb].dbo.'+@pc
    set @STRquery='select * from '+@tabla+ ' order by PART_ID,YEAR_MONTH DESC'
	exec sp_executesql @STRquery,N'@pc nvarchar(80)',@pc
