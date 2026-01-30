CREATE procedure [dbo].[RPT_INV_DESPACHOS_PENDIENTES]
	@fecini int,
	@fecfin int,
	@cliini char(20),
	@clifin char(20)
as
	declare @STRquery nvarchar(2000)
	declare @estado char(1)
	set @estado='A'
	set @STRquery='select C.CUSTOMER_ID,convert(varchar(10),C.DOCUMENT_DATE,103) as DOCUMENT_DATE ,
			C.DOCUMENT_ID,C.NUMBER_SERIE,
			C.NUMBER_DOCUMENT,C.CUSTOMER_NAME,
			D.PART_ID,D.PART_DESCRIPTION,M.UNIT_OF_MEASUREMENT,
			D.SHIPPER_QTY,M.WEIGHT
			from RECEIVABLE C inner join RECEIVABLE_LINE D on C.DOCUMENT_ID=D.DOCUMENT_ID 
			and C.NUMBER_SERIE=D.NUMBER_SERIE and C.NUMBER_DOCUMENT=D.NUMBER_DOCUMENT 
			inner join PART M on D.PART_ID=M.ID where D.SHIPPER_QTY<>0.00 
			and C.STATUS<>@estado 
			and C.DOCUMENT_DATE>=@fecini and C.DOCUMENT_DATE<=@fecfin
			and C.CUSTOMER_ID>=@cliini and C.CUSTOMER_ID<=@clifin'
	exec sp_executesql @STRquery,N'@fecini int,@fecfin int,@cliini char(20),@clifin char(20),
				@estado char(1)',@fecini,@fecfin,@cliini,@clifin,@estado
