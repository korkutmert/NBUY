/*
KutuphaneDb ad�nda bir veri taban� olu�turunuz.
TABLOLAR: turler, yazarlar,yay�nevleri,�yeler,kitaplar,odunc�slermleri

*/

USE MASTER
GO

DROP DATABASE IF EXISTS KutuphaneDb
GO

CREATE DATABASE KutuphaneDb
GO	


USE KutuphaneDb
-- T�RLER TABLOSU--
CREATE TABLE Turler(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	tur NVARCHAR(30) NOT NULL
)
GO

INSERT INTO Turler VALUES
('Macera'),
('Polisiye'),
('A�k'),
('�topik'),
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
('R�za Soylu'),
('Gamze Y�lmaz,'),
('Sefa G�r�r'),
('Hande Ay'),
('Semiha G�ler')
GO



--YAY�NEVLER� TABOLSU--

CREATE TABLE Yayinevleri (
		id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
		ad NVARCHAR(50) NOT NULL,
		sehir NVARCHAR(30),
		telefon CHAR(11),
	

		
)
GO

INSERT INTO Yayinevleri VALUES
('G�len G�zler','�stanbul','02124578787'),
('Okuyal�m Beraber','�zmir',''),
('Nexus Yay�nevi','Bursa',''),
('Pegem','�stanbul',''),
('Beyaz G�nler','Antalya',''),
('Yeni Sayfa','Yalova','02267451515'),
('Gen� Okur','Ankara',''),
('Kardelenler','�stanbul','02123336565'),
('Atlas','�zmit','')
GO


--K�TAPLAR TABLOSU--

CREATE TABLE Kitaplar (
		id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
		kitapAdi NVARCHAR(50) NOT NULL,
		yazarId INT,
		yay�neviId INT,
		turId INT DEFAULT 1 FOREIGN KEY REFERENCES Turler(id) ON DELETE SET DEFAULT,
		FOREIGN KEY (yazarId) REFERENCES Yazarlar(id),
		FOREIGN KEY (yay�neviId) REFERENCES Yayinevleri(id) ON DELETE CASCADE


)
GO
INSERT INTO Kitaplar VALUES


('�l�m Kal�m',1,1,1),
('Yar�n�n S�n�r�nda',2,2,2),
('Harry Potter',3,4,4),
('Y�z�klerin Efendisi',5,5,5),
('Timsah',6,6,6),
('Beyaz Zambak',7,7,7),
('Kurtlar Sofras�',8,8,8)

GO



--�YELER TABOLSU--

CREATE TABLE Uyeler (
		id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
		adSoyad NVARCHAR(50) NOT NULL,
		telefon CHAR(11),
		sehir NVARCHAR(30)
	
)
GO
INSERT INTO Uyeler (adSoyad,sehir) VALUES

	('Kaan Y�lmaz','�stanbul'),
	('Mert Muslu','Yalova'),
	('Emre Hikmet','Bursa'),
	('Song�l Arslan','�stanbul'),
	('Harun �zer','Eski�ehir'),
	('Kemal Erol','Gaziantep'),
	('Yasin �en','Bursa'),
	('�lhan Bayar','�zmir'),
	('Nazl� Y�lmaz','�anakkale'),
	('Tu�ba �ak�r','Bal�kesir'),
	('Damla Koca','Ankara'),
	('Onur Muslu','�stanbul')
	
	GO

	CREATE TABLE Islemler(
		
				id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
				uye�d INT,
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

