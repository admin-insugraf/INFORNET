--******* CREADO 09/05/2007 *********
--****** PROC - MOSTRAR DATOS DE *****
CREATE procedure [dbo].[INV_LIST_PART_QTY]
--declare
  @codigo char(2),@codarticulo char(20),@opcion char(1)
/*
  set @codigo=''
  set @opcion='2'
*/
as
             SET NOCOUNT ON    
             SET  QUOTED_IDENTIFIER off    
	declare @STRquery nvarchar(1000)
	declare @criterio nvarchar(1000)
	SET @criterio=N' WHERE 1=1'	
	if len(@codigo)>0
		set @criterio=@criterio + N' and  P.WAREHOUSE_ID=@codigo'

	if len(@codarticulo)>0
		set @criterio=@criterio + N' and  P.PART_ID=@codarticulo'

        if @opcion='1'   -- Mostrar datos para el GRID
    	   set @STRquery='Select W.ID,W.NAME, QTY_ON_HAND  FROM PART_QTY P INNER JOIN WAREHOUSE W ON P.WAREHOUSE_ID=W.ID'

        if @opcion='2'   -- Mostrar datos para el GRID
    	   set @STRquery='Select ID,DESCRIPTION,UNIT_OF_MEASUREMENT,CLASIFICATION_ID,QTY_ON_HAND,MIN_QTY,MAX_QTY,QTY_ON_ORDER,WEEK_SUPPLY 
                                            FROM PART_QTY P INNER JOIN PART M ON P.PART_ID=M.ID '

	set @STRquery=@STRquery + @criterio
	exec sp_executesql @STRquery,N'@codigo char(2),@codarticulo char(20),@opcion char(1)',@codigo,@codarticulo,@opcion