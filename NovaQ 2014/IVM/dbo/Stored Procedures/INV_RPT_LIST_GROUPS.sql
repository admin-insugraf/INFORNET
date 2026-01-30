create procedure [dbo].[INV_RPT_LIST_GROUPS]
	@codfam nvarchar(20),
	@codlin nvarchar(20)
as
	declare @STRquery nvarchar(1500)
	set @STRquery='select FAMILY_ID,LINE_ID,ID,NAME
		from GROUPS where FAMILY_ID=@codfam and LINE_ID=@codlin'
	exec sp_executesql @STRquery,N'@codfam nvarchar(20),@codlin nvarchar(20)',
					@codfam,@codlin
