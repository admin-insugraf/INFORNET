CREATE procedure [dbo].[INV_RPT_CARRIER]
--DECLARE
	@orden char(1)
as
	declare @STRquery nvarchar(1000)
	declare @criterio nvarchar(1000)
	SET @criterio=N' WHERE 1=1'	

	if @orden='0'
		set @criterio=@criterio + N' order by ID'
	if @orden='1'
		set @criterio=@criterio + N' order by NAME_CARRIER'
	if @orden='2'
		set @criterio=@criterio + N' order by VAT_REGISTRATION'

	set @STRquery='SELECT ID,NAME_CARRIER,ADDR,PHONE,VAT_REGISTRATION,STATUS,CREATE_DATE,NAME,
	                   VAT_REGISTRATION_COMP,ADDR_COMP,PHONE_COMP,NUMBER_REGISTRATION,NUMBER_LICENSE,MODEL_VEH,
                                NUMBER_INSCRIP,NUMBER_DOCUMENT FROM CARRIER'
	set @STRquery=@STRquery + @criterio
	exec sp_executesql @STRquery,N'@orden char(1)',@orden
