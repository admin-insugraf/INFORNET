CREATE PROCEDURE SAL_HLP_BUSCA_LOTE
	(
	 @almacen varchar(2),
	 @codigo varchar(20)	
	)
as
select LOT_ID,QTY_ON_HAND,CADUCATE_DATE 
from LOT
where WHO_ID=@almacen
and PART_ID=@codigo
order by LOT_ID