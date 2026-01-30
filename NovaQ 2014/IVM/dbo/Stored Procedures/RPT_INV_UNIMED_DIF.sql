CREATE procedure [dbo].[RPT_INV_UNIMED_DIF]
	@fecini int,
	@fecfin int
as
	declare @STRquery nvarchar(2000)
	set @STRquery='select W.WAREHOUSE_ID,W.DOCUMENT_ID,W.NUMBER_DOCUMENT,
		convert(varchar(10),W.DATE_DOCUMENT,103) as DATE_DOCUMENT,
		W.TRANS_ID,W.CURRENCY_TYPE,WL.ITEM,WL.UNIT_PART,
		P.ID,P.DESCRIPTION,P.UNIT_OF_MEASUREMENT
		from WAREHOUSE_TRANS W
		inner join WAREHOUSE_TRANS_LINE WL
		on W.WAREHOUSE_ID=WL.WAREHOUSE_ID and W.DOCUMENT_ID=WL.DOCUMENT_ID 
		and W.NUMBER_DOCUMENT=WL.NUMBER_DOCUMENT
		inner join PART P on WL.PART_ID=P.ID
		where W.DATE_DOCUMENT between @fecini and @fecfin
		and WL.UNIT_PART<>P.UNIT_OF_MEASUREMENT'
	exec sp_executesql @STRquery,N'@fecini int,@fecfin int',
					@fecini,@fecfin
