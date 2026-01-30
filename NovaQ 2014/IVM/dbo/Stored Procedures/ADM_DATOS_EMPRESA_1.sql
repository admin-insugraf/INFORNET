create procedure [dbo].[ADM_DATOS_EMPRESA]
as
select C.ID,C.NAME,C.ADDR,c.VAT_REGISTRATION
from 
COMPANY C