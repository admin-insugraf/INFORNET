create proc NQ_Delete_Vehi
@pcodigo varchar(100)
as
delete from 
VEHICULOS where codigo=@pcodigo

create table emp_Transporte(
CODIGO VARCHAR(100),
RAZON_SOCIAL VARCHAR(200),
RUC VARCHAR(20),
DIRECCION VARCHAR(200),
TELEFONO VARCHAR(50)
)
