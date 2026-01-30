CREATE procedure [dbo].[SAL_LIST_DOCUMENTOS_FECHA_DET]
	(
	  @fecha_ini DATE,
	  @fecha_fin DATE
	)
AS
select r.DOCUMENT_ID,r.NUMBER_SERIE,r.NUMBER_DOCUMENT,
	   rl.ITEM,rl.PART_ID,rl.PART_DESCRIPTION,
	   rl.QTY,rl.PRICE_SALES,rl.PRICE_ORI,
	   rl.AMOUNT_TAX,rl.TAX_PERCENT,rl.AMOUNT_US,rl.AMOUNT,
	   rl.UNIT,(r.DOCUMENT_ID + r.NUMBER_SERIE + r.NUMBER_DOCUMENT) ID_DET
from receivable r
inner join RECEIVABLE_LINE rl
	on r.DOCUMENT_ID=rl.DOCUMENT_ID
	and r.NUMBER_SERIE=rl.NUMBER_SERIE
	and r.NUMBER_DOCUMENT=rl.NUMBER_DOCUMENT
where
	convert(varchar(10),R.CREATE_DATE,103) between @fecha_ini and @fecha_fin
order by r.CREATE_DATE