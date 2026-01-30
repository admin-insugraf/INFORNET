create proc NQ_Insert_Vehi
@pcodigo varchar(100),
@pplaca varchar(100),
@pmarca varchar(100),
@pmodelo varchar(100),
@pcapacidad int
as
if exists(select * from VEHICULOS where codigo=@pcodigo)
begin
update VEHICULOS set
placa=@pplaca,
marca=@pmarca,
modelo=@pmodelo,
capacidad=@pcapacidad
where codigo=@pcodigo
end
else
begin
insert into VEHICULOS
values(@pcodigo,@pplaca,@pmarca,@pmodelo,@pcapacidad)
end

