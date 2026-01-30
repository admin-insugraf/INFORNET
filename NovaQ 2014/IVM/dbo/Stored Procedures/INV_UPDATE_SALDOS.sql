CREATE procedure [dbo].[INV_UPDATE_SALDOS]
	@moresaux nvarchar(80),
	@mesingsal nvarchar(80),
	@autonum nvarchar(80)	
as
	declare @STRquery nvarchar(500)
	declare @tabla nvarchar(80)
	declare @tabla2 nvarchar(80)
	declare @tabla3 nvarchar(80)

	set @tabla='[tempdb].dbo.'+@moresaux
	set @tabla2='[tempdb].dbo.'+@mesingsal
	set @tabla3='[tempdb].dbo.'+@autonum
	set @STRquery='UPDATE '+@tabla+ ' SET SMMNPREUNI=CONVERT(NUMERIC(19,10),B.PRECIOPROMEDIO),
			SMUSPREUNI=CONVERT(NUMERIC(19,10),B.PRECIOPROMEDIOUSS) 
			FROM '+@tabla+ ' AS A 
			INNER JOIN ('+@tabla2+ ' AS B 
			INNER JOIN '+@tabla3+ ' AS C ON B.ID=C.IDX) ON 
			(A.SMCODIGO=B.PART_ID) AND (A.SMMESPRO=B.ANOMES)'
	exec sp_executesql @STRquery,N'@moresaux nvarchar(80),@mesingsal nvarchar(80),
					@autonum nvarchar(80),@tabla nvarchar(80),@tabla2 nvarchar(80),
					@tabla3 nvarchar(80)',@moresaux,@mesingsal,@autonum,@tabla,
					@tabla2,@tabla3
