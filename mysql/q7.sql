insert into demo_1
values('abhishek',1)
insert into demo_1
values('abhay',2)

sp_rename 'demo_1.name','e_name','column';

select * from demo_1