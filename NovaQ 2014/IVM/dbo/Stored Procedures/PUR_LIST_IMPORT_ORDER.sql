--******* CREADO 27/06/2007 *********
--****** PROC - MOSTRAR LAS ORDENES DE IMPORTACION *****
CREATE procedure [dbo].[PUR_LIST_IMPORT_ORDER]
--declare
@codigo char(13), @fechaini as numeric(15,6), 
@fechafin as numeric(15,6),@opciontodos char(5),@opcion char(1)
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
	SET @criterio=N' WHERE 1=1'	
	if len(@codigo)>0
		set @criterio=@criterio + N' and P.ID=@codigo '

	if  @opcionTodos='RANGO' 
  	    set @criterio=@criterio + N' and P.DOCUMENT_DATE between @fechaini and @fechafin'

        if @opcion='1'   -- Editar datos de la orden de importacion
    	   set @STRquery='Select *  from IMPORT_ORDER P'

        if @opcion='2'   -- Mostrar datos para el GRID ORDENES DE IMPORTACION
	set @STRquery='Select  P.ID,DOCUMENT_DATE,PROMISE_DATE,VENDOR_ID,V.NAME
			,STATUS_ID,AMOUNT,CURRENCY_ID_IMP,S.DESCRIPTION                                          
                                         from IMPORT_ORDER P INNER JOIN PURCHASE_STATUS S 
                                         ON S.ID=P.STATUS_ID INNER JOIN VENDOR V ON P.VENDOR_ID=V.ID '						

        if @opcion='3'   -- Mostrar datos en las ayuda con F1
	set @STRquery='Select ID,DOCUMENT_DATE  from IMPORT_ORDER '       

	set @STRquery=@STRquery + @criterio


     exec sp_executesql @STRquery,N'@codigo char(13),@opcion char(1),
               @opciontodos char(5), @fechaini numeric(15,6),@fechafin numeric(15,6)'
               ,@codigo,@opcionTodos,@opcion,@fechaini, @fechafin