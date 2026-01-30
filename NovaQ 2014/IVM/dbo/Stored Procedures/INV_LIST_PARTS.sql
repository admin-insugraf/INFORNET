CREATE procedure [dbo].[INV_LIST_PARTS]
as
	declare @STRquery nvarchar(125)
	set @STRquery='Select ID,DESCRIPTION,UNIT_OF_MEASUREMENT,SERIES,IS_LOT,
			ID_FAB,FAMILY,MODEL,GROUP_ID,TYPE_PART,ACCOUNT,MARK from PART'
	exec sp_executesql  @STRquery

