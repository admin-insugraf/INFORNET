
create procedure [dbo].[INV_GET_MORESMESINGSAL]
	@pc nvarchar(80)
as
	declare @STRquery nvarchar(500)
	declare @tabla nvarchar(80)
	set @tabla='[tempdb].dbo.'+@pc
	set @STRquery='select * from '+@tabla+' order by PART_ID,DATE_DOCUMENT,TYPE_TRANS,TRANS_ID,DOCUMENT_ID,NUMBER_DOCUMENT,ITEM'
	exec sp_executesql @STRquery,N'@pc nvarchar(80)',@pc
