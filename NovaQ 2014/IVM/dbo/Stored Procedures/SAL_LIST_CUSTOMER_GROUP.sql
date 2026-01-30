CREATE procedure [dbo].[SAL_LIST_CUSTOMER_GROUP]
	@todos char(1),@group1 char(11),@group2 char(11)
as
	declare @STRquery nvarchar(1500)
	declare @filtro nvarchar(1500)
	
if @todos='1'
	set @filtro=N' WHERE G.CUST_ID = M.ID AND G.GROUP_ID = C.ID ORDER BY G.GROUP_ID ASC'
if @todos='0'
	set @filtro=N' WHERE G.CUST_ID = M.ID AND G.GROUP_ID = C.ID AND GROUP_ID BETWEEN @group1 AND @group2 ORDER BY G.GROUP_ID ASC '

	set @STRquery='SELECT G.GROUP_ID,M.ID, M.NAME, M.ADDR, M.PHONE, M.VAT_REGISTRATION,C.ID AS ID_CUST_GROUP, C.NAME AS NAME_GROUP
			FROM RELATION_CUST_GROUP G,CUSTOMER M,CUSTOMER_GROUP C'
	set @STRquery=@STRquery + @filtro
	exec sp_executesql @STRquery,N'@todos char(1),@group1 char(2),@group2 char(2)',@todos,@group1,@group2


