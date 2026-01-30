create proc NQ_Insert_Trama
@pCodigo varchar(50),
@pDes varchar(3000)
as
if exists(select * from tramas where id=@pCodigo)
begin 
update tramas set description=@pDes
where id=@pCodigo
end 
else
begin
insert into tramas values(@pCodigo,@pDes)
end
