create table Donor(
ime varchar(50) not null,
prezime varchar(50) not null,
oib varchar (11) not null,
datum_rodenja datetime not null, 
grad varchar (50),
br_mobitela varchar (15),
datum datetime not null,
krvna_grupa varchar (3) not null,
spol int not null,
ID int primary key identity (1,1)
);

create procedure get_donor(@oib varchar (11))
as begin
select * from Donor with (nolock)
where oib= @oib;
end

declare @datum datetime = getdate();
insert into Donor values('Hrvoje', 'Horvat', '00000000001', '02.12.1990', 'Zagreb', '0038598123456', @datum, 'ap', 1)

exec get_donor '00000000001'