
create table YayinEvi(
	YayýnEviID int IDENTITY(1,1) primary key,
	YayýnEviAd nvarchar(50) not null
)
go
create table Yazar(
	YazarID int IDENTITY(1,1) primary key,
	YazarAd nvarchar(50) not null,
	YazarSoyad nvarchar(50) not null
)
go
create table Kitap(
	KitapID int IDENTITY(1,1) primary key ,
	KitapAd nvarchar(50) not null,
	SayfaSayisi int not null,
	YayimTarihi date not null,
	YazarID int,
	YayýnEviID int,
	foreign key(YazarID) references Yazar(YazarID),
	foreign key(YayýnEviID) references YayinEvi(YayýnEviID)
)
go
create table Bolum(
	BolumID int IDENTITY(1,1) primary key,
	BolumAd nvarchar(50) not null
)
go
create table Birim(
	BirimID int IDENTITY(1,1) primary key,
	BirimAd nvarchar(50) not null
)
go
create table Cinsiyet(
	CinsiyetID int primary key,
	CinsiyetAd nvarchar(20)
)
go
create table Ogrenci(
	OgrenciNO int primary key,
	OgrenciAd nvarchar(50) not null,
	OgrenciSoyad nvarchar(50) not null,
	Cinsiyet int not null,
	BolumID int not null,
	foreign key(Cinsiyet) references Cinsiyet(CinsiyetID),
	foreign key(BolumID) references Bolum(BolumID)
)
go
create table Personel(
	PersonelID int IDENTITY(1,1) primary key,
	PersonelAd nvarchar(50) not null,
	PersonelSoyad nvarchar(50) not null,
	BirimID int not null,
	foreign key(BirimID) references Birim(BirimID)
)
go
create table Kategori(
	KategoriID int IDENTITY(1,1) primary key,
	KategoriAd nvarchar(50) not null
)
go
create table Kiralamalar(
	KiralamaID int IDENTITY(1,1) primary key,
	KiralamaAd nvarchar(50) not null,
	Durum bit default 0,
	Saat time,
	PersonelID int,
	OgrenciNO int,
	foreign key(PersonelID) references Personel(PersonelID),
	foreign key(OgrenciNO) references Ogrenci(OgrenciNO)
)
go
create table Emanet(
	EmanetID int IDENTITY(1,1) primary key,
	AlisTarihi date,
	VerisTarihi date,
	OgrenciNO int,
	KitapID int,
	foreign key(OgrenciNO) references Ogrenci(OgrenciNO),
	foreign key(KitapID) references Kitap(KitapID)
)
go
create table KÝTAP_KATEGORÝ(
	KitapID int,
	KategoriID int,
	foreign key(KitapID) references Kitap(KitapID),
	foreign key(KategoriID) references Kategori(KategoriID)
)
go 
create table Kiralama_Cesit(
	ID int IDENTITY(1,1) primary key,
	ad nvarchar(50),
	
)
go
create table EmanetArsiv(
	EmanetID int  primary key,
	AlisTarihi date,
	VerisTarihi date,
	OgrenciNO int,
	KitapID int,
	foreign key(OgrenciNO) references Ogrenci(OgrenciNO),
	foreign key(KitapID) references Kitap(KitapID)
)
go
create trigger trg_EmanetArsiv on Emanet
after delete
as
insert into EmanetArsiv select * from deleted
go
create view GecKiralama
as 
select Saat from Kiralamalar 
where Saat=(select max(Saat) from Kiralamalar )
go
create procedure sp_Kitap (@ara int)
as
begin
select * from Kitap where KitapID=@ara
end

insert into Cinsiyet values(1,'Erkek')
insert into Cinsiyet values(2,'Kadýn')
insert into Cinsiyet values(3,'Diðer')


