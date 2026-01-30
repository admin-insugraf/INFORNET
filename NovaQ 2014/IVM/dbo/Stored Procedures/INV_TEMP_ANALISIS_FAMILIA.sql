create procedure [dbo].[INV_TEMP_ANALISIS_FAMILIA]
--	declare
	@tipo char(1),
	@nombre nvarchar(100)
/*set @tipo='1' 
set @nombre='joseluis'
--*/as
	declare @STRquery nvarchar(2500)
	declare @tabla nvarchar(80)
		if exists(select * from tempdb.dbo.sysobjects where name=@nombre)
			begin
				set @tabla=N'[tempdb].dbo.'+@nombre
				set @STRquery='drop table '+ @tabla
         		exec sp_executesql @STRquery,N'@tipo char(1),@nombre nvarchar(100)',
						@tipo,@nombre
			end
		set @tabla=N'[tempdb].dbo.'+@nombre

	if @tipo='0'
		begin
		set @STRquery='create table ' + @tabla + '(
			FAMILIA varchar(8)NULL,TIPMOV varchar(1) NULL,
			COD_MOV varchar(2)NULL,INGRESOSMN float NULL,
			SALIDASMN float NULL,INGRESOSME float NULL,
			SALIDASME float NULL,INGRESOSCANT float NULL,
			SALIDASCANT float NULL,DESTRANSA varchar(50))'
		exec sp_executesql @STRquery,N'@tipo char(1),@nombre nvarchar(100)',
						@tipo,@nombre
		end

	if @tipo='1'
		begin
		set @STRquery='create table '+@tabla+ '(
				AFAMILIA varchar(8) NULL,CATIPMOV varchar(1) NULL,
				CACODMOV varchar(2) NULL,CATD varchar(2) NULL,
				CANUMDOC varchar(10) NOT NULL,CAFECDOC smalldatetime NULL,
				DECODIGO varchar(20) NULL,DEPRECIO numeric(15, 6) NULL,
				DECANTID numeric(15, 6) NULL,CACODMON varchar(2) NULL,
				CATIPCAM numeric(15, 6) NULL,DEIMPMN numeric(15, 6) NULL,
				DEIMPUS numeric(15, 6) NULL)'
		exec sp_executesql @STRquery,N'@tipo char(1),@nombre nvarchar(100)',
						@tipo,@nombre
		end