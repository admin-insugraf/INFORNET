create procedure [dbo].[INV_PART_TYPE]
as
	declare @STRquery nvarchar(200)
	set @STRquery='select ID,NAME from PART_TYPE order by ID'
	exec sp_executesql @STRquery
