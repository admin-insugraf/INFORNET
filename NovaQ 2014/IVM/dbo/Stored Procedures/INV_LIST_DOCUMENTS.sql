CREATE procedure [dbo].[INV_LIST_DOCUMENTS]
	@order char(1)
as
	declare @STRquery nvarchar(80)
	set @STRquery='Select TYPE_ID,NAME,ACCOUNT_ID,SUNAT_ID from DOCUMENT_TYPE '
	if @order='0'
		set @STRquery=@STRquery + ' order by TYPE_ID'
	else
		set @STRquery=@STRquery + ' order by NAME'
	exec sp_executesql @STRquery,N'@order char(1)',@order
