CREATE procedure [dbo].[SAL_HLP_CARRIER]
as
select ID,NAME_CARRIER
from CARRIER
order by ID
