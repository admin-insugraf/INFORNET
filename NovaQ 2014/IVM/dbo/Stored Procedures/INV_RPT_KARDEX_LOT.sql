create procedure [dbo].[INV_RPT_KARDEX_LOT]
--declare
	@pc as varchar(80)
/*set @pc='developer03'
--*/as
	declare @tabla nvarchar(100)
	declare @STRquery nvarchar(2000)
	begin
		set @tabla=N'[tempdb].dbo.'+@pc+'KARDEXAUX'
	end

	set @STRquery='select K.c1, K.c2, K.c3, K.c4,K.c5, K.c6, K.c7, K.c8, 
    K.c9, K.c10, K.c11, K.c12,
    K.TIPDOCRF, K.NUMDOCRF, K.NOMREFE,K.CATIPMOV,
    M.DESCRIPTION, M.UNIT_OF_MEASUREMENT
	FROM '+@tabla+' K, PART M
	where 
	K.c1 = M.ID
	ORDER BY K.c1 ASC,K.c3 ASC,K.c2 ASC,K.c5 ASC,K.c11 ASC'
	exec sp_executesql @STRquery,N'@pc nvarchar(80)',@pc