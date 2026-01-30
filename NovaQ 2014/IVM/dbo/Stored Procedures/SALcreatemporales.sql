CREATE PROC [dbo].[SALcreatemporales]       
--declare      
@IDE VARCHAR(50)      
--set @IDE='MARCO'      
      
AS      
SET NOCOUNT ON      
SET QUOTED_IDENTIFIER off      
      
if exists (select * from tempdb.dbo.sysobjects where name = 'FK_'+@IDE+'FACWORDET_'+@IDE+'FACWORCAB' and xtype='F')      
BEGIN      
exec('alter table tempdb.dbo.['+@IDE+'FACWORDET] DROP CONSTRAINT FK_'+@IDE+'FACWORDET_'+@IDE+'FACWORCAB')      
END       
      
if exists (select * from tempdb.dbo.sysobjects where name = ''+@IDE+'FACWORDET' and xtype='u')      
BEGIN      
exec('drop table tempdb.dbo.['+@IDE+'FACWORDET]')      
END      
      
if exists (select * from tempdb.dbo.sysobjects where name = ''+@IDE+'FACWORCAB' and xtype='u')      
BEGIN      
exec('drop table tempdb.dbo.['+@IDE+'FACWORCAB]')      
END      
      
if exists (select * from tempdb.dbo.sysobjects where name = ''+@IDE+'TEMPOFAC01' and xtype='u')      
BEGIN      
exec('drop table tempdb.dbo.['+@IDE+'TEMPOFAC01]')      
END      
      
exec('CREATE TABLE tempdb.dbo.['+@IDE+'FACWORCAB] (      
 [CFSISTEM] [varchar] (1)  NULL ,      
 [CFNUMPED] [varchar] (7)  NOT NULL ,      
 [CFPUNVEN] [varchar] (2)  NULL ,      
 [CFTD] [varchar] (2)  NULL ,      
 [CFNUMSER] [varchar] (3)  NULL ,      
 [CFNUMDOC] [varchar] (7)  NULL ,      
 [CFFECDOC] [datetime] NULL ,      
 [CFFECVEN] [datetime] NULL ,      
 [CFCOTIZA] [varchar] (10)  NULL ,      
 [CFNROPED] [varchar] (10)  NULL ,      
 [CFORDCOM] [varchar] (20)  NULL ,      
 [CFDESCPG] [varchar] (50)  NULL ,      
 [CFPTORIG] [varchar] (50)  NULL ,      
 [CFPTOEMB] [varchar] (50)  NULL ,      
 [CFPTODES] [varchar] (50)  NULL ,      
 [CFDH] [varchar] (1)  NULL ,      
 [CFVENDE] [varchar] (2)  NULL ,      
 [CFCODMOV] [varchar] (2)  NULL ,      
 [CFCODCLI] [varchar] (11)  NULL ,      
 [CFNOMBRE] [varchar] (150)  NULL ,      
 [CFDIRECC] [varchar] (150)  NULL ,      
 [CFRUC] [varchar] (11)  NULL ,      
 [CFALMA] [varchar] (2)  NULL ,      
 [CFIMPORTE] [numeric](15, 6) NULL ,      
 [CFPORDESCL] [numeric](15, 6) NULL ,      
 [CFPORDESES] [numeric](15, 6) NULL ,      
 [CFFORVEN] [varchar] (4)  NULL ,      
 [CFSALDO] [numeric](15, 6) NULL ,      
 [CFTIPCAM] [numeric](15, 6) NULL ,      
 [CFCODMON] [varchar] (2)  NULL ,      
 [CFRFTD] [varchar] (2)  NULL ,      
 [CFRFNUMSER] [varchar] (3)  NULL ,      
 [CFRFNUMDOC] [varchar] (7)  NULL ,      
 [CFFECCRE] [datetime] NULL ,      
 [CFESTADO] [varchar] (1)  NULL ,      
 [CFUSER] [varchar] (8)  NULL ,      
 [CFGLOSA] [varchar] (80)  NULL ,      
 [CFFACGUI] [varchar] (1)  NULL ,      
 [CFIGV] [numeric](15, 6) NULL ,      
 [CFDESCTOV] [numeric](15, 6) NULL ,      
 [CFDESCTOP] [numeric](15, 6) NULL ,      
 [CFTEXGUIA] [varchar] (64)  NULL ,      
 [CFTIPFAC] [varchar] (2)  NULL ,      
 [CFDESVAL] [numeric](15, 6) NULL ,      
 [CFLISEMP] [varchar] (7)  NULL,
 [CFISC] [FLOAT]         
) ON [PRIMARY]')      
      
