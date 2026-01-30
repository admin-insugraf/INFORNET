
--Creado  05/06/2007
--Mantenimiento de Moneda de Importacion
CREATE   procedure [dbo].[PUR_MANT_CURRENCYIMPORTTYPE]
--declare   
@codigo varchar(3), @nombre varchar(20), @codpais varchar(3),@opcion char(1)
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
    Set @STRquery='INSERT INTO CURRENCY_IMPORT_TYPE (CURRTIPIMP_ID, DESCRIPTION, COUNTRY_ID  )    
                  VALUES (@codigo,@nombre,@codpais)'  
  if @OPCION='2'  --Modificar  
     Set @STRquery='UPDATE CURRENCY_IMPORT_TYPE SET DESCRIPTION=@nombre,COUNTRY_ID=@codpais  WHERE CURRTIPIMP_ID=@codigo'  

  if @OPCION='3'  --Eliminar
     Set @STRquery='DELETE FROM CURRENCY_IMPORT_TYPE WHERE CURRTIPIMP_ID=@codigo'  
  
Begin Tran Mant_CurrencyImportType
   Set @Errores=0     --Para insertar
          exec sp_executesql @STRquery,N'@codigo varchar(3), @nombre varchar(20), @codpais varchar(3),@opcion char(1) ',   
                  @codigo, @nombre,@codpais,@opcion     
          set @Errores = @@Error  
 
if @errores<>0 
   BEGIN  
         ROLLBACK TRAN Mant_CurrencyImportType
    END   
else  
   BEGIN  
         COMMIT TRAN Mant_CurrencyImportType
   END