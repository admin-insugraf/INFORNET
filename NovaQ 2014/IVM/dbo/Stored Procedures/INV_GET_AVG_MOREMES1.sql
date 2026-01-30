
create procedure [dbo].[INV_GET_AVG_MOREMES1]
	@pc nvarchar(80),
	@codigo char(20)
as
	declare @STRquery nvarchar(2000)
	declare @tabla nvarchar(80)
	set @tabla='[tempdb].dbo.'+@pc
	set @STRquery='select PART_ID,YEAR_MONTH,
		avg(AMOUNT) as MN,avg(AMOUNT_US) as ME 
		from '+@tabla+ ' where PART_ID=@codigo group by PART_ID,YEAR_MONTH'
	exec sp_executesql @STRquery,N'@pc nvarchar(80),@codigo char(20),@tabla nvarchar(80)',
							@pc,@codigo,@tabla
