
create procedure [dbo].[INV_DOC_SIN_VALORIZAR]
	@STRvaloriza char(1),
	@STRtipodoc char(2),
	@STRestado char(1),
	@STRafecstock char(1),
	@STRserie char(1),
	@STRlote char(1)		
as
	declare @STRquery nvarchar(2000)
	set @STRquery='select N.PART_ID,A.DESCRIPTION,N.DOCUMENT_ID,N.NUMBER_DOCUMENT,M.VENDOR_NAME,
	M.DOC_ID_REF,M.NUM_ID_REF,M.DATE_DOCUMENT,N.ITEM 
	from ((WAREHOUSE_TRANS_LINE N inner join PART A on N.PART_ID=A.ID) 
	inner join WAREHOUSE_TRANS M on N.DOCUMENT_ID=M.DOCUMENT_ID 
	and N.WAREHOUSE_ID=M.WAREHOUSE_ID and N.NUMBER_DOCUMENT=M.NUMBER_DOCUMENT) 
	inner join TRANSACTION_TYPE T on M.TYPE_TRANS=T.TYPE_ID 
	and M.TRANS_ID=T.MOV_ID 
	where T.IS_VALUED=@STRvaloriza 
	and (N.STATUS_VALUE=0 or N.AVERAGE_COST=0) 
	and M.DOCUMENT_ID=@STRtipodoc and M.STATUS_GUIA<>@STRestado 
	and not (A.IS_STOCKED=@STRafecstock and A.SERIES=@STRserie and A.IS_LOT=@STRlote)'
	exec sp_executesql @STRquery,N'@STRvaloriza char(1),@STRtipodoc char(2),
					@STRestado char(1),@STRafecstock char(1),@STRserie char(1),
					@STRlote char(1)',@STRvaloriza,@STRtipodoc,@STRestado,
					@STRafecstock,@STRserie,@STRlote
