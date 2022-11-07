
--USE KutuphaneDb

-- SAyfa sayýsý 300 den büyük eþit olan kitaplarý listeleyin
--SELECT * FROM Kitaplar WHERE sayfaSayisi >= 300


-- Stok adedi 90 -113 olanlar listelensin
--SELECT * FROM Kitaplar WHERE stok >= 90 AND stok <=113
--SELECT * FROM Kitaplar WHERE stok BETWEEN 90 AND 113 



--Sayfa sayýsýna göre en çoktan en aza sýralama
--SELECT * FROM Kitaplar ORDER BY sayfaSayisi DESC

--Türe göre küçükten büyüðe sýralama
--SELECT * FROM Kitaplar ORDER BY turId ,sayfaSayisi DESC



-------------------------HESAPLAMA------------------------------------

USE KutuphaneDb
--SELECT* FROM Kitaplar


-- En kucuk sayfa sayýsý
--SELECT MIN(sayfaSayisi) From Kitaplar

-- En buyuk sayfa sayýsý
--SELECT MAX(sayfaSayisi) From Kitaplar

--Tabloda toplam kaç kayýt var ? //5 KAYIT VAR 
--USE HastaneDb
--SELECT COUNT(bolumId) FROM Doktorlar

--USE KutuphaneDb

--ortalama sayfa sayýsý
--SELECT AVG(sayfaSayisi) FROM Kitaplar

--toplam stok miktarý
--SELECT SUM(stok) FROM Kitaplar


--sayfa sayýsýný fiyat olarak düsünelim, toplam fiyat =>
--SELECT SUM(stok * sayfaSayisi) FROM Kitaplar


--sayfa sayýsýný deðiþmek için ;
--UPDATE Kitaplar SET sayfaSayisi = sayfaSayisi*1.2