insert into Bolum values('Bilgisayar Mühendisliði')
insert into Bolum values('Elektrik-Elektronik Mühendisliði')
insert into Bolum values('Endüstri Mühendisliði')
insert into Bolum values('Havacýlýk ve Uzay Mühendisliði')
insert into Bolum values('Ýnþaat Mühendisliði')
insert into Bolum values('Kimya Mühendisliði')
insert into Bolum values('Makina Mühendisliði')
insert into Bolum values('Mimarlýk')
insert into Bolum values('Matematik')
insert into Bolum values('Moleküler Biyoloji ve Genetik')
insert into Bolum values('Temel Bilimler')
insert into Bolum values('Beslenme ve Diyetetik')
insert into Bolum values('Hemþirelik')
insert into Bolum values('Fizyoterapi ve Rehabilitasyon')
insert into Bolum values('Acil Yardým ve Afet Yönetimi')
insert into Bolum values('Ergoterapi')
insert into Bolum values('Antrenörlük Eðitimi')
insert into Bolum values('Beden Eðitimi ve Spor')
insert into Bolum values('Spor Yöneticiliði')
insert into Bolum values('Felsefe')
insert into Bolum values('Ýngiliz Dili ve Edebiyatý')
insert into Bolum values('Psikoloji')
insert into Bolum values('Tarih')
insert into Bolum values('Türk Dili Ve Edebiyatý')
insert into Bolum values('Ekonometri')
insert into Bolum values('Ýktisat')
insert into Bolum values('Ýþletme')
insert into Bolum values('Saðlýk Yönetimi')

insert into Birim values('Yetkili')
insert into Birim values('Danýþma')
insert into Birim values('Hizmetli')


insert into Kategori values('Tarih');
insert into Kategori values('Kurgu Dýþý');
insert into Kategori values('Polisiye');
insert into Kategori values('Kiþisel Geliþim');
insert into Kategori values('Çocuk');
insert into Kategori values('Kariyer');
insert into Kategori values('Mizah');
insert into Kategori values('Biyografi');
insert into Kategori values('Giriþimcilik');
insert into Kategori values('Kültür');
insert into Kategori values('Psikoloji');
insert into Kategori values('Saðlýk');
insert into Kategori values('Felsefe');
insert into Kategori values('Macera');
insert into Kategori values('Aksiyon');
insert into Kategori values('Politika');
insert into Kategori values('Siyaset');
insert into Kategori values('Bilim');
insert into Kategori values('Sanat');
insert into Kategori values('Romantik');
insert into Kategori values('Komedi');
insert into Kategori values('Gezi');
insert into Kategori values('Toplum');
insert into Kategori values('Aþk');

insert into Yazar values('Zülfü','Livaneli')
insert into Yazar values('Sabahattin','Ali')
insert into Yazar values('Aziz','Nesin')
insert into Yazar values('Peyami','Safa')
insert into Yazar values('Orhan','Kemal')
insert into Yazar values('Sait Faik','Abasýyanýk')
insert into Yazar values('Yaþar','Kemal')
insert into Yazar values('Yusuf','Atýlgan')

insert into YayinEvi values('Doðan Kitabevi')
insert into YayinEvi values('Sözcü Kitabevi')
insert into YayinEvi values('Nesin Yayýnevi')
insert into YayinEvi values('Ötüken Neþriyat')
insert into YayinEvi values('Everest Yayýnlarý')
insert into YayinEvi values('Ýþ Bankasý Kültür Yayýnlarý')
insert into YayinEvi values('Yapý Kredi Yayýnlarý')
insert into YayinEvi values('Can Yayýnlarý')



insert into Kiralama_Cesit values('Çalýþma Odasý 1')
insert into Kiralama_Cesit values('Çalýþma Odasý 2')
insert into Kiralama_Cesit values('Çalýþma Odasý 3')
insert into Kiralama_Cesit values('Çalýþma Odasý 4')
insert into Kiralama_Cesit values('Çalýþma Odasý 5')
insert into Kiralama_Cesit values('Çalýþma Odasý 6')
insert into Kiralama_Cesit values('Çalýþma Odasý 7')
insert into Kiralama_Cesit values('Çalýþma Odasý 8')
insert into Kiralama_Cesit values('Çalýþma Odasý 9')
insert into Kiralama_Cesit values('Çalýþma Odasý 10')
insert into Kiralama_Cesit values('Bilardo 1')
insert into Kiralama_Cesit values('Bilardo 2')
insert into Kiralama_Cesit values('Masa Tenisi 1')
insert into Kiralama_Cesit values('Masa Tenisi 2')

--declare cr_Personel CURSOR 
--for select * from Emanet
--order by EmanetID


