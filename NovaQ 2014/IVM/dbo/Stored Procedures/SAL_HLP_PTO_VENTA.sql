CREATE procedure [dbo].[SAL_HLP_PTO_VENTA]  
 (@cod_compania varchar(50))  
 AS   
IF @cod_compania =''  
 BEGIN   
 select s.sales_place_id AS [CODIGO],  
     s.sales_place_description AS [PUNTO_DE_VENTA],  
     s.warehouse_id AS [IDE],  
     w.NAME AS [ALMACEN] ,  
     s.company_id  
 from SALES_PLACE s  
 inner join WAREHOUSE w  
  on s.WAREHOUSE_ID=w.ID  
  order by s.SALES_PLACE_ID  
 END   
ELSE  
 BEGIN    
  select s.sales_place_id AS [CODIGO],  
     s.sales_place_description AS [PUNTO_DE_VENTA],  
     s.warehouse_id AS [IDE],  
     w.NAME AS [ALMACEN],  
     s.company_id  
 from SALES_PLACE s  
 inner join WAREHOUSE w  
  on s.WAREHOUSE_ID=w.ID  
 where s.COMPANY_ID=@cod_compania  
   order by s.SALES_PLACE_ID  
 END
