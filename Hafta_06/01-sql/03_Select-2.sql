
--USE KutuphaneDb

-- SAyfa say�s� 300 den b�y�k e�it olan kitaplar� listeleyin
--SELECT * FROM Kitaplar WHERE sayfaSayisi >= 300


-- Stok adedi 90 -113 olanlar listelensin
--SELECT * FROM Kitaplar WHERE stok >= 90 AND stok <=113
--SELECT * FROM Kitaplar WHERE stok BETWEEN 90 AND 113 



--Sayfa say�s�na g�re en �oktan en aza s�ralama
--SELECT * FROM Kitaplar ORDER BY sayfaSayisi DESC

--T�re g�re k���kten b�y��e s�ralama
--SELECT * FROM Kitaplar ORDER BY turId ,sayfaSayisi DESC



-------------------------HESAPLAMA------------------------------------

USE KutuphaneDb
--SELECT* FROM Kitaplar


-- En kucuk sayfa say�s�
--SELECT MIN(sayfaSayisi) From Kitaplar

-- En buyuk sayfa say�s�
--SELECT MAX(sayfaSayisi) From Kitaplar

--Tabloda toplam ka� kay�t var ? //5 KAYIT VAR 
--USE HastaneDb
--SELECT COUNT(bolumId) FROM Doktorlar

--USE KutuphaneDb

--ortalama sayfa say�s�
--SELECT AVG(sayfaSayisi) FROM Kitaplar

--toplam stok miktar�
--SELECT SUM(stok) FROM Kitaplar


--sayfa say�s�n� fiyat olarak d�s�nelim, toplam fiyat =>
--SELECT SUM(stok * sayfaSayisi) FROM Kitaplar


--sayfa say�s�n� de�i�mek i�in ;
--UPDATE Kitaplar SET sayfaSayisi = sayfaSayisi*1.2


