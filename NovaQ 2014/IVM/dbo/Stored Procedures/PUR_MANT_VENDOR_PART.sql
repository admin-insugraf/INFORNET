--Creado  07/06/2007
--Mantenimiento de Relacion Clase proveedor
CREATE   procedure [dbo].[PUR_MANT_VENDOR_PART]
--declare   
@codigo varchar(20), @codproveedor varchar(11), @opcion char(1)
/* 
SET @codigo='02'  
SET @codproveedor='02'  
SET @OPCION='3'
*/
as  
declare @STRquery nvarchar(4000)
declare @Errores int

  if @OPCION='1'  --Insertar
     Set @STRquery='INSERT INTO VENDOR_PART(VENDOR_ID, PART_ID) VALUES(@codproveedor, @codigo)'

  if @OPCION='2'  --Eliminar
     Set @STRquery='DELETE FROM VENDOR_PART WHERE VENDOR_ID = @codproveedor AND PART_ID= @codigo'

  
Begin Tran Mant_Vendor_Part
   Set @Errores=0     --Para insertar
          exec sp_executesql @STRquery,N'@codigo varchar(20), @codproveedor varchar(11),@opcion char(1) ',   
          @codigo, @codproveedor,@opcion 
          set @Errores = @@Error   
if @errores<>0 
   BEGIN  
         ROLLBACK TRAN Mant_Vendor_Part
    END   
else  
   BEGIN  
         COMMIT TRAN Mant_Vendor_Part
   END