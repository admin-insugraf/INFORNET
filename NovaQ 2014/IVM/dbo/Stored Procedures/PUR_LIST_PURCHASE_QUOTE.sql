--******* CREADO 12/06/2007 *********
--****** PROC - MOSTRAR LAS SOLICITUDES DE COTIZACION *****
CREATE procedure [dbo].[PUR_LIST_PURCHASE_QUOTE]
--declare
@codigo char(10),@fechaini as numeric(15,6), 
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
		set @criterio=@criterio + N' and P.ID=@codigo'

	if  @opcionTodos='RANGO' 
  	    set @criterio=@criterio + N' and DOCUMENT_DATE between @fechaini and @fechafin'

        if @opcion='0'   --Buscar si existe el código de la solicitud de cotizacion
    	   set @STRquery='Select P.ID from PURCHASE_QUOTE P'

        if @opcion='1'   -- Editar datos de la solicitud de cotizacion
    	   set @STRquery='Select *  from PURCHASE_QUOTE P'

        if @opcion='2'   -- Mostrar datos para el GRID SOLICITUD DE COTIZACIONES
	set @STRquery='Select  P.ID,DOCUMENT_DATE,VENDOR_ID, V.NAME,P.COMMENT,SCNCOTIZ, QUOTE_DATE                                         
                                         from PURCHASE_QUOTE P INNER JOIN VENDOR V 
                                         ON P.VENDOR_ID=V.ID'						

        if @opcion='3'   -- Mostrar datos en las ayuda con F1
	set @STRquery='Select ID,DESCRIPTION  from PURCHASE_QUOTE '       

	set @STRquery=@STRquery + @criterio


     exec sp_executesql @STRquery,N'@codigo char(10),@opcion char(1),
               @opciontodos char(5), @fechaini numeric(15,6),@fechafin numeric(15,6)'
               ,@codigo,@opcionTodos,@opcion,@fechaini, @fechafin