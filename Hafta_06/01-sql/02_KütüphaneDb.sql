/*
KutuphaneDb adýnda bir veri tabaný oluþturunuz.
TABLOLAR: turler, yazarlar,yayýnevleri,üyeler,kitaplar,oduncýslermleri

*/

USE MASTER
GO

DROP DATABASE IF EXISTS KutuphaneDb
GO

CREATE DATABASE KutuphaneDb
GO	


USE KutuphaneDb
-- TÜRLER TABLOSU--
CREATE TABLE Turler(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	tur NVARCHAR(30) NOT NULL
)
GO

INSERT INTO Turler VALUES
('Macera'),
('Polisiye'),
('Aþk'),
('Ütopik'),
('Bilim-Kurgu'),
('Fizik'),
('Kimya'),
('Ansiklopedi'),
('Matematik')

GO




--YAZARLAR TABLOSU--
CREATE TABLE Yazarlar(
		id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
		adSoyad NVARCHAR(50) NOT NULL,
		
		telefon CHAR(11),
		
)
GO
INSERT INTO Yazarlar (adSoyad) VALUES
('Ali Veli'),
('Kemal Erol'),
('Mert Muslu'),
('Ahmet Candan'),
('Sevda Yer'),
('Rýza Soylu'),
('Gamze Yýlmaz,'),
('Sefa Görür'),
('Hande Ay'),
('Semiha Güler')
GO



--YAYÝNEVLERÝ TABOLSU--

CREATE TABLE Yayinevleri (
		id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
		ad NVARCHAR(50) NOT NULL,
		sehir NVARCHAR(30),
		telefon CHAR(11),
	

		
)
GO

INSERT INTO Yayinevleri VALUES
('Gülen Gözler','Ýstanbul','02124578787'),
('Okuyalým Beraber','Ýzmir',''),
('Nexus Yayýnevi','Bursa',''),
('Pegem','Ýstanbul',''),
('Beyaz Günler','Antalya',''),
('Yeni Sayfa','Yalova','02267451515'),
('Genç Okur','Ankara',''),
('Kardelenler','Ýstanbul','02123336565'),
('Atlas','Ýzmit','')
GO


--KÝTAPLAR TABLOSU--

CREATE TABLE Kitaplar (
		id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
		kitapAdi NVARCHAR(50) NOT NULL,
		yazarId INT,
		yayýneviId INT,
		turId INT DEFAULT 1 FOREIGN KEY REFERENCES Turler(id) ON DELETE SET DEFAULT,
		FOREIGN KEY (yazarId) REFERENCES Yazarlar(id),
		FOREIGN KEY (yayýneviId) REFERENCES Yayinevleri(id) ON DELETE CASCADE


)
GO
INSERT INTO Kitaplar VALUES


('Ölüm Kalým',1,1,1),
('Yarýnýn Sýnýrýnda',2,2,2),
('Harry Potter',3,4,4),
('Yüzüklerin Efendisi',5,5,5),
('Timsah',6,6,6),
('Beyaz Zambak',7,7,7),
('Kurtlar Sofrasý',8,8,8)

GO



--ÜYELER TABOLSU--

CREATE TABLE Uyeler (
		id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
		adSoyad NVARCHAR(50) NOT NULL,
		telefon CHAR(11),
		sehir NVARCHAR(30)
	
)
GO
INSERT INTO Uyeler (adSoyad,sehir) VALUES

	('Kaan Yýlmaz','Ýstanbul'),
	('Mert Muslu','Yalova'),
	('Emre Hikmet','Bursa'),
	('Songül Arslan','Ýstanbul'),
	('Harun Özer','Eskiþehir'),
	('Kemal Erol','Gaziantep'),
	('Yasin Þen','Bursa'),
	('Ýlhan Bayar','Ýzmir'),
	('Nazlý Yýlmaz','Çanakkale'),
	('Tuðba Çakýr','Balýkesir'),
	('Damla Koca','Ankara'),
	('Onur Muslu','Ýstanbul')
	
	GO

	CREATE TABLE Islemler(
		
				id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
				uyeÝd INT,
				kitapId INT,			
				alisTarih DATE NOT NULL,
				verisTarih DATE NOT NULL,
	)

	GO

	INSERT INTO Islemler VALUES 

	(1,1,'2022-02-02','2022-03-03'),
	(1,2,'2022-02-02','2022-03-03'),
	(1,3,'2022-02-02','2022-03-03'),
	(2,4,'2022-02-02','2022-03-03'),
	(2,1,'2022-02-02','2022-03-03'),
	(3,5,'2022-02-02','2022-03-03'),
	(4,6,'2022-02-02','2022-03-03'),
	(4,7,'2022-02-02','2022-03-03'),
	(5,10,'2022-02-02','2022-03-03'),
	(6,16,'2022-02-02','2022-03-03'),
	(12,9,'2022-02-02','2022-03-03'),
	(10,10,'2022-02-02','2022-03-03'),
	(8,8,'2022-02-02','2022-03-03'),
	(8,11,'2022-02-02','2022-03-03')

