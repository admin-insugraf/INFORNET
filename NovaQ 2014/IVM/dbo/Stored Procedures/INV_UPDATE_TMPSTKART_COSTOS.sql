
create procedure [dbo].[INV_UPDATE_TMPSTKART_COSTOS]
	@stk nvarchar(80),	
	@stkfinal nvarchar(80)
as
	declare @STRquery nvarchar(1500)
	declare @tabla nvarchar(80)
	declare @tabla2 nvarchar(80)
	set @tabla='[tempdb].dbo.'+@stk
	set @tabla2='[tempdb].dbo.'+@stkfinal
	set @STRquery='update '+@tabla+ ' set COST_AVG=ISNULL(b.AMOUNT,0),COST_AVG_US=ISNULL(b.AMOUNT_US,0) 
		from '+@tabla+ ' A 
		inner join '+@tabla2+ ' B on a.PART_ID=b.PART_ID'
	exec sp_executesql @STRquery,N'@stk nvarchar(80),@stkfinal nvarchar(80),
				@tabla nvarchar(80),@tabla2 nvarchar(80)',
				@stk,@stkfinal,@tabla,@tabla2
