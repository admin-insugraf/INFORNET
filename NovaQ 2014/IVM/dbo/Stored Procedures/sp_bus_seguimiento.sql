

CREATE PROCEDURE [dbo].[sp_bus_seguimiento]
@fecini  as datetime ,
@fecfin as datetime
as
select
s.IdSeg ,s.NomProT , s.LocalOcu , s.DirecOcu , s.FecOcu , s.MovSol , s.MovDol , s.Stado,
 s.EmailAddress , s.Phone , s.Fax ,
d.Contac1 , d.Contac2 , d.Contac3 , d.DesConsultor , d.DesGeneral , d.Phone ,
d.Phone1 , d.Phone2 , d.movil , d.movil1 , d.movil2 , d.EmailAddress3 , d.EmailAddress1 , d.EmailAddress2 , d.EmailAddress,
o.Descri, (u.FirstName + '  ' + u.LastName) as FirstName, u.LastName ,c.VAT_REGISTRATION,c.NAME

from Ocurrencia_Cli o
inner join Seguimiento s
on s.IdOcu=o.IdOcu
inner join User_Seguimientos u
on s.IdUser=u.IdUser
inner join Detalle_Contac d
on d.IdSeg=s.IdSeg
inner join CUSTOMER c
on s.ID=c.VAT_REGISTRATION
where s.FecOcu between @fecini and @fecfin and s.Stado='Vigente'
--where s.FecOcu between '06/10/2008' and GETDATE() and s.Stado='Vigente'

IF @@ERROR <> 0
          ROLLBACK TRANSACTION
ELSE
          COMMIT TRANSACTION


