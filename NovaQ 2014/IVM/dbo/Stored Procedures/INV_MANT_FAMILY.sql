--Creado 11/05/2007  
--Mantenimiento de Familia de articulos
CREATE procedure [dbo].[INV_MANT_FAMILY]
--declare     
@codigo varchar(8), @nombre varchar(45),@ctacontDebe varchar(18),@ctacontHaber varchar(18),@ctacontDebeAC varchar(18),
@ctacontHaberAC varchar(18),@ctacontVentas varchar(18),@ctacontCompras varchar(18),@opcion char(1)
/*
set @codigo = '03' 
set @nombre='ssssssss'
set @opcion='3'
*/
as    
declare @STRquery nvarchar(4000)  
declare @STRquery1 nvarchar(1000)
declare @STRquery2 nvarchar(1000)  
declare @Errores int  
declare  @Error1 integer  
declare  @Error2 integer  
  
  if @OPCION='1' --Insertar    
    Set @STRquery='INSERT INTO FAMILY (ID,NAME,ACCOUNT_DR, ACCOUNT_CR, ACCOUNT_DR_AC, ACCOUNT_CR_AC, ACCOUNT,ACCOUNT_PURCHASE)      
                                VALUES (@codigo,@nombre,@ctacontDebe,@ctacontHaber,@ctacontDebeAC,@ctacontHaberAC,@ctacontVentas,@ctacontCompras)'    
  if @OPCION='2'  --Modificar    
     Set @STRquery='UPDATE FAMILY SET NAME=@NOMBRE, ACCOUNT_DR=@ctacontDebe, ACCOUNT_CR=@ctacontHaber,
 		      ACCOUNT_DR_AC= @ctacontDebeAC,ACCOUNT_CR_AC= @ctacontHaberAC ,  ACCOUNT=@ctacontVentas,
                                ACCOUNT_PURCHASE= @ctacontCompras  WHERE ID=@CODIGO'    
  
  if @OPCION='3'  --Eliminar  
     Set @STRquery='DELETE FROM FAMILY WHERE ID=@CODIGO'    
     Set @STRquery1='DELETE FROM LINES WHERE FAMILY_ID=@CODIGO'    
     Set @STRquery2='DELETE FROM GROUPS WHERE FAMILY_ID=@CODIGO'    
    
Begin Tran Mant_Family
   Set @Errores=0     --Para insertar  
         exec sp_executesql @STRquery,N'@codigo varchar(8), @nombre varchar(45),@ctacontDebe varchar(18),@ctacontHaber varchar(18),
	@ctacontDebeAC varchar(18),@ctacontHaberAC varchar(18),@ctacontVentas varchar(18),@ctacontCompras varchar(18), 
             @opcion char(1)', @codigo, @nombre,@ctacontDebe,@ctacontHaber,
               @ctacontDebeAC, @ctacontHaberAC,@ctacontVentas,@ctacontCompras,@opcion
         set @Errores = @@Error    
  
   Set @error1=0   -- Para eliminar  
           exec sp_executesql @STRquery1,N'@codigo varchar(8)', @codigo   
           set @error1 = @@Error    
   
   Set @error2=0   -- Para eliminar  
           exec sp_executesql @STRquery2,N'@codigo varchar(8)', @codigo   
           set @error2 = @@Error    

if @errores<>0 or @error1<>0  or @error2<>0
   BEGIN    
         ROLLBACK TRAN Mant_Family
   END     
else    
   BEGIN    
         COMMIT TRAN Mant_Familiy
   END