CREATE procedure [dbo].[INV_HELP_PART]
as
	declare @STRquery nvarchar(800)
	set @STRquery='select ID,NAME_FIELD,DESCRIPTION_FIELD,NORDER,WIDTH_FIELD
					from HELP_CONFIG'
	exec sp_executesql @STRquery
