--******* CREADO 15/06/2007 *********
--****** PROC - MOSTRAR LAS NOTAS DE INGRESO POR ORDEN DE SERVICIO *****
CREATE procedure [dbo].[PUR_LIST_TRANS_IN_SERVICE]
--declare
@tipodoc char(2), @numero char(10), @fechaini as numeric(15,6), 
@fechafin as numeric(15,6),@opciontodos char(5),@opcion char(1)
/*
set @tipodoc='NI'
set @NUMERO='0000000018'
set @fechaini=39229
set @fechaini=39229
set @opcionTODOS='TODOS'
set @opcion='2'
*/
as
	declare @STRquery nvarchar(1000)
	declare @criterio nvarchar(1000)
	SET @criterio=N' WHERE 1=1'	
	if len(@tipodoc)>0 and len(@numero)>0 
		set @criterio=@criterio + N' and S.TYPE_ID=@tipodoc and S.NUMBER_DOC=@numero'

	if  @opcionTodos='RANGO' 
  	    set @criterio=@criterio + N' and DOCUMENT_DATE between @fechaini and @fechafin'

        if @opcion='1'   -- Editar datos de la orden de compra
    	   set @STRquery='Select *  from TRANS_IN_SERVICE S'

        if @opcion='2'   -- Mostrar datos nota de ingreso de orden de servicio
	set @STRquery='SELECT  S.TYPE_ID,S.NUMBER_DOC,S.TRANS_ID,S.DOCUMENT_DATE,S.STATUS,P.ID,
                       P.NAME,P.VAT_REGISTRATION,S.NUMBER_ORDER_MANUFAC FROM 
                       TRANS_IN_SERVICE S INNER JOIN VENDOR P ON S.VENDOR_ID=P.ID'						

        if @opcion='3'   -- Mostrar datos en las ayuda con F1
	set @STRquery='Select ID,DESCRIPTION  from TRANS_IN_SERVICE S'       
	set @STRquery=@STRquery + @criterio


     exec sp_executesql @STRquery,N'@tipodoc char(2),@numero char(10),@opcion char(1),
               @opciontodos char(5), @fechaini numeric(15,6),@fechafin numeric(15,6)'
               ,@tipodoc,@numero,@opcionTodos,@opcion,@fechaini, @fechafin