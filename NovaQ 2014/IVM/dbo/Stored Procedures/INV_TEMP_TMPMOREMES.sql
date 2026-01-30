
create procedure [dbo].[INV_TEMP_TMPMOREMES]
	@pc nvarchar(80),
	@anterior varchar(6),
	@final varchar(6),
	@inicio varchar(6)
as
	declare @STRquery nvarchar(2000)
	declare @tabla nvarchar(80)
	if exists(select * from tempdb.dbo.sysobjects where name=@pc)
		begin
		   set @tabla='[tempdb].dbo.'+@pc
		   set @STRquery='drop table '+ @tabla
		   exec sp_executesql @STRquery,N'@pc nvarchar(80),@anterior varchar(6),
								@final varchar(6),@inicio varchar(6)',
								@pc,@anterior,@final,@inicio
		end
		set @tabla='[tempdb].dbo.'+@pc
		set @STRquery='select WAREHOUSE_ID,PART_ID,YEAR_MONTH,
		convert(numeric(19,10),AMOUNT_US) as AMOUNT_US,
		convert(numeric(19,10),AMOUNT) as AMOUNT,
		AMOUNT_PREVIOUS_US,AMOUNT_PREVIOUS,LAST_MOVE,QTY_ENTER,QTY_OUT,
		QTY_PREVIOUS,QTY_ACT,
		GROUP_PART_ID,FAMILY_PART_ID,LINE_PART_ID,TYPE,QTY_INITIAL
		into '+@tabla +'
		from MONTHLY_SUMMARIZE 
		where YEAR_MONTH>=@anterior and YEAR_MONTH<=@final'
		exec sp_executesql @STRquery,N'@pc nvarchar(80),@anterior varchar(6),
								@final varchar(6),@inicio varchar(6)',
								@pc,@anterior,@final,@inicio
		--,SMMNANTVAL,SMMNACTVAL,SMUSANTVAL,SMUSACTVAL,SMUSENT,SMMNENT,SMUSSAL,SMMNSAL,SMCUENTA

		set @STRquery='DELETE FROM '+@tabla+' WHERE YEAR_MONTH>=@inicio'
		exec sp_executesql @STRquery,N'@pc nvarchar(80),@anterior varchar(6),
								@final varchar(6),@inicio varchar(6)',
								@pc,@anterior,@final,@inicio
