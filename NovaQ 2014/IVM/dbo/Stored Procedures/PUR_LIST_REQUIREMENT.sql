
--******* CREADO 08/06/2007 *********  
--****** PROC - MOSTRAR LOS REQUERIMIENTOS *****  
CREATE procedure [dbo].[PUR_LIST_REQUIREMENT]  
--declare  
@codigo char(10),@tipo char(2),@fechaini as numeric(15,6),   
@fechafin as numeric(15,6),@opciontodos char(5),@opcion char(1),@user varchar(100)  
/*  
set @codigo='00000001'  
set @tipo='RQ'  
set @fechaini=39229  
set @fechaini=39229  
set @opcionTODOS='TODOS'  
set @opcion='2'  
*/  
as  
 declare @STRquery nvarchar(1000)  
 declare @criterio nvarchar(1000)  
 SET @criterio=N' WHERE 1=1'   
 if len(@codigo)>0  
  set @criterio=@criterio + N' and R.ID=@codigo'  
  
 if len(@tipo)>0  
	if upper(rtrim(@user))='ADMIN'
		set @criterio=@criterio + N' and  R.TYPE=@tipo'  
	else
		set @criterio=@criterio + N' and  R.TYPE=@tipo AND R.USER_ID=@user'  
  
  
 if  @opcionTodos='RANGO'   
       set @criterio=@criterio + N' and R.REQUIRED_DATE between @fechaini and @fechafin'  
  
        if @opcion='0'   --Buscar si existe el código del requerimiento  
        set @STRquery='Select ID from REQUIREMENT R'  
  
        if @opcion='1'   -- Editar datos de requerimiento  
        set @STRquery='Select *  from REQUIREMENT R'  
  
        if @opcion='2'   -- Mostrar datos para el GRID  
 set @STRquery='Select R.ID,REQUIRED_DATE,M.DESCRIPTION AS PERSOL,A.DESCRIPTION AS AREA,STATUS,COMMENT from   
                       REQUIREMENT R INNER JOIN MASTER_HELP  M ON R.REQUIRED_USER=M.ID    
           AND M.TYPE_ID=''12'' INNER JOIN AREA A ON R.AREA_ID=A.ID '        
  
        if @opcion='3'   -- Mostrar datos en las ayuda con F1  
 set @STRquery='Select R.ID,DESCRIPTION  from REQUIREMENT R'         
  
 set @STRquery=@STRquery + @criterio  
  
  
     exec sp_executesql @STRquery,N'@codigo char(10),@tipo char(2),@opcion char(1),  
               @opciontodos char(5), @fechaini numeric(15,6),@fechafin numeric(15,6),@user varchar(100)'  
               ,@codigo,@tipo,@opcionTodos,@opcion,@fechaini, @fechafin,@user
