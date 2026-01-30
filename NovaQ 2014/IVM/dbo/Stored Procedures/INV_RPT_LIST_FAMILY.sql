create procedure [dbo].[INV_RPT_LIST_FAMILY]
as
	declare @STRquery nvarchar(1500)
	set @STRquery='select ID,NAME,ACCOUNT,ACCOUNT_DR,ACCOUNT_CR,ACCOUNT_PURCHASE,
	ACCOUNT_EXISTENCE,ACCOUNT_DR_AC,ACCOUNT_CR_AC
	from FAMILY'
	exec sp_executesql @STRquery
