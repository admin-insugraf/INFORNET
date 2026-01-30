


CREATE proc [cx_sp_s_gr_x_fec]
@p_fecha_ini datetime = '01/02/2013',
@p_fecha_fin datetime = '28/02/2013'
as
select 
WAREHOUSE_ID,
DOCUMENT_ID,
NUMBER_DOCUMENT,
DATE_DOCUMENT,
TYPE_TRANS,
TRANS_ID,
DOC_ID_REF ,
COMMENT,
CUSTOMER_ID,
CUSTOMER_NAME,
SALES_TERM,
CURRENCY_TYPE,
CURRENCY_EXCHANGE
from WAREHOUSE_TRANS
where date_document between @p_fecha_ini and @p_fecha_fin