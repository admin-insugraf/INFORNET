CREATE procedure [dbo].[INV_FIND_VENDOR]
	@codigo char(11)
as
	declare @STRquery nvarchar(1000)
	declare @criterio nvarchar(1000)
	SET @criterio=N' WHERE 1=1'	

	if len(@codigo)>0
		set @criterio=@criterio + N' and V.ID=@codigo'

	set @STRquery='SELECT V.ID,V.NAME,V.ADDR,V.STATE_ID,V.COUNTRY_ID,V.PHONE,V.FAX_NUMBER,V.TYPE_VENDOR_ID,V.CONTACT,
				V.CONTACT_POSITION,V.CONTACT_PHONE,V.CREATE_DATE,V.CREATE_USER,V.VAT_REGISTRATION,
				V.STATUS,V.MODIFY_DATE,V.COMMENT,V.EMAIL
				FROM VENDOR V'
	set @STRquery=@STRquery + @criterio
	exec sp_executesql @STRquery,N'@codigo char(11)',@codigo