exec('CREATE TABLE tempdb.dbo.['+@IDE+'FACWORDET] (      
 [DFSISTEM] [varchar] (1)  NULL ,      
 [DFNUMPED] [varchar] (7)  NOT NULL ,      
 [DFSECUEN] [varchar] (3)  NOT NULL ,      
 [DFCODIGO] [varchar] (20)  NOT NULL ,      
 [DFUNIDAD] [varchar] (6)  NULL ,      
 [DFCANTID] [numeric](15, 6) NULL ,      
 [DFPREC_VEN] [numeric](15, 6) NULL ,      
 [DFPREC_ORI] [numeric](15, 6) NULL ,      
 [DFPORDES] [numeric](15, 6) NULL ,      
 [DFDESCTO] [numeric](15, 6) NULL ,      
 [DFIGV] [numeric](15, 6) NULL ,      
 [DFIGVPOR] [numeric](15, 6) NULL ,      
 [DFIMPUS] [numeric](15, 6) NULL ,      
 [DFIMPMN] [numeric](15, 6) NULL ,      
 [DFESTADO] [varchar] (1)  NULL ,      
 [DFSERIE] [varchar] (20)  NULL ,      
 [DFALMA] [varchar] (2)  NULL ,      
 [DFTEXTO] [varchar] (50)  NULL ,      
 [DFSTOCK] [varchar] (1)  NULL ,      
 [DFTR] [varchar] (1)  NULL ,      
 [DFDESCRI] [varchar] (64)  NULL ,      
 [DFCANREF] [numeric](15, 6) NULL ,      
 [DFDESCLI] [numeric](15, 6) NULL ,      
 [DFDESESP] [numeric](15, 6) NULL ,      
 [DFPRESUP] [varchar] (20)  NULL ,      
 [DFORDEN] [varchar] (20)  NULL ,      
 [DFLOTE] [varchar] (20)  NULL ,      
 [DFGUIA] [varchar] (10)  NULL ,      
 [DFARTIGV] [bit] NOT NULL ,      
 [DFDESCTO1] [numeric](15, 6) NULL ,      
 [DFDESCTO2] [numeric](15, 6) NULL ,      
 [DFPOR1] [numeric](15, 6) NULL ,      
 [DFPOR2] [numeric](15, 6) NULL ,      
 [DFCODLIS] [varchar] (2)  NULL ,      
 [DFEPQ][varchar](4) NULL ,      
 [DFPRESU][varchar](20) NULL ,      
 [DFORD][varchar](20) NULL ,      
 [DFCANTBRUTA][numeric](15, 6) NULL ,      
 [DFDSCTCANTBRUTA][numeric](15, 6) NULL ,      
 [UMREFERENCIA][varchar](6) NULL ,      
 [CANTREFERENCIA][numeric](15, 6) NULL ,      
 [DEREFERENCIA][varchar](50) NULL ,    
 [DFCOSTO][numeric](15, 6) NULL ,   
 [COMISION][numeric](15, 6) NULL ,   
 [TIPOISC][FLOAT] NULL ,    
 [ISCPOR][FLOAT] NULL ,   
 [ISC][FLOAT] NULL    
) ON [PRIMARY]')      
      
