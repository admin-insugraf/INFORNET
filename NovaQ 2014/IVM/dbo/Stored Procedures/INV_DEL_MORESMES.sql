

create procedure [dbo].[INV_DEL_MORESMES]
	@anomesant char(6),
	@anomesfin char(6)
as
	declare @STRquery nvarchar(500)
	set @STRquery='delete from MONTHLY_SUMMARIZE 
		where YEAR_MONTH>=@anomesant and YEAR_MONTH<=@anomesfin'
	exec sp_executesql @STRquery,N'@anomesant char(6),@anomesfin char(6)',@anomesant,@anomesfin
