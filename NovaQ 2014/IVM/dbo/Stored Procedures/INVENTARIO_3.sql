CREATE procedure [dbo].[INVENTARIO_3]      
 --declare      
@YEAR_ACTUAL CHAR(4),
@YEAR_ANTERIOR CHAR(4),
@ART1 VARCHAR(15),
@ART2 VARCHAR(15)
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
DECLARE @YEAR_ACTUAL_PRINCIPAL CHAR(6)       
DECLARE @YEAR_ANTERIOR_PRINCIPAL CHAR(6)       

SET @YEAR_ACTUAL_PRINCIPAL=@YEAR_ACTUAL+'12'
SET @YEAR_ANTERIOR_PRINCIPAL=@YEAR_ANTERIOR+'12'

SET @pc=''
SET @opcion='2'
SET @mes=''
SET @anyo=''
SET @tipoart=''
SET @anyomesant=@YEAR_ANTERIOR_PRINCIPAL
SET @anyomes=@YEAR_ACTUAL_PRINCIPAL

 declare @STRquery nvarchar(2500)      
 declare @tabla nvarchar(80)      
 declare @staanul char(1),@guiasal char(2),@guiafac char(2)      
 declare @stafac char(1),@isno char(1),@texto char(5)      
 declare @filtro nvarchar(200)      
      

      
 if @opcion='2' --consulta agrupada moresmes      
   begin      
  set @STRquery='select PART_ID,YEAR_MONTH,AMOUNT,AMOUNT_US,      
   sum(QTY_INITIAL) as QTY_INITIAL,      
   sum(QTY_ENTER) as QTY_ENTER,      
   sum(QTY_OUT) as  QTY_OUT       
   from MONTHLY_SUMMARIZE where       
   YEAR_MONTH >=@anyomesant      
   AND YEAR_MONTH <=@anyomes      
   AND (PART_ID>='''+@ART1+''' AND PART_ID<='''+@ART2+''')       
   group by PART_ID,YEAR_MONTH,AMOUNT,AMOUNT_US order by YEAR_MONTH'      
  exec sp_executesql @STRquery,N'@opcion char(1),      
    @anyomesant char(6),@anyomes char(6),@codini char(20),@codfin char(20)',      
    @opcion,@anyomesant,@anyomes,@codini,@codfin      
      end      
      
 