CREATE procedure [dbo].[INV_REP_ANALISIS_FAMILIA_DETALLE]  
-- declare  
 @pc nvarchar(80)  
/*set @pc='developer03'  
--*/as  
 declare @tabla nvarchar(100)  
 declare @tabla1 nvarchar(100)  
 declare @tabla2 nvarchar(100)  
 declare @STRquery nvarchar(2000)  
 begin  
  set @tabla=N'[tempdb].dbo.'+@pc+'MOVI_ANALISIS'  
  set @tabla1=N'[tempdb].dbo.'+@pc+'SALINI_FAM'  
  set @tabla2=N'[tempdb].dbo.'+@pc+'SALINIXFAM'  
 end  
 set @STRquery='select F.ID,F.NAME,M.FAMILY,M.type_trans,M.TRANS_ID,M.CURRENCY_TYPE,M.DOCUMENT_ID,  
    M.NUMBER_DOCUMENT,M.DATE_DOCUMENT,M.PART_ID,M.QTY,M.AMOUNT,M.AMOUNT_US,  
    SF.SALDOCANT as SALDOCANT_SF,SF.SALDOMN as SALDOMN_SF,SF.SALDOME as SALDOME_SF,  
    S.SALDOCANT,S.SALDOMN,S.SALDOME,  
    T.NAME as NAME_T  
   from FAMILY F  
    inner join '+@tabla+ ' M  
     on F.ID=M.FAMILY  
    left join '+@tabla1+ ' sf  
     on SF.FAMILY=M.FAMILY  
    left join '+@tabla2+ ' s  
     on M.FAMILY=S.FAMILY and M.TYPE_TRANS=S.TYPE_TRANS and M.TRANS_ID=S.TRANS_ID  
    inner join TRANSACTION_TYPE T   
     on M.TYPE_TRANS=T.TYPE_ID and M.TRANS_ID=T.MOV_ID'  
  
 exec sp_executesql @STRquery,N'@pc nvarchar(80)',@pc  
