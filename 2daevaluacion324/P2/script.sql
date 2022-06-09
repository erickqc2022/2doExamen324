create table seguimiento
(
notramite integer,
usuario varchar(10),
flujo varchar(3),
proceso varchar(3),
fechainicio datetime,
fechafin datetime
)

insert into seguimiento values(100,'Moises','F1','P1','2021/10/13 10:00','2021/10/13 12:00');
insert into seguimiento values(100,'Moises','F1','P2','2021/10/13 12:00',null);
insert into seguimiento values(101,'German','F1','P1','2021/10/13 10:00','2021/10/13 12:00');
insert into seguimiento values(101,'German','F1','P2','2021/10/13 12:00',null);
insert into seguimiento values(102,'Melany','F2','P1','2021/10/13 08:00','2021/10/13 10:00');


create usuarios
(
usuario varchar(10),
contrasenia varchar(10),
rol varchar(10)
)

insert into usuarios values('Moises','123456','E');
insert into usuarios values('German','123456','E');
insert into usuarios values('Melany','123456','K')