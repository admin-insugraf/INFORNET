create proc NQ_Delete_EmpT
@pCODIGO VARCHAR(100)
as
delete from emp_Transporte where codigo=@pCODIGO
