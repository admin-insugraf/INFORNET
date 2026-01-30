
create procedure [dbo].[INV_VALIDA_NULOS]
as
	declare @STRquery nvarchar(200)
	set @STRquery='update MONTHLY_SUMMARIZE set QTY_ENTER=0 where QTY_ENTER is null'
	exec sp_executesql @STRquery
	
	set @STRquery='update MONTHLY_SUMMARIZE set QTY_OUT=0 where QTY_OUT is null'
	exec sp_executesql @STRquery
