CREATE procedure [dbo].[SAL_LIST_CUSTOMER_DIST]
	@todos char(1),@dis1 char(2),@dis2 char(2)
as
	declare @STRquery nvarchar(1500)
	declare @filtro nvarchar(1500)
	
if @todos='1'
	set @filtro=N' WHERE M.STATE_ID = T.ID AND TYPE_ID="13" ORDER BY M.STATE_ID ASC,M.ID ASC'
if @todos='0'
	set @filtro=N' WHERE M.STATE_ID = T.ID and TYPE_ID="13" AND M.STATE_ID BETWEEN @dis1 AND @dis2 ORDER BY M.STATE_ID ASC,M.ID ASC'

	set @STRquery=' SET QUOTED_IDENTIFIER OFF SELECT M.ID, M.NAME, M.ADDR, M.PHONE, M.VAT_REGISTRATION, M.STATE_ID,
		       T.TYPE_ID, T.ID as ID_MASTER_HELP, T.DESCRIPTION FROM CUSTOMER M,MASTER_HELP T '
	set @STRquery=@STRquery + @filtro
	exec sp_executesql @STRquery,N'@todos char(1),@dis1 char(2),@dis2 char(2)',@todos,@dis1,@dis2


