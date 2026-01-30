create procedure [dbo].[INV_EXISTEMORESMESLOT]  
	@mespro varchar(20),@cant int OUTPUT  
as  
set nocount on  
exec ('set quoted_identifier off select * from MONTHLY_SUMMARIZE_LOT  where YEAR_MONTH="'+@mespro+'" ')  
set @cant=@@ROWCOUNT   
