create procedure SAL_HLP_ARTICULOS
			(@almacen varchar(2),
			 @codigo varchar(20),
			 @descripcion varchar(64))
       as
       if len(ISNULL(@codigo,''))>0
			begin
			   Select PART.ID,PART.DESCRIPTION,PART.UNIT_OF_MEASUREMENT,
					  PART_QTY.QTY_ON_HAND 
			   from PART 
			   LEFT JOIN PART_QTY  ON  
			   PART.ID = PART_QTY.PART_ID 
			   where (WAREHOUSE_ID=@almacen 
			   OR WAREHOUSE_ID IS NULL) AND STATUS='V' 
			   AND NOT (PART.IS_STOCKED='N' 
			   AND PART.IS_LOT='N' AND PART.SERIES='N')
			   and PART.ID like '%' + @codigo + '%'
			   order by part.ID
			end
		
		if len(ISNULL(@descripcion,''))>0 
			begin
			   Select PART.ID,PART.DESCRIPTION,PART.UNIT_OF_MEASUREMENT,
					  PART_QTY.QTY_ON_HAND 
			   from PART 
			   LEFT JOIN PART_QTY  ON  
			   PART.ID = PART_QTY.PART_ID 
			   where (WAREHOUSE_ID=@almacen 
			   OR WAREHOUSE_ID IS NULL) AND STATUS='V' 
			   AND NOT (PART.IS_STOCKED='N' 
			   AND PART.IS_LOT='N' AND PART.SERIES='N')
			   and PART.DESCRIPTION like '%' + @descripcion + '%'
			   order by part.DESCRIPTION
			end 
		
		if len(ISNULL(@codigo,''))=0 and len(ISNULL(@descripcion,''))=0 
			begin
			   Select PART.ID,PART.DESCRIPTION,PART.UNIT_OF_MEASUREMENT,
					  PART_QTY.QTY_ON_HAND 
			   from PART 
			   LEFT JOIN PART_QTY  ON  
			   PART.ID = PART_QTY.PART_ID 
			   where (WAREHOUSE_ID=@almacen 
			   OR WAREHOUSE_ID IS NULL) AND STATUS='V' 
			   AND NOT (PART.IS_STOCKED='N' 
			   AND PART.IS_LOT='N' AND PART.SERIES='N')
			   order by part.ID
			
			end
