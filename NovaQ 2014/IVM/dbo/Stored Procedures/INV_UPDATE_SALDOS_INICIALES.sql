CREATE procedure [dbo].[INV_UPDATE_SALDOS_INICIALES]
	@moresaux nvarchar(80),
	@mesingsal nvarchar(80)
as
	declare @STRquery nvarchar(500)
	declare @tabla nvarchar(80)
	declare @tabla2 nvarchar(80)

	set @tabla='[tempdb].dbo.'+@moresaux
	set @tabla2='[tempdb].dbo.'+@mesingsal
	set @STRquery='UPDATE '+@tabla+ ' SET SMSALDOINI = B.SALDOINICIAL  
			FROM '+@tabla+ ' AS A 
			INNER JOIN '+@tabla2+ ' AS B ON 
			(A.IDX=B.ID) AND (A.SMMESPRO=B.ANOMES) 
			AND (A.SMCODIGO=B.PART_ID) 
			AND (A.SMALMA=B.WAREHOUSE_ID) WHERE A.IDX=B.ID'
	exec sp_executesql @STRquery,N'@moresaux nvarchar(80),@mesingsal nvarchar(80),
				@tabla nvarchar(80),@tabla2 nvarchar(80)',@moresaux,@mesingsal,
				@tabla,@tabla2
	set @STRquery='alter table '+@tabla+ ' drop column IDX'
	exec sp_executesql @STRquery,N'@moresaux nvarchar(80),@mesingsal nvarchar(80),
				@tabla nvarchar(80),@tabla2 nvarchar(80)',@moresaux,@mesingsal,
				@tabla,@tabla2
