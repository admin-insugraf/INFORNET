CREATE procedure [dbo].[INV_TEMP_TMPMORESMESAUX]
	@pc nvarchar(80),
	@pc2 nvarchar(80)
as
	declare @STRquery nvarchar(500)
	declare @tabla nvarchar(80)
	declare @tabla2 nvarchar(80)

	if exists(select * from tempdb.dbo.sysobjects where name=@pc2)
		begin
		   set @tabla2='[tempdb].dbo.'+@pc2
		   set @STRquery='drop table '+ @tabla2
		   exec sp_executesql @STRquery,N'@pc nvarchar(80),@pc2 nvarchar(80),
							@tabla nvarchar(80),@tabla2 nvarchar(80)',
						@pc,@pc2,@tabla,@tabla2
		end

	set @tabla='[tempdb].dbo.'+@pc
	set @tabla2='[tempdb].dbo.'+@pc2
	set @STRquery='select WAREHOUSE_ID as SMALMA,PART_ID as SMCODIGO,
			ANOMES as SMMESPRO,convert(numeric(19,10),0.0) as SMUSPREUNI,
			convert(numeric(19,10),0.0) as SMMNPREUNI,
			sum(convert(numeric(15,6),entr)) as SMCANENT, 
			sum(convert(numeric(15,6),sali)) as SMCANSAL,
			convert(numeric(15,6),0.0) as SMSALDOINI,
			max(ID) as IDX into '+@tabla2+' from '+@tabla+ ' group by WAREHOUSE_ID,PART_ID,ANOMES'
	exec sp_executesql @STRquery,N'@pc nvarchar(80),@pc2 nvarchar(80),
							@tabla nvarchar(80),@tabla2 nvarchar(80)',
						@pc,@pc2,@tabla,@tabla2
