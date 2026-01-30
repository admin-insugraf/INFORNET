CREATE PROC [dbo].[REC_LIST_HELP]
	@COD NVARCHAR(4)
as
	DECLARE @STRcadena NVARCHAR(100)
	SET @STRcadena='select * from master_help
			where type_id=@COD'

	exec SP_EXECUTESQL @STRcadena,N'@COD NVARCHAR(4)',@COD
