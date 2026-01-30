
--Creado  05/06/2007
--Mantenimiento de partidas arancelarias
CREATE   procedure [dbo].[PUR_MANT_CUSTOMS_TARIFF]
--declare   
@codigo varchar(14), @nombre varchar(80), @arancel numeric(15,6),@opcion char(1)
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
    Set @STRquery='INSERT INTO CUSTOMS_TARIFF (CUSTOMSTARIFF_ID, NAME, CUSTOMS_MEASURE )    
                  VALUES (@codigo,@nombre,@arancel)'  
  if @OPCION='2'  --Modificar  
     Set @STRquery='UPDATE CUSTOMS_TARIFF SET NAME=@nombre,CUSTOMS_MEASURE=@arancel  WHERE CUSTOMSTARIFF_ID=@codigo'  

  if @OPCION='3'  --Eliminar
     Set @STRquery='DELETE FROM CUSTOMS_TARIFF WHERE CUSTOMSTARIFF_ID=@codigo'  
  
Begin Tran Mant_CUSTOMS_TARIFF
   Set @Errores=0     --Para insertar
          exec sp_executesql @STRquery,N'@codigo varchar(14), @nombre varchar(80), @arancel numeric(15,6),@opcion char(1) ',   
                  @codigo, @nombre,@arancel,@opcion     
          set @Errores = @@Error  
 
if @errores<>0 
   BEGIN  
         ROLLBACK TRAN Mant_CUSTOMS_TARIFF
    END   
else  
   BEGIN  
         COMMIT TRAN Mant_CUSTOMS_TARIFF
   END