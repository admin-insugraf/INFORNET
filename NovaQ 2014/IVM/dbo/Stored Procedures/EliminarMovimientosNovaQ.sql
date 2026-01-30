create proc [dbo].[EliminarMovimientosNovaQ]
@nombre varchar(5)
as

if @nombre='KarloS'
begin
delete from WAREHOUSE_TRANS
delete from WAREHOUSE_TRANS_line
delete from vendor
delete from part
delete from customer
delete from RECEIVABLE
delete from RECEIVABLE_line
delete from RECEIVABLE_list
delete from RECEIVABLE_list_line
delete from RECEIVABLE_list_pay
delete from RECEIVABLE_list_line_pay
delete from REQUIREMENT
delete from REQUIREMENT_line
delete from REQUIREMENT_SERVICE
delete from REQUIREMENT_SERVICE_line
delete from QUOTE
delete from QUOTE_line
delete from PURCHASE_CAB
delete from PURCHASE_line
delete from PURCHASE_FACT_SUPPLIER
delete from PURCHASE_FACT_SUPPLIER_L
delete from PURCHASE_GUIA
delete from PURCHASE_GUIA_LINE
delete from PURCHASE_ORDER
delete from PURCHASE_ORDER_LINE
delete from PURCHASE_QUOTE
delete from PURCHASE_QUOTE_LINE
delete from PURCHASE_VOUCHER
delete from ORDERS
delete from ORDER_LINE
delete from LETTER_EXCHANGE
delete from LETTER
delete from LETTER_EXCHANGE_LINE
delete from LETTER_EXCHANGE_LINE_PAY
delete from LETTER_EXCHANGE_PAY
delete from LETTER_PAY
end