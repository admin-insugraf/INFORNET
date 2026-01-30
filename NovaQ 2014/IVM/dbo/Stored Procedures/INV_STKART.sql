create procedure [dbo].[INV_STKART]  
--declare  
@alma varchar(2),@arti varchar(20),@cant int OUTPUT  
--set @alma='01'  
--set @arti='lot-02'     
--WITH ENCRYPTION           
as  
SET NOCOUNT  on  
exec ('set quoted_identifier off select * from PART_QTY where WAREHOUSE_ID="'+@alma+'" and PART_ID="'+@arti+'"')  
set @cant=@@ROWCOUNT   