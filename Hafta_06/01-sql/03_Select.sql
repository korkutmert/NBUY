USE HastaneDb

---------------------------F�LTRELEME--------------------------
--SELECT * FROM Bolumler

--SELECT * FROM Doktorlar

--USE HastaneDb
--SELECT adSoyad AS 'AD SOYAD' ,adres AS 'ADRES' FROM Doktorlar 

--SELECT * FROM Doktorlar WHERE id=5
--SELECT * FROM Doktorlar WHERE adSoyad='Tuna Sefer'
--SELECT * FROM Doktorlar WHERE adSoyad!='Tuna Sefer' -- TUNA SEFER OLMAYANI GET�R
--SELECT * FROM Doktorlar WHERE NOT adSoyad='Tuna Sefer'  -- TUNA SEFER OLMAYANI GET�R
--SELECT * FROM Doktorlar WHERE id=3 OR id=6
--SELECT * FROM Doktorlar WHERE bolumId=5 AND adres='izmir'
--SELECT * FROM Doktorlar WHERE id >= 6


-- �stanbul ve izmir'deki doktorlar�n listelenmesi
--SELECT * FROM Doktorlar WHERE adres IN ('�zmir','�stanbul')

-- Ad�  a harfi ile ba�layan Doktolar
--SELECT * FROM Doktorlar WHERE adSoyad LIKE 'A%'
--SELECT * FROM Doktorlar WHERE adSoyad LIKE 'AL%'

-- AdSoyad� R harfi ile bitenler Doktolar
--SELECT * FROM Doktorlar WHERE adSoyad LIKE '%evgar'



--i�inde herhangi bir harf ge�iyor mu ?
--SELECT * FROM Doktorlar WHERE adSoyad LIKE '%m%'


-- �kinci harfi e olanlar
--SELECT * FROM Doktorlar WHERE adSoyad LIKE '_e%'

--ilkharfi d ikinci harfi ne olursa olsun, 3. harfi m geri kalan ne olursa olsun.
--SELECT * FROM Doktorlar WHERE adSoyad LIKE 'D_m%'


-----------------------------SIRALAMA----------------------------------
-- a'dan z'ye alfabetik s�ralama
--SELECT*FROM Doktorlar ORDER BY adSoyad

-- z'den a'ya alfabetik s�ralama
--SELECT*FROM Doktorlar ORDER BY adSoyad DESC

--Sehir alfabetik s�ralama
--SELECT*FROM Doktorlar ORDER BY adres


-- Sehiri s�ralad�ktan sonra kendi i�inde ad soyada g�re s�rala
--SELECT*FROM Doktorlar ORDER BY adres , adSoyad



-----------------------------STRING--------------------------------------

USE HastaneDb 

--SELECT LEN ('Mert Korkut Muslu')

--SELECT adSoyad , LEN(adSoyad) FROM Doktorlar

--SELECT adSoyad , LEFT(adSoyad,3) as '�lk 3 Karakter', LEN (adSoyad) as 'Uzunluk' 
--FROM Doktorlar

--SELECT adSoyad, 
--UPPER(adSoyad) as 'BUYUK HARF',
--LOWER(adSoyad) as 'kucuk harf'
--FROM Doktorlar


--SELECT 
--REPLACE ('Mert Korkut Muslu','r','y') //r'nin yerine y yazd�.


--SELECT
--REPLACE ('Mert Korkut Muslu',' ','') +  '@benimfirmam.com' // bo�luklar� kadl�rd�k. ve birle�tirme yapt�k


--SELECT 
--	adSoyad,
--	REPLACE (LOWER(adSoyad),' ','') + '@firma.com' as 'Mail Adresi
--	FROM Doktorlar



--Sercan Furkan ad�nda amasya da yasayan b�l�m� 3 olan doktoru kaydedecek sroguyu yaz�n�z.
--USE HastaneDb
--INSERT INTO Doktorlar VALUES
--('Sercan Furkan','Amasya',3)



----------------------G�NCELLEME---------------------------------
--USE HastaneDb
--UPDATE Doktorlar SET adSoyad = 'Sercan Ahmet Furkan'
		--WHERE id=12            /////// WHERE DEMEZSEK �SM� T�M TABLOYA UYGULAR!


----S�LMEEE-----

--DELETE FROM Doktorlar WHERE id=6  //// id'si 6 olan ki�iyi sildik.
--DELETE FROM Doktorlar WHERE bolumId IS NULL  //// bolumId'si null olan� sil.