exec('ALTER TABLE tempdb.dbo.['+@IDE+'FACWORCAB] WITH NOCHECK ADD       
 CONSTRAINT [DF_'+@IDE+'FACWORCAB_CFIMPORTE] DEFAULT (0) FOR [CFIMPORTE],      
 CONSTRAINT [DF_'+@IDE+'FACWORCAB_CFPORDESCL] DEFAULT (0) FOR [CFPORDESCL],      
 CONSTRAINT [DF_'+@IDE+'FACWORCAB_CFPORDESES] DEFAULT (0) FOR [CFPORDESES],      
 CONSTRAINT [DF_'+@IDE+'FACWORCAB_CFSALDO] DEFAULT (0) FOR [CFSALDO],      
 CONSTRAINT [DF_'+@IDE+'FACWORCAB_CFTIPCAM] DEFAULT (0) FOR [CFTIPCAM],      
 CONSTRAINT [DF_'+@IDE+'FACWORCAB_CFIGV] DEFAULT (0) FOR [CFIGV],      
 CONSTRAINT [DF_'+@IDE+'FACWORCAB_CFDESCTOV] DEFAULT (0) FOR [CFDESCTOV],      
 CONSTRAINT [DF_'+@IDE+'FACWORCAB_CFDESCTOP] DEFAULT (0) FOR [CFDESCTOP],      
 CONSTRAINT [DF_'+@IDE+'FACWORCAB_CFDESVAL] DEFAULT (0) FOR [CFDESVAL]')      
      
exec('ALTER TABLE tempdb.dbo.['+@IDE+'FACWORDET] WITH NOCHECK ADD       
 CONSTRAINT [DF_'+@IDE+'FACWORDET_DFCANTID] DEFAULT (0) FOR [DFCANTID],      
 CONSTRAINT [DF_'+@IDE+'FACWORDET_DFPREC_VEN] DEFAULT (0) FOR [DFPREC_VEN],      
 CONSTRAINT [DF_'+@IDE+'FACWORDET_DFPREC_ORI] DEFAULT (0) FOR [DFPREC_ORI],      
 CONSTRAINT [DF_'+@IDE+'FACWORDET_DFPORDES] DEFAULT (0) FOR [DFPORDES],      
 CONSTRAINT [DF_'+@IDE+'FACWORDET_DFDESCTO] DEFAULT (0) FOR [DFDESCTO],      
 CONSTRAINT [DF_'+@IDE+'FACWORDET_DFIGV] DEFAULT (0) FOR [DFIGV],      
 CONSTRAINT [DF_'+@IDE+'FACWORDET_DFIGVPOR] DEFAULT (0) FOR [DFIGVPOR],      
 CONSTRAINT [DF_'+@IDE+'FACWORDET_DFIMPUS] DEFAULT (0) FOR [DFIMPUS],      
 CONSTRAINT [DF_'+@IDE+'FACWORDET_DFIMPMN] DEFAULT (0) FOR [DFIMPMN],      
 CONSTRAINT [DF_'+@IDE+'FACWORDET_DFCANREF] DEFAULT (0) FOR [DFCANREF],      
 CONSTRAINT [DF_'+@IDE+'FACWORDET_DFDESCLI] DEFAULT (0) FOR [DFDESCLI],      
 CONSTRAINT [DF_'+@IDE+'FACWORDET_DFDESESP] DEFAULT (0) FOR [DFDESESP],      
 CONSTRAINT [DF_'+@IDE+'FACWORDET_DFARTIGV] DEFAULT (0) FOR [DFARTIGV],      
 CONSTRAINT [DF_'+@IDE+'FACWORDET_DFDESCTO1] DEFAULT (0) FOR [DFDESCTO1],      
 CONSTRAINT [DF_'+@IDE+'FACWORDET_DFDESCTO2] DEFAULT (0) FOR [DFDESCTO2],      
 CONSTRAINT [DF_'+@IDE+'FACWORDET_DFPOR1] DEFAULT (0) FOR [DFPOR1],      
 CONSTRAINT [DF_'+@IDE+'FACWORDET_DFPOR2] DEFAULT (0) FOR [DFPOR2],      
 CONSTRAINT [DF_'+@IDE+'FACWORDET_DFCANTBRUTA] DEFAULT (0) FOR [DFCANTBRUTA],      
 CONSTRAINT [DF_'+@IDE+'FACWORDET_DFDSCTCANTBRUTA] DEFAULT (0) FOR [DFDSCTCANTBRUTA],      
 CONSTRAINT [DF_'+@IDE+'FACWORDET_DFCOSTO] DEFAULT (0) FOR [DFCOSTO],    
 CONSTRAINT [DF_'+@IDE+'FACWORDET_CANTREFERENCIA] DEFAULT (0) FOR [CANTREFERENCIA]')      
      
      
exec('ALTER TABLE tempdb.dbo.['+@IDE+'FACWORCAB] WITH NOCHECK ADD       
 CONSTRAINT [PK_'+@IDE+'FACWORCAB] PRIMARY KEY  CLUSTERED       
 ([CFNUMPED]) ON [PRIMARY]')      
      
exec('ALTER TABLE tempdb.dbo.['+@IDE+'FACWORDET] WITH NOCHECK ADD       
 CONSTRAINT [PK_'+@IDE+'FACWORDET] PRIMARY KEY  CLUSTERED       
 ([DFNUMPED],[DFSECUEN],[DFCODIGO])  ON [PRIMARY]')      
      
  
exec('CREATE TABLE tempdb.dbo.['+@IDE+'TEMPOFAC01] (      
 [DFNUMPED] [varchar] (7)  NOT NULL ,      
 [DFSECUEN] [varchar] (3)  NOT NULL ,      
 [DFCODIGO] [varchar] (20)  NOT NULL ,      
 [DFDESCRI] [varchar] (50)  NULL ,      
 [DFCANTID] [numeric](15, 6) NULL ,      
 [DFPREC_VEN] [numeric](15, 6) NULL ,      
 [DFPREC_ORI] [numeric](15, 6) NULL ,      
 [DFFECDOC] [datetime] NULL ,      
 [DFDESCTO] [numeric](15, 6) NULL ,      
 [DFPORDES] [numeric](15, 6) NULL ,      
 [DFIGV] [numeric](15, 6) NULL ,      
 [DFIGVPOR] [int] NULL ,      
 [DFIMPUS] [numeric](15, 6) NULL ,      
 [DFIMPMN] [numeric](15, 6) NULL ,      
 [DFDESCLI] [numeric](15, 6) NULL ,      
 [DFDESESP] [numeric](15, 6) NULL ,      
 [DFUNIDAD] [varchar] (6)  NULL ,      
 [DFSERIE] [varchar] (20)  NULL ,      
 [DFLOTE] [varchar] (20)  NULL ,      
 [DFALMA] [varchar] (2)  NULL ,      
 [DFTEXTO] [varchar] (50)  NULL ,      
 [DFTR] [varchar] (1)  NULL ,      
 [DFARTIGV] [bit] NULL ,      
 [UMREFERENCIA] [varchar] (6)  NULL ,      
 [CANTREFERENCIA] [numeric](15, 6) NULL ,      
 [DFORDEN] [varchar] (20)  NULL,
 [DFISCPOR] NUMERIC(18,6),
 [DFISC] NUMERIC(18,6),
 [DFTIPOISC] NUMERIC(18,6)       
) ON [PRIMARY]')      
      
exec('ALTER TABLE tempdb.dbo.['+@IDE+'TEMPOFAC01] WITH NOCHECK ADD       
 CONSTRAINT [PK_'+@IDE+'TEMPOFAC01] PRIMARY KEY  CLUSTERED       
 ([DFNUMPED],[DFSECUEN],[DFCODIGO])  ON [PRIMARY] ')      
      
exec('ALTER TABLE tempdb.dbo.['+@IDE+'TEMPOFAC01] WITH NOCHECK ADD       
 CONSTRAINT [DF_'+@IDE+'TEMPOFAC01_DFCANTID] DEFAULT (0) FOR [DFCANTID],      
 CONSTRAINT [DF_'+@IDE+'TEMPOFAC01_DFPREC_VEN] DEFAULT (0) FOR [DFPREC_VEN],      
 CONSTRAINT [DF_'+@IDE+'TEMPOFAC01_DFPREC_ORI] DEFAULT (0) FOR [DFPREC_ORI],      
 CONSTRAINT [DF_'+@IDE+'TEMPOFAC01_DFDESCTO] DEFAULT (0) FOR [DFDESCTO],      
 CONSTRAINT [DF_'+@IDE+'TEMPOFAC01_DFPORDES] DEFAULT (0) FOR [DFPORDES],      
 CONSTRAINT [DF_'+@IDE+'TEMPOFAC01_DFIGV] DEFAULT (0) FOR [DFIGV],      
 CONSTRAINT [DF_'+@IDE+'TEMPOFAC01_DFIGVPOR] DEFAULT (0) FOR [DFIGVPOR],      
 CONSTRAINT [DF_'+@IDE+'TEMPOFAC01_DFIMPUS] DEFAULT (0) FOR [DFIMPUS],      
 CONSTRAINT [DF_'+@IDE+'TEMPOFAC01_DFIMPMN] DEFAULT (0) FOR [DFIMPMN],      
 CONSTRAINT [DF_'+@IDE+'TEMPOFAC01_DFDESCLI] DEFAULT (0) FOR [DFDESCLI],      
 CONSTRAINT [DF_'+@IDE+'TEMPOFAC01_DFDESESP] DEFAULT (0) FOR [DFDESESP],      
 CONSTRAINT [DF_'+@IDE+'TEMPOFAC01_DFARTIGV] DEFAULT (0) FOR [DFARTIGV],      
 CONSTRAINT [DF_'+@IDE+'TEMPOFAC01_CANTREFERENCIA] DEFAULT (0) FOR [CANTREFERENCIA]')
