CREATE procedure [dbo].[INVENTARIO_5]      
@ART1 VARCHAR(15),
@ART2 VARCHAR(15),
@TYPE_ART VARCHAR(2)
as      

DECLARE @pc nvarchar(80)
DECLARE @opcion char(1)
DECLARE  @mes char(2)
DECLARE  @mes1 char(2)
DECLARE  @mes2 char(2)
DECLARE @anyo char(4)      
DECLARE @codini char(20)
DECLARE @codfin char(20)      
DECLARE @tipoart char(4)      
DECLARE @anyomesant char(6)
DECLARE @anyomes char(6)       

SET @pc=''
SET @opcion='4'
SET @mes=''
SET @anyo=''
SET @anyomesant=''
SET @anyomes=''

 declare @STRquery nvarchar(2500)      
 declare @tabla nvarchar(80)      
 declare @staanul char(1),@guiasal char(2),@guiafac char(2)      
 declare @stafac char(1),@isno char(1),@texto char(5)      
 declare @filtro nvarchar(200)      
      
  if @opcion='4' --Consulta stock y partes      
  begin      
   if len(@tipoart)>0      
      set @filtro=N' AND B.TYPE_PART='''+@TYPE_ART+''''      
   else      
      set @filtro=N''      
         
   set @STRquery='select distinct(A.PART_ID) from PART_QTY A       
    inner join PART B on A.PART_ID=B.ID       
    where (A.PART_ID>='''+@ART1+''' and A.PART_ID<='''+@ART2+''')' + @filtro      
  exec sp_executesql @STRquery,N'@opcion char(1),      
   @codini char(20),@codfin char(20),@tipoart char(4)',      
   @opcion,@codini,@codfin,@tipoart      
  end      
      
 