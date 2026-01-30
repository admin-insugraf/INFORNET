CREATE procedure [dbo].[INV_RPT_INVENTARIO_VAL_MENSUAL]    
 --declare    
 @pc nvarchar(80),@opcion char(1),    
 @mes char(2),@anyo char(4),    
 @codini char(20),@codfin char(20),    
 @tipoart char(4),    
 @anyomesant char(6),@anyomes char(6)     
/*set @pc=''    
set @opcion='4'    
set @mes=''    
set @anyo=''    
set @codini='008'    
set @codfin='SER'    
set @tipoart=''    
set @anyomesant=''    
set @anyomes=''    
--*/as    
 declare @STRquery nvarchar(2500)    
 declare @tabla nvarchar(80)    
 declare @staanul char(1),@guiasal char(2),@guiafac char(2)    
 declare @stafac char(1),@isno char(1),@texto char(5)    
 declare @filtro nvarchar(200)    
    
 if @opcion='0' --crea temporal    
  begin    
     if exists(select * from tempdb.dbo.sysobjects where name=@pc)    
        begin    
           set @tabla=N'[tempdb].dbo.'+@pc    
           set @STRquery='drop table '+ @tabla    
            exec sp_executesql @STRquery,N'@pc nvarchar(80),@opcion char(1)',    
        @pc,@opcion    
        end    
   set @tabla='[tempdb].dbo.'+@pc    
   set @STRquery='create table '+@tabla+ '(ITEM int,PART_ID varchar(20),DOCUMENT_DATE smalldatetime,    
                    TIME varchar(8),IS_IN_OUT varchar(1),TRANS_ID varchar(2),    
     TYPE_DOC varchar(2),WAREHOUSE_ID varchar(2),    
                    NUMBER_DOC varchar(20),QTY_INITIAL float default 0.00,QTY_IN float,    
     QTY_OUT float,QTY_BALANCE float,    
                    UNIT_PRICE float,INIT_VALUE float,IN_VALUE float,    
     OUT_VALUE float,END_VALUE float,    
                    AVERAGE_COST float,IS_VALUE bit default(0))'    
   exec sp_executesql @STRquery,N'@pc nvarchar(80),@opcion char(1)',    
        @pc,@opcion    
  end    
    
 if @opcion='1' --consulta    
   begin    
  set @staanul='A'      
  set @guiasal='GS'    
  set @guiafac='GF'     
  set @stafac='F'    
  set @isno='N'    
  set @texto='TEXTO'    
    
  if len(@tipoart)>0    
     set @filtro= N' AND M.TYPE_PART=@tipoart order by A.PART_ID,B.DATE_DOCUMENT,B.TYPE_TRANS,B.TRANS_ID,B.WAREHOUSE_ID,    
        B.DOCUMENT_ID,B.NUMBER_DOCUMENT,A.ITEM'    
  else    
   set @filtro= N' order by A.PART_ID,B.DATE_DOCUMENT,B.TYPE_TRANS,B.TRANS_ID,B.WAREHOUSE_ID,    
        B.DOCUMENT_ID,B.NUMBER_DOCUMENT,A.ITEM'    
    
  set @STRquery='select A.*,B.* from     
   WAREHOUSE_TRANS B inner join     
   (WAREHOUSE_TRANS_LINE A left join PART M on A.PART_ID=M.ID ) on    
   B.WAREHOUSE_ID = A.WAREHOUSE_ID AND B.DOCUMENT_ID=A.DOCUMENT_ID AND B.NUMBER_DOCUMENT=A.NUMBER_DOCUMENT    
   where month(B.DATE_DOCUMENT) =@mes    
   and year(B.DATE_DOCUMENT) =@anyo and B.STATUS_GUIA<>@staanul    
   and not (B.DOCUMENT_ID=@guiasal and B.TRANS_ID=@guiafac and B.STATUS_GUIA=@stafac)    
   and not (M.IS_STOCKED=@isno and M.SERIES=@isno and M.IS_LOT=@isno)     
   and (A.PART_ID>=@codini and A.PART_ID<=@codfin)     
   and (A.PART_ID<>@texto)' + @filtro     
  exec sp_executesql @STRquery,N'@opcion char(1),    
    @mes char(2),@anyo char(4),@codini char(20),@codfin char(20),@tipoart char(4),    
    @staanul char(1),@guiasal char(2),@guiafac char(2),@stafac char(1),    
    @isno char(1),@texto char(5)',    
    @opcion,@mes,@anyo,@codini,@codfin,@tipoart,    
    @staanul,@guiasal,@guiafac,@stafac,@isno,@texto    
   end    
    
 if @opcion='2' --consulta agrupada moresmes    
   begin    
  set @STRquery='select PART_ID,YEAR_MONTH,AMOUNT,AMOUNT_US,    
   sum(QTY_INITIAL) as QTY_INITIAL,    
   sum(QTY_ENTER) as QTY_ENTER,    
   sum(QTY_OUT) as  QTY_OUT     
   from MONTHLY_SUMMARIZE where     
   YEAR_MONTH >=@anyomesant    
   AND YEAR_MONTH <=@anyomes    
   AND (PART_ID>=@codini AND PART_ID<=@codfin)     
   group by PART_ID,YEAR_MONTH,AMOUNT,AMOUNT_US order by YEAR_MONTH'    
  exec sp_executesql @STRquery,N'@opcion char(1),    
    @anyomesant char(6),@anyomes char(6),@codini char(20),@codfin char(20)',    
    @opcion,@anyomesant,@anyomes,@codini,@codfin    
      end    
    
 if @opcion='3' --consulta moresmes    
  begin    
  set @STRquery='select * from MONTHLY_SUMMARIZE where     
   YEAR_MONTH >=@anyomesant AND YEAR_MONTH <=@anyomes     
   AND (PART_ID>=@codini AND PART_ID<=@codfin) ORDER BY YEAR_MONTH'    
  exec sp_executesql @STRquery,N'@opcion char(1),    
   @anyomesant char(6),@anyomes char(6),@codini char(20),@codfin char(20)',    
   @opcion,@anyomesant,@anyomes,@codini,@codfin    
  end     
    
 if @opcion='4' --Consulta stock y partes    
  begin    
   if len(@tipoart)>0    
      set @filtro=N' AND B.TYPE_PART=@tipoart'    
   else    
      set @filtro=N''    
       
   set @STRquery='select distinct(A.PART_ID) from PART_QTY A     
    inner join PART B on A.PART_ID=B.ID     
    where (A.PART_ID>=@codini and A.PART_ID<=@codfin)' + @filtro    
  exec sp_executesql @STRquery,N'@opcion char(1),    
   @codini char(20),@codfin char(20),@tipoart char(4)',    
   @opcion,@codini,@codfin,@tipoart    
  end    
    
 if @opcion='5' --Consulta para armar el reporte    
  begin    
  set @tabla=N'[tempdb].dbo.'+@pc    
  set @STRquery='select I.ITEM,I.PART_ID,I.DOCUMENT_DATE,I.TIME,I.IS_IN_OUT,I.TRANS_ID,    
  I.TYPE_DOC,I.WAREHOUSE_ID,I.NUMBER_DOC,I.QTY_INITIAL,I.QTY_IN,    
  I.QTY_OUT,I.QTY_BALANCE,I.UNIT_PRICE,I.INIT_VALUE,I.IN_VALUE,    
  I.OUT_VALUE,I.END_VALUE,I.AVERAGE_COST,I.IS_VALUE,    
  P.DESCRIPTION,P.UNIT_OF_MEASUREMENT,W.CURRENCY_EXCHANGE    
  from '+ @tabla +' I    
  inner join PART P on I.PART_ID=P.ID    
  left join WAREHOUSE_TRANS W on W.WAREHOUSE_ID=I.WAREHOUSE_ID    
  and I.TYPE_DOC=W.DOCUMENT_ID AND I.NUMBER_DOC=W.NUMBER_DOCUMENT WHERE PART_ID<>''N0005'' ORDER BY IS_IN_OUT,NUMBER_DOC'    
  exec sp_executesql @STRquery,N'@pc nvarchar(80),@opcion char(1)',    
        @pc,@opcion    
  end    
--select * from tempdb.dbo.DEVELOPER03INVENTORY  
--exec dbo.INV_RPT_INVENTARIO_VAL_MENSUAL 'DEVELOPER03INVENTORY', '5', '  ', '    ', '                    ', '                    ',   
--'    ', '      ', '      '  
--select * from inventory where part_id='R0001'  
--select * from inventory where part_id='E0001'