CREATE procedure [dbo].[INV_CONFIG_HELP]
	@opcion char(1)
as
	declare @STRquery nvarchar(800)
	if @opcion='0'
		set @STRquery='Select DESCRIPTION_FIELD 
			from HELP_PART where NOT NAME_FIELD IN(select NAME_FIELD FROM HELP_CONFIG)'
	if @opcion='1'
		set @STRquery='select ID,NAME_FIELD,DESCRIPTION_FIELD,WIDTH_FIELD 
			from HELP_CONFIG order by ID'
	if @opcion='2'
		set @STRquery='select DESCRIPTION_FIELD 
			from HELP_CONFIG where len(NORDER)>0 order by NORDER'
	exec sp_executesql @STRquery
