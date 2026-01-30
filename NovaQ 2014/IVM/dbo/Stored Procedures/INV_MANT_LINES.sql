--Creado 11/05/2007  
--Mantenimiento de Linea de articulos
CREATE procedure [dbo].[INV_MANT_LINES]
--declare     
@codfam varchar(8), @codigo varchar(8), @nombre varchar(45),@opcion char(1)

/*
set @codigo = '03' 
set @nombre='ssssssss'
set @opcion='3'
*/
as    
declare @STRquery nvarchar(4000)  
declare @STRquery1 nvarchar(1000)
declare @Errores int  
declare  @Error1 integer  
  
  if @OPCION='1' --Insertar    
    Set @STRquery='INSERT INTO LINES (FAMILY_ID,ID,NAME)      
                                VALUES (@codfam,@codigo,@nombre)'    
  if @OPCION='2'  --Modificar    
     Set @STRquery='UPDATE LINES SET NAME=@NOMBRE  WHERE ID=@CODIGO AND FAMILY_ID=@CODFAM'    
  
  if @OPCION='3'  --Eliminar  
     Set @STRquery='DELETE FROM LINES WHERE ID=@CODIGO AND FAMILY_ID=@CODFAM'    
     Set @STRquery1='DELETE FROM GROUPS WHERE FAMILY_ID=@CODFAM AND LINE_ID=@CODIGO'    
    
Begin Tran Mant_Lines
   Set @Errores=0     --Para insertar  
         exec sp_executesql @STRquery,N'@codfam varchar(8),@codigo varchar(8), @nombre varchar(45),@opcion char(1)', 
                     @codfam, @codigo, @nombre,@opcion
         set @Errores = @@Error    
  
   Set @error1=0   -- Para eliminar  
           exec sp_executesql @STRquery1,N'@codfam varchar(8),@codigo varchar(8)', @codfam,@codigo
           set @error1 = @@Error       
  
if @errores<>0 or @error1<>0 
   BEGIN    
         ROLLBACK TRAN Mant_Lines
   END     
else    
   BEGIN    
         COMMIT TRAN Mant_Lines
   END