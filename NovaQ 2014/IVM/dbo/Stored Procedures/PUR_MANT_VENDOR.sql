CREATE  procedure [dbo].[PUR_MANT_VENDOR]  
--declare     
@codigo varchar(11), @nombre varchar(100),@ruc varchar(11), @direccion varchar(100),@distrito varchar(8),    
@pais varchar(3),@gironegocio varchar(2),@fax varchar(30),@telefono varchar(30),@email varchar(50),@web varchar(50),    
@estado char(1),@nomRep varchar(70),@CargoRep varchar(30),@TelRep varchar(30),@emailrep varchar(50),  
@nomCont varchar(70),@CargoCont varchar(30),@TelCont varchar(30),@emailCont varchar(50),@glosa varchar (255),  
@fecCreacion varchar(10), @Usuario varchar(8),@opcion char(1),@tipoDoc varchar(2),@tipoEmp varchar(2),
@cuenta_local VARCHAR(50),@cuenta_extranjera VARCHAR(50)  
/*   
SET @codigo='PROD001'    
SET @codigofab='CODFABRICANTE'    
SET @descripcion='DESCRIPCION DEL ARTICULO'    
SET @descripcionALT='DESCRIPCION ALTERNA'    
SET @UNIDAD='KG'    
SET @UNIDADREF='LT'    
SET @familia='01'     
SET @linea ='01'    
SET @grupo ='01'    
SET @peso =1000    
SET @tipoarticulo ='1'    
SET @usuario ='1'    
SET @estado ='V'    
SET @fechacreacion ='27/04/2007'    
SET @serie ='N'    
SET @lote ='N'    
SET @moneda ='MN'    
SET @igvpor=0     
SET @flagigv =0    
SET @clase ='02'    
SET @color ='02'    
SET @talla ='TALLA'    
SET @foto ='D:\FUENTES_ERIKA\PersonalizadoVtas(BestBrands)\Imagenes\95.ICO'    
SET @ficha ='Text1'    
SET @stock ='S'    
SET @partidarancelaria =''    
SET @fechabaja =''    
SET @opcion ='3'    
*/  
as    
declare @STRquery nvarchar(4000)  
declare @STRquery1 nvarchar(1000)  
declare @Errores int  
declare  @Error1 integer  
  
  if @OPCION='1' --Insertar    
    Set @STRquery='INSERT INTO VENDOR (ID,NAME,VAT_REGISTRATION,ADDR,STATE_ID,COUNTRY_ID,PHONE,FAX_NUMBER,  
                 EMAIL,WEBSITE,TYPE_VENDOR_ID,STATUS,CONTACT,CONTACT_POSITION,CONTACT_PHONE,  
            CONTACT_EMAIL,REPRESENT,REPRESENT_POSITION,REPRESENT_PHONE,REPRESENT_EMAIL,  
     CREATE_DATE,CREATE_USER,COMMENT,DOCUMENT_TYPE_PERSON_ID,TYPE_COMPANY,ACCOUNT_LOCAL,ACCOUNT_EXTERNAL)      
                  VALUES (@CODIGO,@NOMBRE,@RUC,@DIRECCION,@DISTRITO,@PAIS,@TELEFONO,@FAX,@EMAIL,@WEB,    
                 @GIRONEGOCIO,@ESTADO,@NOMCONT,@CARGOCONT,@TELCONT,@EMAILCONT,@NOMREP,@CARGOREP,  
                 @TELREP,@EMAILREP,@FECCREACION,@USUARIO,@GLOSA,@tipoDoc,@tipoEmp,@cuenta_local,@cuenta_extranjera)'    
  if @OPCION='2'  --Modificar    
     Set @STRquery='UPDATE VENDOR SET NAME=@NOMBRE,VAT_REGISTRATION=@RUC,ADDR=@DIRECCION,STATE_ID=@DISTRITO,COUNTRY_ID=@PAIS,  
                   PHONE=@TELEFONO,FAX_NUMBER=@FAX, EMAIL=@EMAIL,WEBSITE=@WEB, TYPE_VENDOR_ID=@GIRONEGOCIO,STATUS=@ESTADO,CONTACT=@NOMCONT,  
                   CONTACT_POSITION=@CARGOCONT,CONTACT_PHONE=@TELCONT,CONTACT_EMAIL=@EMAILCONT, REPRESENT=@NOMREP,  
                   REPRESENT_POSITION=@CARGOREP, REPRESENT_PHONE=@TELREP,REPRESENT_EMAIL=@EMAILREP,MODIFY_DATE=@FECCREACION,  
                   COMMENT=@GLOSA,DOCUMENT_TYPE_PERSON_ID=@tipoDoc,TYPE_COMPANY=@tipoEmp,ACCOUNT_LOCAL=@cuenta_local,ACCOUNT_EXTERNAL=@cuenta_extranjera  WHERE ID=@CODIGO'    
  
  if @OPCION='3'  --Eliminar  
     Set @STRquery='DELETE FROM VENDOR WHERE ID=@CODIGO'    
    
Begin Tran Mant_Vendor  
   Set @Errores=0     --Para insertar  
          exec sp_executesql @STRquery,N'@codigo varchar(11), @nombre varchar(100),@ruc varchar(11), @direccion varchar(100),@distrito varchar(8),    
                  @pais varchar(3),@gironegocio varchar(2),@fax varchar(30),@telefono varchar(30),@email varchar(50),@web varchar(50),    
                  @estado char(1),@nomRep varchar(70),@CargoRep varchar(30),@TelRep varchar(30),@emailrep varchar(50),  
                  @nomCont varchar(70),@CargoCont varchar(30),@TelCont varchar(30),@emailCont varchar(50),@glosa varchar (255),@feccreacion varchar(10),  
                  @Usuario varchar(8),@opcion char(1),@tipoDoc varchar(2),@tipoEmp varchar(2),@cuenta_local VARCHAR(50),@cuenta_extranjera VARCHAR(50) ',     
                  @codigo, @nombre,@ruc, @direccion,@distrito,@pais,@gironegocio,@fax,@telefono,@email ,@web,@estado,@nomRep,@CargoRep,@TelRep,  
                  @emailrep,@nomCont, @CargoCont,@TelCont,@emailCont,@glosa,@fecCreacion,@Usuario,@opcion,@tipoDoc,@tipoEmp,@cuenta_local,@cuenta_extranjera 
          set @Errores = @@Error    
  
   Set @ERROR1=0   -- Para eliminar  
           exec sp_executesql @STRquery1,N'@codigo varchar(11)', @codigo   
           set @ERROR1 = @@Error    
   
if @errores<>0  or @error1<>0  
   BEGIN    
         ROLLBACK TRAN Mant_Vendor  
    END     
else    
   BEGIN    
         COMMIT TRAN Mant_Vendor  
   END
