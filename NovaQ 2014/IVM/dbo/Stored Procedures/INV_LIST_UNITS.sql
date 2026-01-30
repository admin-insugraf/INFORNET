CREATE procedure [dbo].[INV_LIST_UNITS]
as
	declare @STRquery nvarchar(38)
	set @STRquery='Select ID,NAME,STATUS from UNITS'
	exec sp_executesql  @STRquery
