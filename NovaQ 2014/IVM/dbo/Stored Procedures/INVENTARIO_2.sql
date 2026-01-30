CREATE procedure [dbo].[INVENTARIO_2]      
 --declare      
@YEAR CHAR(4),
@art1 VARCHAR(10),
@ART2 VARCHAR(10),
@PART_TYPE VARCHAR(2)
as      

DECLARE @pc nvarchar(80)
DECLARE @opcion char(1)
DECLARE  @mes1 char(2)
DECLARE  @mes2 char(2)
DECLARE @anyo char(4)      
DECLARE @codini char(20)
DECLARE @codfin char(20)      
DECLARE @tipoart char(4)      
DECLARE @anyomesant char(6)
DECLARE @anyomes char(6)       

SET @pc=''
SET @opcion='1'
SET @mes1='1'
SET @mes2='12'
SET @anyo=@YEAR
SET @anyomesant=''
SET @anyomes=''

 declare @STRquery nvarchar(2500)      
 declare @tabla nvarchar(80)      
 declare @staanul char(1),@guiasal char(2),@guiafac char(2)      
 declare @stafac char(1),@isno char(1),@texto char(5)      
 declare @filtro nvarchar(200)      
      
      
 if @opcion='1' --consulta      
   begin      
  set @staanul='A'        
  set @guiasal='GS'      
  set @guiafac='GF'       
  set @stafac='F'      
  set @isno='N'      
  set @texto='TEXTO'      
      
  if len(@PART_TYPE)>0      
     set @filtro= N' AND M.TYPE_PART='''+@PART_TYPE+''' order by A.PART_ID,B.DATE_DOCUMENT,B.TYPE_TRANS,B.TRANS_ID,B.WAREHOUSE_ID,      
        B.DOCUMENT_ID,B.NUMBER_DOCUMENT,A.ITEM'      
  else      
   set @filtro= N' order by A.PART_ID,B.DATE_DOCUMENT,B.TYPE_TRANS,B.TRANS_ID,B.WAREHOUSE_ID,      
        B.DOCUMENT_ID,B.NUMBER_DOCUMENT,A.ITEM'      
      
 

set @STRquery='select A.*,B.* from       
   WAREHOUSE_TRANS B inner join       
   (WAREHOUSE_TRANS_LINE A left join PART M on A.PART_ID=M.ID ) on      
   B.WAREHOUSE_ID = A.WAREHOUSE_ID AND B.DOCUMENT_ID=A.DOCUMENT_ID AND B.NUMBER_DOCUMENT=A.NUMBER_DOCUMENT      
   where MONTH(B.DATE_DOCUMENT) >=@mes1 AND MONTH(B.DATE_DOCUMENT) <=@mes2      
   and year(B.DATE_DOCUMENT) =@anyo and B.STATUS_GUIA<>@staanul      
   and not (B.DOCUMENT_ID=@guiasal and B.TRANS_ID=@guiafac and B.STATUS_GUIA=@stafac)      
   and not (M.IS_STOCKED=@isno and M.SERIES=@isno and M.IS_LOT=@isno)       
   and (A.PART_ID>='''+@ART1+''' and A.PART_ID<='''+@ART2+''')       
   and (A.PART_ID<>@texto)' + @filtro       
  exec sp_executesql @STRquery,N'@opcion char(1),      
    @mes1 char(10),@mes2 char(10),@anyo char(4),@codini char(20),@codfin char(20),@tipoart char(4),      
    @staanul char(1),@guiasal char(2),@guiafac char(2),@stafac char(1),      
    @isno char(1),@texto char(5)',      
    @opcion,@mes1,@mes2,@anyo,@codini,@codfin,@tipoart,      
    @staanul,@guiasal,@guiafac,@stafac,@isno,@texto      
   end      
      
