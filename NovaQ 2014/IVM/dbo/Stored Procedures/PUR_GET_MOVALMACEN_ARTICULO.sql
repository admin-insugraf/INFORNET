/*CREADO  28/04/2007*/
/*CONSULTA SI EL ARTICULO TIENE MOVIMIENTOS*/
CREATE procedure [dbo].[PUR_GET_MOVALMACEN_ARTICULO]
--DECLARE
@codigo varchar(20)
/*
SET @codigo='001'
*/
as
    Declare @STRquery nvarchar(1000)
    set @STRquery='Select top 1 PART_ID From  WAREHOUSE_TRANS_LINE A Inner Join WAREHOUSE_TRANS B On B.WAREHOUSE_ID=A.WAREHOUSE_ID And 
              B.DOCUMENT_ID=A.DOCUMENT_ID  And B.NUMBER_DOCUMENT =A.NUMBER_DOCUMENT 
              Where not (B.DOCUMENT_ID=''GS'' And B.TRANS_ID=''GF'' And B.STATUS_GUIA=''F'' And B.STATUS_GUIA<>''A'') and A.PART_ID=@codigo'

	exec sp_executesql @STRquery,N'@codigo varchar(20)',@codigo