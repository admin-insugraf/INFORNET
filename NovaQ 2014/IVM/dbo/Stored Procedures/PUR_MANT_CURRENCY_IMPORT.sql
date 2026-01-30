--Creado  07/06/2007
--Mantenimiento de Moneda de Importacion
CREATE   procedure [dbo].[PUR_MANT_CURRENCY_IMPORT]
--declare   
@codigo varchar(3), @mes varchar(2), @anno varchar(4),@equivalente numeric (15,6),@opcion char(1)
/* 
SET @codigo='02'  
SET @nombre=''  
SET @codpais=''  
SET @OPCION='3'
*/
as  
declare @STRquery nvarchar(4000)
declare @Errores int

  if @OPCION='1' --Insertar  
    Set @STRquery='INSERT INTO CURRENCY_IMPORT (CURRTIPIMP_ID, CURRENCY_MONTH,CURRENCY_YEAR,EQUIVALENCE)    
                  VALUES (@codigo,@mes,@anno,@equivalente)'  
  if @OPCION='2'  --Modificar  
     Set @STRquery='UPDATE CURRENCY_IMPORT  SET CURRENCY_MONTH=@mes,CURRENCY_YEAR=@anno,  EQUIVALENCE= @equivalente 
                                 WHERE CURRTIPIMP_ID=@codigo and CURRENCY_MONTH=@mes and CURRENCY_YEAR=@anno'  
  if @OPCION='3'  --Eliminar
     Set @STRquery='DELETE FROM CURRENCY_IMPORT WHERE CURRTIPIMP_ID=@codigo and CURRENCY_MONTH=@mes and CURRENCY_YEAR=@anno '  
  
Begin Tran Mant_CurrencyImport
   Set @Errores=0     --Para insertar
          exec sp_executesql @STRquery,N'@codigo varchar(3), @mes varchar(2), @anno varchar(4),@equivalente numeric(15,6),@opcion char(1) ',   
                  @codigo, @mes,@anno,@equivalente,@opcion     
          set @Errores = @@Error  
 
if @errores<>0 
   BEGIN  
         ROLLBACK TRAN Mant_CurrencyImport
    END   
else  
   BEGIN  
         COMMIT TRAN Mant_CurrencyImport
   END