CREATE procedure [dbo].[INV_TEMP_KARDEX]
	@IDE nvarchar(80)
as
	declare @STRquery nvarchar(1500)
	declare @tabla nvarchar(80)
	if exists(select * from tempdb.dbo.sysobjects where name=@IDE+'KARDEXAUX')
      begin
         set @tabla=N'[tempdb].dbo.'+@IDE+'KARDEXAUX'
         set @STRquery='drop table '+ @tabla
         	exec sp_executesql @STRquery,N'@IDE nvarchar(80)',
						@IDE
      end
	set @tabla=N'[tempdb].dbo.'+@IDE+'KARDEXAUX'
	set @STRquery='create table '+@tabla+'(
		C1 varchar(20),C2 varchar(50),
		C3 smalldatetime,C4 varchar(2) ,
		C5 varchar(50),C6 numeric(16, 6),
		C7 numeric(16, 6),C8 numeric(16, 6),
		C9 numeric(16, 6),C10 varchar(8) ,
		C11 varchar(20),ALMA varchar(2),
		TIPDOCRF varchar(2),NUMDOCRF varchar(10),
		NOMREFE varchar(70),c12 numeric(16, 6) DEFAULT (0.0),
		c13 numeric(16, 6) DEFAULT (0.0),
		c14 numeric(16, 6) DEFAULT (0.0),
		c15 numeric(16, 6) DEFAULT (0.0),
		CATIPMOV varchar(1),DEITEM int)'
	exec sp_executesql @STRquery,N'@IDE nvarchar(80)',@IDE
