
create procedure [dbo].[INV_UPDATE_NOTAS_INGRESO]
as
	declare @STRquery nvarchar(2000)
	declare @docmov char(2)
	declare @tipodoc char(2)
	set @docmov='TD'
	set @tipodoc='NI'
	set @STRquery='update WAREHOUSE_TRANS_LINE
		set AVERAGE_COST =D1.AVERAGE_COST,UNIT_PRICE=D1.UNIT_PRICE
		from (WAREHOUSE_TRANS  as C inner join WAREHOUSE_TRANS_LINE  as D on (C.NUMBER_DOCUMENT=D.NUMBER_DOCUMENT) and 
			(C.DOCUMENT_ID=D.DOCUMENT_ID) and 
			(C.WAREHOUSE_ID=D.WAREHOUSE_ID)) 
		inner join (WAREHOUSE_TRANS  as C1 inner join WAREHOUSE_TRANS_LINE  as D1 on 
			(C1.NUMBER_DOCUMENT=D1.NUMBER_DOCUMENT) and 
			(C1.DOCUMENT_ID=D1.DOCUMENT_ID) and (C1.WAREHOUSE_ID=D1.WAREHOUSE_ID)) on 
			(D.ITEM=D1.ITEM) and (C.NUM_ID_REF=C1.NUMBER_DOCUMENT) and 
			(C.DOC_ID_REF=C1.DOCUMENT_ID) and (C.WAREHOUSE_REF=C1.WAREHOUSE_ID)
		where C.TRANS_ID =@docmov AND C.DOCUMENT_ID =@tipodoc'
	exec sp_executesql @STRquery,N'@docmov char(2),@tipodoc char(2)',
			@docmov,@tipodoc
