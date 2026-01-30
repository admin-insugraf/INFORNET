CREATE procedure [dbo].[PUR_RPT_LIST_USERPURCHASE]
as
	declare @STRquery nvarchar(1000)
	set @STRquery='SELECT * FROM USER_PURCHASE ORDER BY USER_ID'
	set @STRquery=@STRquery
	exec sp_executesql @STRquery