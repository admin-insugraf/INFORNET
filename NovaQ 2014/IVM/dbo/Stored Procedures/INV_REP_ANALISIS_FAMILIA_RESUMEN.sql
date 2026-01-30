create procedure [dbo].[INV_REP_ANALISIS_FAMILIA_RESUMEN]
--	declare
	@pc nvarchar(80)
/*set @pc='developer03'
--*/as
	declare @tabla nvarchar(100)
	declare @tabla1 nvarchar(100)
	declare @STRquery nvarchar(2000)
	begin
		set @tabla=N'[tempdb].dbo.'+@pc+'RPTANALISFAM'
		set @tabla1=N'[tempdb].dbo.'+@pc+'SALINIXFAM'
	end
	set @STRquery='select F.ID,F.NAME,A.FAMILIA,A.TIPMOV,A.COD_MOV,A.INGRESOSMN,
			A.SALIDASMN,A.INGRESOSME,A.SALIDASME,
			A.INGRESOSCANT,A.SALIDASCANT,A.DESTRANSA,
			S.SALDOCANT,S.SALDOMN,S.SALDOME
			from FAMILY F
				inner join '+@tabla+ ' A
					on F.ID=A.FAMILIA
				left join '+@tabla1+ ' S
					on A.FAMILIA=S.FAMILY and A.TIPMOV=S.TYPE_TRANS and A.COD_MOV=S.TRANS_ID'
	exec sp_executesql @STRquery,N'@pc nvarchar(80)',@pc
	
