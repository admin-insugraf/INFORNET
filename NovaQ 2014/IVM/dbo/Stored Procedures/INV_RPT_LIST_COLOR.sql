create procedure [dbo].[INV_RPT_LIST_COLOR]
as
	declare @STRquery nvarchar(100)
	set @STRquery='select ID,NAME from color'
	exec sp_executesql @STRquery
