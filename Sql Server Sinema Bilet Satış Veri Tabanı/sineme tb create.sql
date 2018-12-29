use SinemaDB
create table kullanicilar(
	kId int PRIMARY KEY IDENTITY (1,1) not null,
	kTc varchar(11) not null,
	kAd varchar(255) not null,
	kSoyad varchar(255) not null,
	kEmail varchar(255),
	kParola varchar(255) not null,
	kYetki int not null,
)
create table filmler(
	fId int PRIMARY KEY IDENTITY (1,1) not null,
	fAd varchar(255) not null,
	fAfis varchar(500),
	baslagicTarihi date not null,
	bitisTarihi date not null,
)
create table salon(
	salonId int PRIMARY KEY IDENTITY (1,1) not null,
	salonAd varchar(255) not null,
)
create table seans(
	seansId int PRIMARY KEY IDENTITY (1,1) not null ,
	seansSaat time ,
)
create table ucret(
	ucretId int PRIMARY KEY IDENTITY (1,1) not null,
	ucretFiyat int not null,
	ucretAd varchar(55) not null,
)
create table koltuk(
	koltukId int PRIMARY KEY IDENTITY (1,1) not null,
	koltukHarfNumara varchar(255) not null,
)
create table salonSeans(
	salonSeansId int PRIMARY KEY IDENTITY (1,1) not null,
	fId int FOREIGN KEY REFERENCES filmler(fId),
	seansId int FOREIGN KEY REFERENCES seans(seansId),
	salonId int FOREIGN KEY REFERENCES salon(salonId),
)

create table bilet(
	biletId  int PRIMARY KEY IDENTITY (1,1) not null ,
	biletSatisTarihi date not null,
	biletDurumu varchar(255) not null,
	seyirciAd varchar(255) not null,
	seyirciSoyad  varchar(255)not null,
	odemeTuru varchar(55) not null,
	kId int  FOREIGN KEY REFERENCES kullanicilar(kId),
	koltukId int  FOREIGN KEY REFERENCES koltuk(koltukId),
	seansId int FOREIGN KEY REFERENCES seans(seansId),
	salonId int FOREIGN KEY REFERENCES salon(salonId),
	ucretId int FOREIGN KEY REFERENCES ucret(ucretId),
	fId int FOREIGN KEY REFERENCES filmler(fId),
	filmGun date not null,
	kisiUcreti int not null,
) 

