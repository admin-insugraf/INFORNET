create procedure [dbo].[INV_RPT_LIST_LINES]
	@codfam nvarchar(20)
as
	declare @STRquery nvarchar(1500)
	set @STRquery='select FAMILY_ID,ID,NAME
		from LINES where FAMILY_ID=@codfam'
	exec sp_executesql @STRquery,N'@codfam nvarchar(20)',@codfam
