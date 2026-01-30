/****** Objeto:  procedimiento  almacenado dbo.sp_existebasededatos    fecha de la secuencia de comandos: 15/10/2002 11:10:50 AM ******/
/* Verfica que la base de datos este creada */
CREATE PROCEDURE [dbo].[existebasededatos] 
@basededatos varchar(30)='%'
as
select name,crdate,filename from master.dbo.sysdatabases where name like @basededatos
