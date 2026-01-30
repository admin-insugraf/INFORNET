CREATE procedure [dbo].[INV_FIND_WAREHOUSE]
--declare 
   @almacen char(20)
/*set @almacen='01'*/
as
	declare @STRquery nvarchar(400)
	set @STRquery='select ID,NAME,STATE_ID,PHONE,
		LAST_NUM_IN,LAST_NUM_OUT,ADDR_WHO,TYPE_PART
		from WAREHOUSE where ID=@almacen'
	exec sp_executesql @STRquery,N'@almacen char(20)',@almacen

