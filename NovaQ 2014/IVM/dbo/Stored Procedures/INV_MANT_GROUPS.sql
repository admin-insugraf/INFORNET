--Creado 11/05/2007  
--Mantenimiento de grupo de articulos
CREATE procedure [dbo].[INV_MANT_GROUPS]
--declare     
@codfam varchar(8),@codlin varchar(8), @codigo varchar(11), @nombre varchar(45),@opcion char(1)
/*
set @codfam = '01' 
set @codlin = '01' 
set @codigo='04'
set @opcion='3'
*/
as    
declare @STRquery nvarchar(4000)  
declare @STRquery1 nvarchar(1000)
declare @Errores int  
declare  @Error1 integer  
  
  if @OPCION='1' --Insertar    
    Set @STRquery='INSERT INTO GROUPS (FAMILY_ID,LINE_ID,ID,NAME)      
                                VALUES (@codfam,@codlin,@codigo,@nombre)'    
  if @OPCION='2'  --Modificar    
     Set @STRquery='UPDATE GROUPS SET NAME=@NOMBRE  WHERE ID=@CODIGO AND LINE_ID=@CODLIN AND FAMILY_ID=@CODFAM'    
  
  if @OPCION='3'  --Eliminar    
     Set @STRquery1='DELETE FROM GROUPS WHERE FAMILY_ID=@CODFAM AND LINE_ID=@CODLIN AND ID=@CODIGO'    
    
Begin Tran Mant_Groups
   Set @Errores=0     --Para insertar  
         exec sp_executesql @STRquery,N'@codfam varchar(8),@codlin varchar(8),@codigo varchar(11), @nombre varchar(45),@opcion char(1)', 
                     @codfam,@codlin, @codigo, @nombre,@opcion
         set @Errores = @@Error    
  
   Set @error1=0   -- Para eliminar  
           exec sp_executesql @STRquery1,N'@codfam varchar(8),@codlin varchar(8), @codigo varchar(11)', @codfam,@codlin,@codigo
           set @error1 = @@Error       
  
if @errores<>0 or @error1<>0 
   BEGIN    
         ROLLBACK TRAN Mant_Groups
   END     
else    
   BEGIN    
         COMMIT TRAN Mant_Groups
   END
