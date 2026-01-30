
CREATE VIEW dbo.vwPlanillaChe 
AS 
SELECT CHECK_EXCHANGE.*,SOLES=CASE WHEN currency_id='MN' THEN amount ELSE 0 END,DOLARES=CASE 
WHEN currency_id='ME' THEN amount ELSE 0 END,customer.name AS cliente From CHECK_EXCHANGE 
INNER JOIN    customer ON customer.id = customer_id
