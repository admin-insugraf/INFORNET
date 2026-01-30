
create  PROCEDURE [dbo].[LISTA_DOCU]
AS
select distinct TYPE_DOC from NUMBER_DOCUMENT 
where TYPE_DOC not in('ct','gs','lt','pd','wk','AJ','ll','lv','AA')


