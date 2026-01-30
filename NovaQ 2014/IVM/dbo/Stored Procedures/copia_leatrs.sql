CREATE PROCEDURE copia_leatrs
 AS
declare @number_doc varchar(15)
declare @a int
declare cursor1 cursor for

SELECT number_doc  
FROM drog_prueba.dbo.LETTER_EXCHANGE_LINE l inner join receivable r
on l.number_doc=r.number_serie+r.number_document
where document_date>='01/08/2010'
order by document_date
open cursor1
fetch next from cursor1
into @number_doc
while @@fetch_status=0
begin
	select @a=number_doc from LETTER_EXCHANGE_LINE where number_doc=@number_doc
	if @a is null
	begin
		insert into  LETTER_EXCHANGE_LINE select * from drog_prueba.dbo.LETTER_EXCHANGE_LINE where number_doc=@number_doc
	end
fetch next from cursor1
into @number_doc
end
close cursor1
deallocate cursor1