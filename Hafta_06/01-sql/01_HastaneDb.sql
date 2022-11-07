USE MASTER
GO

DROP DATABASE IF EXISTS HastaneDb
GO

CREATE DATABASE HastaneDb
GO	

--üst taraf varsa hastanedb'yi silip yeniden oluþturur.
-- yoksa zaten oluþturur.

USE HastaneDb
GO

--HASTALAR TABLOSU

CREATE TABLE Hastalar(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	adSoyad NVARCHAR(50) NOT NULL,
	cinisyet CHAR(1) NOT NULL,
	adres NVARCHAR(50), 
	telefon char(11)
)
GO
INSERT INTO Hastalar(adSoyad,cinisyet,adres) VALUES
	('Erencan Germirli','E','Ýstanbul'),
	('Ahmet Yýlmaz','E','Yalova'),
	('Selin Genç','K','Ankara'),
	('Sadi Kuloðlu','E','Bursa'),
	('Neþe Kalabalýk','K','Ýstanbul'),
	('Sevda Aðalar','K','Ýzmir'),
	('Burak Yýlmaz','E','Ýstanbul'),
	('Emma Çetin','K','Ýzmit'),
	('Suat Çoban','K','Ýstanbul')
	GO
--BOLÜMLER TABLOSU
CREATE TABLE Bolumler(
		id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
		ad NVARCHAR(30) NOT NULL
)
INSERT INTO Bolumler VALUES
	('Dahiliye'),('Cildiye'),('Onkoloji'),('Nöroloji'),('Diþ'),('Ortopedi')

	GO
CREATE TABLE Doktorlar(
		id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
		adSoyad NVARCHAR(50) NOT NULL,
		adres NVARCHAR(50),
		bolumId INT,
		FOREIGN KEY (bolumId) REFERENCES Bolumler(id)
)
GO

INSERT INTO Doktorlar VALUES
('Ali Can','Ýstanbul',1),
('Yeþim Beyaz','Bursa',2),
('Kamil Varlýk','Ýstanbul',3),
('Burak Yýlmaz','Ýzmir',1),
('Zafer Kimki','Ankara',2),
('Hale Elveren','Ýstanbul',3),
('Tuna Sefer','Ýstanbul',4),
('Kevser Tutku','Ýstanbul',5),
('Sebahat Bulan','Rize',5),
('Mert Muslu','Yalova',5),
('Tuðçe Bölümsüz','Ýstanbul',null)