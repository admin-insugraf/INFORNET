--Creado por EVG - 10/05/2007  
--Mantenimiento de Transportista
CREATE procedure [dbo].[INV_MANT_CARRIER]
--declare     
@codigo varchar(11), @nombre varchar(50),@telefono varchar(5),@direccion varchar(100),@ruc varchar(11),
@estado varchar(1),@fechacreacion varchar(10),@Nombreemp varchar(50), @rucemp varchar(11),
@direccionemp varchar(50),@telefonoemp varchar(25),@placa varchar(10),@brevete varchar(15),
@modelo varchar(50), @nroinscripcion varchar(50), @dni varchar(8),@opcion char(1)
/*
set @codigo = '00100' 
set @nombre='ssssssss'
set @telefono =''
set @direccion =''
set @ruc=''
set @estado =''
set @fechacreacion =''
set @Nombreemp=''
set @rucemp =''
set @direccionemp =''
set @telefonoemp =''
set @placa =''
set @brevete =''
set @modelo =''
set @nroinscripcion =''
set @dni =''
set @opcion='1'
*/
as    
declare @STRquery nvarchar(4000)  
declare @STRquery1 nvarchar(1000)  
declare @Errores int  
declare  @Error1 integer  
  
  if @OPCION='1' --Insertar    
    Set @STRquery='INSERT INTO CARRIER (ID,NAME_CARRIER,ADDR,PHONE,VAT_REGISTRATION,STATUS,CREATE_DATE,NAME,
	                   VAT_REGISTRATION_COMP,ADDR_COMP,PHONE_COMP,NUMBER_REGISTRATION,NUMBER_LICENSE,MODEL_VEH,
                                NUMBER_INSCRIP,NUMBER_DOCUMENT)      
                                VALUES (@CODIGO,@NOMBRE,@DIRECCION,@TELEFONO, @RUC,@ESTADO,@FECHACREACION, @NOMBREEMP,@RUCEMP,@DIRECCIONEMP,
                                @TELEFONOEMP,@PLACA,@BREVETE,@MODELO,@NROINSCRIPCION,@DNI)'    
  if @OPCION='2'  --Modificar    
     Set @STRquery='UPDATE CARRIER SET NAME_CARRIER=@NOMBRE,PHONE=@TELEFONO,ADDR=@DIRECCION,VAT_REGISTRATION=@RUC, STATUS=@ESTADO,
                                 NAME=@NOMBREEMP,  VAT_REGISTRATION_COMP=@RUCEMP, ADDR_COMP=@DIRECCIONEMP,PHONE_COMP=@TELEFONOEMP,
                                 NUMBER_REGISTRATION= @PLACA, NUMBER_LICENSE=@BREVETE,MODEL_VEH=@MODELO,NUMBER_INSCRIP=@NROINSCRIPCION,
                                NUMBER_DOCUMENT=@DNI WHERE ID=@CODIGO'    
  
  if @OPCION='3'  --Eliminar  
     Set @STRquery='DELETE FROM CARRIER WHERE ID=@CODIGO'    
    
Begin Tran Mant_Carrier
   Set @Errores=0     --Para insertar  
         exec sp_executesql @STRquery,N'@codigo varchar(11), @nombre varchar(50),@telefono varchar(25),@direccion varchar(100),
         @ruc varchar(11),@estado varchar(1),@fechacreacion varchar(10),@Nombreemp varchar(50), @rucemp varchar(11),
         @direccionemp varchar(50),@telefonoemp varchar(25),@placa varchar(10),@brevete varchar(15),@modelo varchar(50),
         @nroinscripcion varchar(50), @dni varchar(8),@opcion char(1)',     
         @codigo,@nombre,@telefono,@direccion,@ruc,@estado,@fechacreacion,@Nombreemp, @rucemp,@direccionemp,@telefonoemp,
         @placa,@brevete,@modelo,@nroinscripcion, @dni,@opcion 
         set @Errores = @@Error    
  
   Set @ERROR1=0   -- Para eliminar  
           exec sp_executesql @STRquery1,N'@codigo varchar(11)', @codigo   
           set @ERROR1 = @@Error    
   
if @errores<>0  or @error1<>0  
   BEGIN    
         ROLLBACK TRAN Mant_Carrier
    END     
else    
   BEGIN    
         COMMIT TRAN Mant_Carrier
   END

