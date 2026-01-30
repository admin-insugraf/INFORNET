--Creado  06/06/2007
--Mantenimiento de DATOS LOGISTICOS
CREATE   procedure [dbo].[PUR_MANT_PART_QTY]
--declare   
@codigo varchar(2), @codarticulo varchar(20), @clasificacion varchar(1), @stockminimo numeric(15,6), @stockmaximo numeric(15,6),
@ptopedido numeric(15,6), @tiemporeposicion numeric(15,6),@opcion char(1)
/* 
SET @codigo='02'  
SET @nombre=''  
SET @codpais=''  
SET @OPCION='3'
*/
as  
declare @STRquery nvarchar(4000)
declare @Errores int

  if @OPCION='2'  --Modificar  
     Set @STRquery='UPDATE PART_QTY SET CLASIFICATION_ID=@clasificacion,MIN_QTY=@stockminimo, MAX_QTY= @stockmaximo, 
                                 QTY_ON_ORDER= @ptopedido, WEEK_SUPPLY= @tiemporeposicion WHERE WAREHOUSE_ID=@codigo 
                                 AND PART_ID= @codarticulo'  
  
Begin Tran Mant_Part_Qty
   Set @Errores=0     --Para insertar
          exec sp_executesql @STRquery,N'@codigo varchar(2), @codarticulo varchar(20), @clasificacion varchar(1), @stockminimo numeric(15,6), 
                                   @stockmaximo numeric(15,6),@ptopedido numeric(15,6), @tiemporeposicion numeric(15,6),@opcion char(1) ',   
          @codigo, @codarticulo, @clasificacion, @stockminimo, @stockmaximo, @ptopedido, @tiemporeposicion,@opcion 
          set @Errores = @@Error  
 
if @errores<>0 
   BEGIN  
         ROLLBACK TRAN Mant_Part_Qty
    END   
else  
   BEGIN  
         COMMIT TRAN Mant_Part_Qty
   END