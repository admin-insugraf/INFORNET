--Creado  07/06/2007
--Mantenimiento de gasto de importacion
CREATE   procedure [dbo].[PUR_MANT_TYPE_COST]
--declare   
@codigo varchar(2), @nombre varchar(50),@nombreabrev varchar(10), @resta bit,@opcion char(1)
/* 
SET @codigo='02'  
SET @nombre=''  
SET @OPCION='3'
*/
as  
declare @STRquery nvarchar(4000)
declare @Errores int

  if @OPCION='1' --Insertar  
    Set @STRquery='INSERT INTO TYPE_COST (ID, DESCRIPTION,DESCRIPTION_ABRE,SUM_COST)    
                  VALUES (@codigo,@nombre,@nombreabrev,@resta)'  
  if @OPCION='2'  --Modificar  
     Set @STRquery='UPDATE TYPE_COST SET DESCRIPTION=@nombre,DESCRIPTION_ABRE=@nombreabrev,SUM_COST=@resta WHERE ID=@codigo'  

  if @OPCION='3'  --Eliminar
     Set @STRquery='DELETE FROM TYPE_COST WHERE ID=@codigo'  
  
Begin Tran Mant_Type_Cost
   Set @Errores=0     --Para insertar
          exec sp_executesql @STRquery,N'@codigo varchar(2), @nombre varchar(50),@nombreabrev varchar(10),@resta bit,@opcion char(1) ',   
                  @codigo, @nombre,@nombreabrev,@resta,@opcion     
          set @Errores = @@Error  
 
if @errores<>0 
   BEGIN  
         ROLLBACK TRAN Mant_Type_Cost
    END   
else  
   BEGIN  
         COMMIT TRAN Mant_Type_Cost
   END