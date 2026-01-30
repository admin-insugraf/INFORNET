CREATE procedure [dbo].[PUR_RPT_LIST_ADMINISTRATOR]
as
	declare @STRquery nvarchar(1000)
	set @STRquery='SELECT * FROM ADMINISTRATOR ORDER BY ID'
	set @STRquery=@STRquery
	exec sp_executesql @STRquery