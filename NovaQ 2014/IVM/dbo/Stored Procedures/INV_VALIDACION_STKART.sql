
create procedure [dbo].[INV_VALIDACION_STKART]
	@STRafecstock char(1),
	@STRserie char(1),
	@STRlote char(1)
as
	declare @STRquery nvarchar(2000)
	set @STRquery='insert into PART_QTY(WAREHOUSE_ID,PART_ID,LAST_RECEIVED_DATE) 
			(select distinct D.WAREHOUSE_ID as STALMA,D.PART_ID as STCODIGO,
			min(C.DATE_DOCUMENT) as STKFECULT from WAREHOUSE_TRANS C 
			inner join ((WAREHOUSE_TRANS_LINE D left join PART_QTY S 
			on D.WAREHOUSE_ID=S.WAREHOUSE_ID and D.PART_ID=S.PART_ID) 
			inner join PART M on D.PART_ID=M.ID) 
			on C.WAREHOUSE_ID=D.WAREHOUSE_ID and C.DOCUMENT_ID=D.DOCUMENT_ID 
			and C.NUMBER_DOCUMENT=D.NUMBER_DOCUMENT 
			where S.WAREHOUSE_ID is null 
			and not (M.IS_STOCKED=@STRafecstock and M.SERIES=@STRserie and M.IS_LOT=@STRlote) 
			group by D.WAREHOUSE_ID,S.PART_ID,D.PART_ID)'
	exec sp_executesql @STRquery,N'@STRafecstock char(1),@STRserie char(1),@STRlote char(1)',
								@STRafecstock,@STRserie,@STRlote

