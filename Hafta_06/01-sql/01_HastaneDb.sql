USE MASTER
GO

DROP DATABASE IF EXISTS HastaneDb
GO

CREATE DATABASE HastaneDb
GO	

--�st taraf varsa hastanedb'yi silip yeniden olu�turur.
-- yoksa zaten olu�turur.

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
	('Erencan Germirli','E','�stanbul'),
	('Ahmet Y�lmaz','E','Yalova'),
	('Selin Gen�','K','Ankara'),
	('Sadi Kulo�lu','E','Bursa'),
	('Ne�e Kalabal�k','K','�stanbul'),
	('Sevda A�alar','K','�zmir'),
	('Burak Y�lmaz','E','�stanbul'),
	('Emma �etin','K','�zmit'),
	('Suat �oban','K','�stanbul')
	GO
--BOL�MLER TABLOSU
CREATE TABLE Bolumler(
		id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
		ad NVARCHAR(30) NOT NULL
)
INSERT INTO Bolumler VALUES
	('Dahiliye'),('Cildiye'),('Onkoloji'),('N�roloji'),('Di�'),('Ortopedi')

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
('Ali Can','�stanbul',1),
('Ye�im Beyaz','Bursa',2),
('Kamil Varl�k','�stanbul',3),
('Burak Y�lmaz','�zmir',1),
('Zafer Kimki','Ankara',2),
('Hale Elveren','�stanbul',3),
('Tuna Sefer','�stanbul',4),
('Kevser Tutku','�stanbul',5),
('Sebahat Bulan','Rize',5),
('Mert Muslu','Yalova',5),
('Tu��e B�l�ms�z','�stanbul',null)