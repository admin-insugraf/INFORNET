CREATE procedure [dbo].[INV_UPDATE_TMPSTKART]
	@stk nvarchar(80),	
	@stkfinal nvarchar(80)
as
	declare @STRquery nvarchar(1500)
	declare @tabla nvarchar(80)
	declare @tabla2 nvarchar(80)
	set @tabla='[tempdb].dbo.'+@stk
	set @tabla2='[tempdb].dbo.'+@stkfinal
	set @STRquery='update '+@tabla+ ' set QTY_ON_HAND=(isnull(B.QTY_ENTER,0)-isnull(B.QTY_OUT,0))+isnull(B.QTY_INITIAL,0) 
				from '+@tabla+ ' A 
				inner join '+@tabla2+ ' B 
				on a.PART_ID=b.PART_ID AND A.WAREHOUSE_ID=B.WAREHOUSE_ID'
	exec sp_executesql @STRquery,N'@stk nvarchar(80),@stkfinal nvarchar(80),
						@tabla nvarchar(80),@tabla2 nvarchar(80)',
						@stk,@stkfinal,@tabla,@tabla2
