create PROC NQ_Insert_EmpT
@pCODIGO VARCHAR(100),
@pRAZON_SOCIAL VARCHAR(200),
@pRUC VARCHAR(20),
@pDIRECCION VARCHAR(200),
@pTELEFONO VARCHAR(50)
as
if exists(select * from emp_Transporte where codigo=@pCODIGO)
begin
	update emp_Transporte set
	RAZON_SOCIAL=@pRAZON_SOCIAL,
	RUC=@pRUC,
	DIRECCION=@pDIRECCION,
	TELEFONO=@pTELEFONO
	where codigo=@pCODIGO
end 
else
begin
	insert into emp_Transporte
	values(@pCODIGO,@pRAZON_SOCIAL,@pRUC,@pDIRECCION,@pTELEFONO)
end
