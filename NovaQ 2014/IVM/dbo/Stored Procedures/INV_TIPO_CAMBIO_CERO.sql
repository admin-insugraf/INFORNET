



--procedimientos para revalorizacion automatica
create procedure [dbo].[INV_TIPO_CAMBIO_CERO]
	@STRvaloriza char(1),
	@STRtipomov char(1)
as
	declare @STRquery nvarchar(2000)
	set @STRquery='select * from 
	(WAREHOUSE_TRANS M inner join WAREHOUSE_TRANS_LINE N on M.WAREHOUSE_ID=N.WAREHOUSE_ID 
	and M.DOCUMENT_ID=N.DOCUMENT_ID and M.NUMBER_DOCUMENT=N.NUMBER_DOCUMENT) 
	inner join TRANSACTION_TYPE T on M.TYPE_TRANS=T.TYPE_ID 
	and M.TRANS_ID=T.MOV_ID 
	where T.IS_VALUED=@STRvaloriza and N.STATUS_VALUE=1 
	and M.TYPE_TRANS=@STRtipomov and M.CURRENCY_EXCHANGE=0'
	exec sp_executesql @STRquery,N'@STRvaloriza char(1),@STRtipomov char(1)',
						@STRvaloriza,@STRtipomov
