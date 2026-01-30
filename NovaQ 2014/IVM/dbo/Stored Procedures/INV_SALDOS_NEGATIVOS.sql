create procedure [dbo].[INV_SALDOS_NEGATIVOS]
as
	declare @STRquery nvarchar(100)
	set @STRquery='select PART_ID from MONTHLY_SUMMARIZE where QTY_INITIAL<0 group by PART_ID'
	exec sp_executesql @STRquery
