
create procedure [dbo].[INV_ULTIMA_FECHA_CIERRE]
as
	declare @STRquery nvarchar(100)
	set @STRquery='select TOP 1 min(DATE_DOCUMENT) from WAREHOUSE_TRANS where STATUS_CLOSE=0'
	exec sp_executesql @STRquery
