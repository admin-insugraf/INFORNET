CREATE procedure [dbo].[INV_CURRENCY_EXCHANGE]
	@anyo char(4),@mes char(2)
as
	declare @STRquery nvarchar(1000)
	set @STRquery='select CURRENCY_ID,convert(varchar(10),CURRENCY_DATE,103) as CURRENCY_DATE,
				BUY_RATE,BUY_EQUIV,SELL_RATE,SELL_EQUIV 
				from CURRENCY_EXCHANGE 
				where datepart(year,CURRENCY_DATE)=@anyo 
				and datepart(month,CURRENCY_DATE)=@mes'
	exec sp_executesql @STRquery,N'@anyo char(4),@mes char(2)',@anyo,@mes
