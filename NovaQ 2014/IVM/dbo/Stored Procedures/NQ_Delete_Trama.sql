create proc NQ_Delete_Trama
@pCodigo varchar(50)
as
delete from tramas where id=@pCodigo

