CREATE procedure [dbo].[INV_INS_TMPMOREMES]
	@mores nvarchar(80),
	@moresaux nvarchar(80)
as
	declare @STRquery nvarchar(500)
	declare @tabla nvarchar(80)
	declare @tabla2 nvarchar(80)

	set @tabla='[tempdb].dbo.'+@mores
	set @tabla2='[tempdb].dbo.'+@moresaux
	set @STRquery='insert into '+@tabla+ '(WAREHOUSE_ID,PART_ID,YEAR_MONTH,AMOUNT_US,
					AMOUNT,QTY_ENTER,QTY_OUT,QTY_INITIAL) 
					SELECT SMALMA,SMCODIGO,SMMESPRO,
					SMUSPREUNI,SMMNPREUNI,SMCANENT,SMCANSAL,SMSALDOINI from '+ @tabla2
	exec sp_executesql @STRquery,N'@mores nvarchar(80),@moresaux nvarchar(80),
					@tabla nvarchar(80),@tabla2 nvarchar(80)',
					@mores,@moresaux,@tabla,@tabla2
