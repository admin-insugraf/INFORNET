--******* CREADO 10/05/2007 *********
--****** PROC - MOSTRAR DATOS DE TIPO DE TRANSACCIONES*****
CREATE procedure [dbo].[INV_LIST_TRANSACTION_TYPE]
--declare
  @codigo char(2),@opcion char(1), @tipo char(1)
/*
  set @codigo=''
  set @opcion='2'
  set @tipo='I'
*/
as
	declare @STRquery nvarchar(1000)
	declare @criterio nvarchar(1000)
	SET @criterio=N' WHERE 1=1'	
	if len(@codigo)>0
   	   set @criterio=@criterio + N' and P.MOV_ID=@codigo and TYPE_ID=@tipo '

	if len(@tipo)>0
   	   set @criterio=@criterio + N' and TYPE_ID=@tipo'


        if @opcion='0'   --Buscar si existe el código del tipo de transaccion
    	   set @STRquery='SELECT ID FROM TRANSACTION_TYPE P'

        if @opcion='1'   -- Editar datos del tipo de transacción
    	   set @STRquery='SELECT * FROM TRANSACTION_TYPE P'

        if @opcion='2'   -- Mostrar datos para el GRID
    	   set @STRquery='SELECT (case when TYPE_ID=''I'' then ''Ingreso'' else ''Salida'' end) as TipoMov, MOV_ID, NAME,
                                            (case when IS_VALUED=''V'' then ''Valorizado'' else ''No valorizado'' end) as Valorizado, 
                                            IS_VALUED,IS_VENDOR, IS_DOC_REF, IS_AUTHORIZED, IS_CCOST, IS_ORDER_PURCHASE,
                                             IS_COMMENT, IS_WHO, IS_CUSTOMER, IS_ORDER_MANUFACT, 
                                             IS_POST, IS_ACCOUNT  FROM TRANSACTION_TYPE P '

	set @STRquery=@STRquery + @criterio
	exec sp_executesql @STRquery,N'@codigo char(2),@opcion char(1),@tipo char(1)',@codigo,@opcion,@tipo