

create procedure [dbo].[INV_INS_MORESMES_FINAL]
	@pc nvarchar(80)
as
	declare @STRquery nvarchar(400)
	declare @tabla nvarchar(80)
	set @tabla='[tempdb].dbo.'+@pc
	set @STRquery='INSERT INTO MONTHLY_SUMMARIZE SELECT * FROM '+ @tabla
	exec sp_executesql @STRquery,N'@pc nvarchar(80),@tabla nvarchar(80)',@pc,@tabla
