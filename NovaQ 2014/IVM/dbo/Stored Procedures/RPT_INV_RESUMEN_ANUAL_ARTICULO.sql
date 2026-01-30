create procedure [dbo].[RPT_INV_RESUMEN_ANUAL_ARTICULO]
	@pc nvarchar(80)
as
	declare @STRquery nvarchar(1500)
	declare @tabla nvarchar(80)
	set @tabla=N'[tempdb].dbo.'+@pc
	set @STRquery='select MES,INGRESO,SALIDA,SALDO,CPROM FROM '+@tabla
	exec sp_executesql @STRquery,N'@pc nvarchar(80)',@pc