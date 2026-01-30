create procedure [dbo].[INV_STKLOTE]  
--declare  
@alma varchar(2),@arti varchar(20),@lote varchar(20),@cant int OUTPUT  
--set @alma='01'  
--set @arti='lot-02'  
--set @lote='01'  
as  
SET NOCOUNT  on  
exec ('set quoted_identifier off select * from LOT where WHO_ID="'+@alma+'" and PART_ID="'+@arti+'" and LOT_ID="'+@lote+'"')  
set @cant=@@ROWCOUNT   
