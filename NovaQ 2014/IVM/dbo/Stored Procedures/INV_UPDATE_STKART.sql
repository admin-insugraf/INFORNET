CREATE procedure [dbo].[INV_UPDATE_STKART]
	@stktemp nvarchar(80)
as
	declare @STRquery nvarchar(1500)
	declare @tabla nvarchar(80)
	set @tabla='[tempdb].dbo.'+@stktemp
	set @STRquery='update A set A.QTY_ON_HAND=B.QTY_ON_HAND,A.COST_AVG=B.COST_AVG,
		A.COST_AVG_US=B.COST_AVG_US,A.QTY_REFERENCE=B.QTY_REFERENCE 
		from PART_QTY A 
		inner join '+@tabla+ ' B 
		on A.WAREHOUSE_ID=B.WAREHOUSE_ID and A.PART_ID=B.PART_ID'
	exec sp_executesql @STRquery,N'@stktemp nvarchar(80),@tabla nvarchar(80)',
				@stktemp,@tabla