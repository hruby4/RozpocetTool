delimiter //

create trigger use_code
before delete on rozpocet_tool.code
for each row
insert into used_code(c) values(old.c);
//
delimiter ;


create table rozpocet(
id int primary key auto_increment,
user_id int not null references user(id),
datum date not null
);



create table produkt(
nazev varchar(255) primary key,
rozpocet_id int not null references rozpocet(id),
druh varchar(20) not null,
ks_kg_m varchar(2) not null,
pocet double not null
);

select rozpocet.datum, produkt.nazev,produkt.cena,produkt.pocet,produkt.jednotka from produkt
inner join rozpocet on rozpocet.id = produkt.rozpocet_id;

