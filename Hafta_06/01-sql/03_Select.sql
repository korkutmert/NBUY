USE HastaneDb

---------------------------FÝLTRELEME--------------------------
--SELECT * FROM Bolumler

--SELECT * FROM Doktorlar

--USE HastaneDb
--SELECT adSoyad AS 'AD SOYAD' ,adres AS 'ADRES' FROM Doktorlar 

--SELECT * FROM Doktorlar WHERE id=5
--SELECT * FROM Doktorlar WHERE adSoyad='Tuna Sefer'
--SELECT * FROM Doktorlar WHERE adSoyad!='Tuna Sefer' -- TUNA SEFER OLMAYANI GETÝR
--SELECT * FROM Doktorlar WHERE NOT adSoyad='Tuna Sefer'  -- TUNA SEFER OLMAYANI GETÝR
--SELECT * FROM Doktorlar WHERE id=3 OR id=6
--SELECT * FROM Doktorlar WHERE bolumId=5 AND adres='izmir'
--SELECT * FROM Doktorlar WHERE id >= 6


-- Ýstanbul ve izmir'deki doktorlarýn listelenmesi
--SELECT * FROM Doktorlar WHERE adres IN ('Ýzmir','Ýstanbul')

-- Adý  a harfi ile baþlayan Doktolar
--SELECT * FROM Doktorlar WHERE adSoyad LIKE 'A%'
--SELECT * FROM Doktorlar WHERE adSoyad LIKE 'AL%'

-- AdSoyadý R harfi ile bitenler Doktolar
--SELECT * FROM Doktorlar WHERE adSoyad LIKE '%evgar'



--içinde herhangi bir harf geçiyor mu ?
--SELECT * FROM Doktorlar WHERE adSoyad LIKE '%m%'


-- Ýkinci harfi e olanlar
--SELECT * FROM Doktorlar WHERE adSoyad LIKE '_e%'

--ilkharfi d ikinci harfi ne olursa olsun, 3. harfi m geri kalan ne olursa olsun.
--SELECT * FROM Doktorlar WHERE adSoyad LIKE 'D_m%'


-----------------------------SIRALAMA----------------------------------
-- a'dan z'ye alfabetik sýralama
--SELECT*FROM Doktorlar ORDER BY adSoyad

-- z'den a'ya alfabetik sýralama
--SELECT*FROM Doktorlar ORDER BY adSoyad DESC

--Sehir alfabetik sýralama
--SELECT*FROM Doktorlar ORDER BY adres


-- Sehiri sýraladýktan sonra kendi içinde ad soyada göre sýrala
--SELECT*FROM Doktorlar ORDER BY adres , adSoyad



-----------------------------STRING--------------------------------------

USE HastaneDb 

--SELECT LEN ('Mert Korkut Muslu')

--SELECT adSoyad , LEN(adSoyad) FROM Doktorlar

--SELECT adSoyad , LEFT(adSoyad,3) as 'Ýlk 3 Karakter', LEN (adSoyad) as 'Uzunluk' 
--FROM Doktorlar

--SELECT adSoyad, 
--UPPER(adSoyad) as 'BUYUK HARF',
--LOWER(adSoyad) as 'kucuk harf'
--FROM Doktorlar


--SELECT 
--REPLACE ('Mert Korkut Muslu','r','y') //r'nin yerine y yazdý.


--SELECT
--REPLACE ('Mert Korkut Muslu',' ','') +  '@benimfirmam.com' // boþluklarý kadlýrdýk. ve birleþtirme yaptýk


--SELECT 
--	adSoyad,
--	REPLACE (LOWER(adSoyad),' ','') + '@firma.com' as 'Mail Adresi
--	FROM Doktorlar



--Sercan Furkan adýnda amasya da yasayan bölümü 3 olan doktoru kaydedecek sroguyu yazýnýz.
--USE HastaneDb
--INSERT INTO Doktorlar VALUES
--('Sercan Furkan','Amasya',3)



----------------------GÜNCELLEME---------------------------------
--USE HastaneDb
--UPDATE Doktorlar SET adSoyad = 'Sercan Ahmet Furkan'
		--WHERE id=12            /////// WHERE DEMEZSEK ÝSMÝ TÜM TABLOYA UYGULAR!


----SÝLMEEE-----

--DELETE FROM Doktorlar WHERE id=6  //// id'si 6 olan kiþiyi sildik.
--DELETE FROM Doktorlar WHERE bolumId IS NULL  //// bolumId'si null olaný sil.
