--Creado 11/05/2007  
--Mantenimiento de Unidad de Medida
CREATE procedure [dbo].[INV_MANT_UNITS]
--declare     
@codigo varchar(6), @nombre varchar(20),@estado char(1),@opcion char(1)
/*
set @codigo = '00100' 
set @nombre='ssssssss'
*/
as    
declare @STRquery nvarchar(4000)  
declare @STRquery1 nvarchar(1000)  
declare @Errores int  
declare  @Error1 integer  
  
  if @OPCION='1' --Insertar    
    Set @STRquery='INSERT INTO UNITS (ID,NAME,STATUS)      
                                VALUES (@CODIGO,@NOMBRE,@ESTADO)'    
  if @OPCION='2'  --Modificar    
     Set @STRquery='UPDATE UNITS SET NAME=@NOMBRE WHERE ID=@CODIGO'    
  
  if @OPCION='3'  --Eliminar  
     Set @STRquery='DELETE FROM UNITS WHERE ID=@CODIGO'    
    
Begin Tran Mant_Units
   Set @Errores=0     --Para insertar  
         exec sp_executesql @STRquery,N'@codigo varchar(6), @nombre varchar(20),@estado char(1),@opcion char(1)',     
         @codigo,@nombre,@estado,@opcion 
         set @Errores = @@Error    
  
   Set @ERROR1=0   -- Para eliminar  
           exec sp_executesql @STRquery1,N'@codigo varchar(6)', @codigo   
           set @ERROR1 = @@Error    
   
if @errores<>0  or @error1<>0  
   BEGIN    
         ROLLBACK TRAN Mant_Units
    END     
else    
   BEGIN    
         COMMIT TRAN Mant_Units
   END