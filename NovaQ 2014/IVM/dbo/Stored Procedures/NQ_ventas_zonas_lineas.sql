CREATE proc NQ_ventas_zonas_lineas  
@fechaini datetime,  
@fechafin datetime,  
@familiaini varchar(10),  
@familiafin varchar(10),  
@zonaini varchar(10),  
@zonafin varchar(10)  
as  
SELECT C.DESCRIPTION,F.NAME AS FAMILIA,SUM((D.AMOUNT-D.AMOUNT_TAX)) AS SOLES,SUM(D.AMOUNT_TAX) AS IGV,SUM(D.AMOUNT)AS TOTAL    
FROM RECEIVABLE A INNER JOIN CUSTOMER B ON A.CUSTOMER_ID=B.ID  
INNER JOIN MASTER_HELP C ON  B.SELL_ZONE=C.ID  
INNER JOIN RECEIVABLE_LINE D ON A.DOCUMENT_ID=D.DOCUMENT_ID AND A.NUMBER_SERIE=D.NUMBER_SERIE AND   
A.NUMBER_DOCUMENT=D.NUMBER_DOCUMENT  
LEFT JOIN PART E ON D.PART_ID=E.ID   
LEFT JOIN FAMILY F ON E.FAMILY=F.ID  
WHERE DOCUMENT_DATE BETWEEN @fechaini AND @fechafin AND TYPE_ID='28'  
and f.id between @familiaini and @familiafin  
and c.id between @zonaini and @zonafin
AND  A.STATUS='V'    
GROUP BY C.DESCRIPTION,F.NAME  
order by 1