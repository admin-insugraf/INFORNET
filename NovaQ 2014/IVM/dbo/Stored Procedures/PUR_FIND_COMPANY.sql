CREATE  procedure [dbo].[PUR_FIND_COMPANY]
		@codigo char(30)
	
as
/*DECLARE @CODIGO VARCHAR(30)
set @codigo='DEMO'
*/
	declare @STRquery nvarchar(200)
	set @STRquery='select *  from COMPANY where NAME=@CODIGO' 
	exec sp_executesql @STRquery,N'@codigo char(30)',@codigo

