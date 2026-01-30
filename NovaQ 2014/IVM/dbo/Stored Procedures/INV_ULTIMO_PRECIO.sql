CREATE procedure [dbo].[INV_ULTIMO_PRECIO]
	@codigo char(20)
as
	declare @STRquery nvarchar(2000)
	declare @estado char(1)
	declare @tipodocu char(2)
	
	set @estado='A'
	set @tipodocu='NI'

	set @STRquery='select A.AVERAGE_COST,B.CURRENCY_TYPE,B.CURRENCY_EXCHANGE 
		from WAREHOUSE_TRANS_LINE as A INNER JOIN WAREHOUSE_TRANS as B on (B.WAREHOUSE_ID = A.WAREHOUSE_ID) 
		AND (B.DOCUMENT_ID=A.DOCUMENT_ID) AND (B.NUMBER_DOCUMENT =A.NUMBER_DOCUMENT) 
		where B.STATUS_GUIA<>@estado and 
        B.DOCUMENT_ID=@tipodocu and A.PART_ID=@codigo and A.AVERAGE_COST<>0 
		and A.STATUS_VALUE=1 AND B.DATE_DOCUMENT=(SELECT max(B.DATE_DOCUMENT) from WAREHOUSE_TRANS_LINE as A 
        inner join WAREHOUSE_TRANS as B ON (B.WAREHOUSE_ID = A.WAREHOUSE_ID) and (B.DOCUMENT_ID = A.DOCUMENT_ID) 
		and (B.NUMBER_DOCUMENT=A.NUMBER_DOCUMENT) where B.STATUS_GUIA<>@estado 
		and A.AVERAGE_COST<>0 and B.DOCUMENT_ID=@tipodocu 
		and A.PART_ID=@codigo AND A.AVERAGE_COST=1)'
	exec sp_executesql @STRquery,N'@codigo char(20),@estado char(1),@tipodocu char(2)',@codigo,@estado,@tipodocu
	