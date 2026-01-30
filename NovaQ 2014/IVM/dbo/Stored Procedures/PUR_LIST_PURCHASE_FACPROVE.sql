CREATE  proc [dbo].[PUR_LIST_PURCHASE_FACPROVE]      
--declare      
@codigo char(13), @tipo char(2), @fechaini  varchar(10),       
@fechafin  varchar(10),@opciontodos char(5),@opcion char(1)      
/*      
set @codigo='00000001'      
set @fechaini=39229      
set @fechaini=39229      
set @opcionTODOS='TODOS'      
set @opcion='2'      
*/      
as      
 declare @STRquery nvarchar(1000)      
 declare @criterio nvarchar(1000)      
 SET @criterio=N' WHERE 1=1 and len(note_in_id)>0 '       
 if len(@codigo)>0      
  set @criterio=@criterio + N' and P.ID=@codigo '      
              if len(@tipo)>0                
  set @criterio=@criterio + N' and P.TYPE=@tipo '      
      
 if  @opcionTodos='RANGO'       
       set @criterio=@criterio + N' and promise_date between @fechaini and @fechafin'      
      
        if @opcion='0'   --Buscar si existe el código de la orden de compra      
        set @STRquery='Select P.ID from PURCHASE_FACT_SUPPLIER P'      
      
        if @opcion='1'   -- Editar datos de la orden de compra      
        set @STRquery='Select *  from PURCHASE_FACT_SUPPLIER P'      
      
        if @opcion='2'   -- Mostrar datos para el GRID ORDENES DE COMPRA      
 set @STRquery='Select P.TYPE,P.ID,DOCUMENT_DATE,VENDOR_ID, V.NAME,V.VAT_REGISTRATION,STATUS_ID,AMOUNT_SALES,CURRENCY_TYPE,S.DESCRIPTION,p.serie,p.refer_document_type,promise_date,refer_document_number                                              
                                         from PURCHASE_FACT_SUPPLIER P INNER JOIN VENDOR V       
                                         ON P.VENDOR_ID=V.ID INNER JOIN PURCHASE_STATUS S ON S.ID=P.STATUS_ID'            
      
        if @opcion='3'   -- Mostrar datos en las ayuda con F1      
 set @STRquery='Select ID,DESCRIPTION  from PURCHASE_FACT_SUPPLIER '             
      
 set @STRquery=@STRquery + @criterio      
      
      
     EXEC sp_executesql @STRquery,N'@codigo char(13),@tipo char(2),@opcion char(1),      
               @opciontodos char(5), @fechaini varchar(10),@fechafin varchar(10)'      
               ,@codigo,@tipo,@opcionTodos,@opcion,@fechaini, @fechafin