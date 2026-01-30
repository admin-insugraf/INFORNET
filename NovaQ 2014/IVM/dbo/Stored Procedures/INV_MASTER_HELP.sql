create procedure [dbo].[INV_MASTER_HELP]
	@tipo_ayuda varchar(3)
as
	declare @STRquery nvarchar(800)	
	set @STRquery='SELECT TYPE_ID,ID,DESCRIPTION,CADUCATE_DAYS,NIVEL,CREATE_DATE,
			HOUR,IS_MINUS,IS_VALUE,IS_FOB
			FROM MASTER_HELP where TYPE_ID=@tipo_ayuda'
	exec sp_executesql @STRquery,N'@tipo_ayuda varchar(3)',@tipo_ayuda
