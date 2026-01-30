create procedure sp_actstk
@part_id varchar(50),
@who_id varchar(20)
as
update p set p.qty_on_hand=l.suma
from part_qty as p inner join (select sum(qty_on_hand) as suma,part_id,who_id from lot where part_id=@part_id group by part_id,who_id)l on l.who_id=p.warehouse_id
and p.part_id=l.part_id
where l.part_id=@part_id AND L.who_id=@who_id
