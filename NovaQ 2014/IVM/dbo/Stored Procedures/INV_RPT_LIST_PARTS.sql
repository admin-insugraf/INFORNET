CREATE procedure [dbo].[INV_RPT_LIST_PARTS]
	--declare
	@codini varchar(20),
	@codfin varchar(20),
	@descripcion char(1),
	@famini varchar(8),
	@famfin varchar(8),
	@codfabini varchar(40),
	@codfabfin varchar(40),
	@tippart varchar(2)
/*set @codini=''
set @codfin=''
set	@descripcion=''
set	@famini='02'
set	@famfin='02'
set @codfabini=''
set	@codfabfin=''
set @tippart=''
--*/as
	declare @STRquery nvarchar(1000)
	declare @criterio nvarchar(1000)
	SET @criterio=N' WHERE 1=1'	
    

	if not len(@codini)=0 and not len(@codfin)=0
		set @criterio=@criterio + N' and P.ID between @codini and @codfin order by P.ID'
    
	if not len(@descripcion)=0
		set @criterio=@criterio + N' order by P.DESCRIPTION'

	if not len(@famini)=0 and not len(@famfin)=0
		set @criterio=@criterio + N' and F.ID between @famini and @famfin order by P.ID'

	if not len(@codfabini)=0 and not len(@codfabfin)=0
		set @criterio=@criterio + N' and P.ID_FAB between @codfabini and @codfabfin order by P.ID'

	if not len(@tippart)=0
		set @criterio=@criterio + N' and P.TYPE_PART=@tippart'

	--Armo select simple
	set @STRquery='Select P.ID,P.ID_FAB,P.DESCRIPTION,P.DESCRIPTION_OPT,P.FAMILY,P.MODEL
				,P.UNIT_OF_MEASUREMENT,P.GROUP_ID,P.ACCOUNT,P.SERIES,P.UNIT_PRICE,P.LOCATION
				,P.IS_STOCKED,P.STATUS,P.CURRENCY_ID,P.TYPE_PART,P.COMMENT,P.IS_LOT
				from PART P'
	--Armo el select, solo hace un inner caso sea familia
	if not len(@famini)=0 and not len(@famfin)=0
		set @STRquery='Select P.ID,P.ID_FAB,P.DESCRIPTION,P.DESCRIPTION_OPT,P.FAMILY,P.MODEL
				,P.UNIT_OF_MEASUREMENT,P.GROUP_ID,P.ACCOUNT,P.SERIES,P.UNIT_PRICE,P.LOCATION
				,P.IS_STOCKED,P.STATUS,P.CURRENCY_ID,P.TYPE_PART,P.COMMENT,P.IS_LOT,F.NAME AS NOMFAMILIA,
				L.NAME AS NOMLINEA,G.NAME AS NOMGROUP
				from PART P inner join FAMILY F on P.FAMILY=F.ID 
				left join LINES L on P.MODEL=L.ID and F.ID=L.FAMILY_ID
				left join GROUPS G ON P.GROUP_ID=G.ID and P.FAMILY=G.FAMILY_ID and P.MODEL=G.LINE_ID'

	--Armo el select, solo hace un inner caso sea por tipo de artículo
	if not len(@tippart)=0
		set @STRquery='Select P.ID,P.ID_FAB,P.DESCRIPTION,P.DESCRIPTION_OPT,P.FAMILY,P.MODEL
				,P.UNIT_OF_MEASUREMENT,P.GROUP_ID,P.ACCOUNT,P.SERIES,P.UNIT_PRICE,P.LOCATION
				,P.IS_STOCKED,P.STATUS,P.CURRENCY_ID,P.TYPE_PART,P.COMMENT,P.IS_LOT,PT.NAME
				from PART P inner join PART_TYPE PT on P.TYPE_PART=PT.ID'

	
	--Concateno segun filtro de criterio	
	set @STRquery=@STRquery + @criterio
	exec sp_executesql @STRquery,N'@codini varchar(20),@codfin varchar(20),@descripcion char(1),
							@famini varchar(8),@famfin varchar(8),@codfabini varchar(40),
							@codfabfin varchar(40),@tippart varchar(2)',
							@codini,@codfin,@descripcion,@famini,@famfin,
							@codfabini,@codfabfin,@tippart      
      
      
      
      

