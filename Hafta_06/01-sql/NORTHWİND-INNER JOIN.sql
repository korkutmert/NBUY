--products tablosunun unitPrice' a g�re kucukten buyuge s�ralanmas�

USE Northwind

--SELECT * FROM Products ORDER BY UnitPrice 


--Fiyat� 100 �st�nde olanlar
--SELECT * FROM Products WHERE UnitPrice >100


--7 ve 8 katogerisindeki �r�nler
--SELECT * FROM Products WHERE CategoryID BETWEEN 7 AND 8


-- (unitinStocks) g�ster
--SELECT * FROM Products WHERE CategoryID=0

--KAtegorisi 7 ve 8 olanlar�n stok miktar� <=10 olan �r�nlerin say�s�
--SELECT COUNT (*) FROM Products WHERE (CategoryID=7 OR CategoryID=8) AND UnitsInStock<=10


---------------------------------------------------INER JOIN-----------------------------------------------------------------------

--SELECT Products.ProductName,Categories.CategoryName FROM Products INNER JOIN Categories
--	ON Products.CategoryID=Categories.CategoryID


-- form k�sm�nda tek harfle k�saltma vererek her yerde ayn� harf kullanlabilir. Products'a P , Categories 'e C dedik.
--SELECT P.ProductName,C.CategoryName
--FROM Products P INNER JOIN Categories C
--ON P.CategoryID=C.CategoryID
--WHERE CategoryName='Beverages' AND P.UnitPrice <= 40
--ORDER BY P.UnitPrice DESC

--PRODUCT NAME VE SUPPL�ER COMPANY NAME'� G�STEREN SORGU

--SELECT  P.ProductName, S.CompanyName
--FROM Products P INNER JOIN Suppliers S
--ON  P.SupplierID=S.SupplierID

--Germany'den tedarik edilen �r�nler.
--SELECT  P.ProductName, S.CompanyName,Country
--FROM Products P INNER JOIN Suppliers S
--ON  P.SupplierID=S.SupplierID
--WHERE S.Country='Germany'

--Germany'den tedarik edilen �r�nlerin toplam fiyat�.
--SELECT  SUM(P.UnitPrice * P.UnitsInStock) as 'Toplam Tutar'
--FROM Products P INNER JOIN Suppliers S
--ON  P.SupplierID=S.SupplierID
--WHERE S.Country='Sweden'




--Chai sat��lar�n�n toplam tutar�.
--SELECT SUM(OD.UnitPrice * Quantity)
--FROM Products P INNER JOIN [Order Details] OD
--ON p.ProductID=OD.ProductID
--WHERE P.ProductName='Chai'


--Germany'e yap�lm�� olan, Chai sat��lar�n�n toplam tutar�.

--SELECT SUM(OD.UnitPrice * OD.Quantity)
--FROM Orders O INNER JOIN [Order Details]OD
--ON O.OrderID=OD.OrderID INNER JOIN Products P
--ON OD.ProductID=P.ProductID
--WHERE O.ShipCountry='Germany' AND P.ProductName='Chai'


-- Ernst Handel m��teriisne yap�lan sat�� tutar�.

--SELECT SUM(OD.UnitPrice * Quantity)
--FROM [Order Details] OD INNER JOIN Orders O 
--ON OD.OrderID=O.OrderID INNER JOIN Customers C
--ON O.CustomerID=C.CustomerID

--WHERE C.CustomerID='ERNSH'
--WHERE C.CompanyName='Ernst Handel'--- bir �sttekiyle ayn� i�leve yar�yor.
