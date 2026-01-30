
create procedure [dbo].[INV_GET_SALDO_CANTIDAD]
	@pc nvarchar(80)
as
	declare @STRquery nvarchar(500)
	declare @tabla nvarchar(80)
	set @tabla='[tempdb].dbo.'+@pc
	set @STRquery='Select PART_ID,YEAR_MONTH,AMOUNT_US,AMOUNT,
		sum(QTY_INITIAL) as QTY_INITIAL,sum(QTY_ENTER) AS QTY_ENTER,
		sum(QTY_OUT) AS QTY_OUT 
		from '+ @tabla + ' group by PART_ID,YEAR_MONTH,AMOUNT_US,AMOUNT 
		order by PART_ID,YEAR_MONTH DESC'
	exec sp_executesql @STRquery,N'@pc nvarchar(80)',@pc
