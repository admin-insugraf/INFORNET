CREATE procedure [dbo].[INV_RPT_VENDOR]
--declare
	@orden char(1)
as
/*set @orden=0*/
	declare @STRquery nvarchar(1000)
	declare @criterio nvarchar(1000)
	SET @criterio=N' WHERE 1=1'	

	if @orden='0'
		set @criterio=@criterio + N' order by V.ID'
	if @orden='1'
		set @criterio=@criterio + N' order by V.NAME'
	if @orden='2'
		set @criterio=@criterio + N' order by V.VAT_REGISTRATION'

	set @STRquery='SELECT V.ID,V.NAME,V.ADDR,V.STATE_ID,C.NAME AS NAMECOUNTRY,V.PHONE,V.FAX_NUMBER,V.TYPE_VENDOR_ID,V.CONTACT,
				V.CONTACT_POSITION,V.CONTACT_PHONE,V.CREATE_DATE,V.CREATE_USER,V.VAT_REGISTRATION,
				V.STATUS,V.MODIFY_DATE,V.COMMENT,V.EMAIL 
				FROM VENDOR V LEFT JOIN COUNTRY C ON V.COUNTRY_ID=C.COUNTRY_ID'
	set @STRquery=@STRquery + @criterio
	exec sp_executesql @STRquery,N'@orden char(1)',@orden