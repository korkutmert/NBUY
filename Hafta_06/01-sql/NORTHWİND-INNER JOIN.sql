--products tablosunun unitPrice' a göre kucukten buyuge sýralanmasý

USE Northwind

--SELECT * FROM Products ORDER BY UnitPrice 


--Fiyatý 100 üstünde olanlar
--SELECT * FROM Products WHERE UnitPrice >100


--7 ve 8 katogerisindeki ürünler
--SELECT * FROM Products WHERE CategoryID BETWEEN 7 AND 8


-- (unitinStocks) göster
--SELECT * FROM Products WHERE CategoryID=0

--KAtegorisi 7 ve 8 olanlarýn stok miktarý <=10 olan ürünlerin sayýsý
--SELECT COUNT (*) FROM Products WHERE (CategoryID=7 OR CategoryID=8) AND UnitsInStock<=10


---------------------------------------------------INER JOIN-----------------------------------------------------------------------

--SELECT Products.ProductName,Categories.CategoryName FROM Products INNER JOIN Categories
--	ON Products.CategoryID=Categories.CategoryID


-- form kýsmýnda tek harfle kýsaltma vererek her yerde ayný harf kullanlabilir. Products'a P , Categories 'e C dedik.
--SELECT P.ProductName,C.CategoryName
--FROM Products P INNER JOIN Categories C
--ON P.CategoryID=C.CategoryID
--WHERE CategoryName='Beverages' AND P.UnitPrice <= 40
--ORDER BY P.UnitPrice DESC

--PRODUCT NAME VE SUPPLÝER COMPANY NAME'Ý GÖSTEREN SORGU

--SELECT  P.ProductName, S.CompanyName
--FROM Products P INNER JOIN Suppliers S
--ON  P.SupplierID=S.SupplierID

--Germany'den tedarik edilen ürünler.
--SELECT  P.ProductName, S.CompanyName,Country
--FROM Products P INNER JOIN Suppliers S
--ON  P.SupplierID=S.SupplierID
--WHERE S.Country='Germany'

--Germany'den tedarik edilen ürünlerin toplam fiyatý.
--SELECT  SUM(P.UnitPrice * P.UnitsInStock) as 'Toplam Tutar'
--FROM Products P INNER JOIN Suppliers S
--ON  P.SupplierID=S.SupplierID
--WHERE S.Country='Sweden'




--Chai satýþlarýnýn toplam tutarý.
--SELECT SUM(OD.UnitPrice * Quantity)
--FROM Products P INNER JOIN [Order Details] OD
--ON p.ProductID=OD.ProductID
--WHERE P.ProductName='Chai'


--Germany'e yapýlmýþ olan, Chai satýþlarýnýn toplam tutarý.

--SELECT SUM(OD.UnitPrice * OD.Quantity)
--FROM Orders O INNER JOIN [Order Details]OD
--ON O.OrderID=OD.OrderID INNER JOIN Products P
--ON OD.ProductID=P.ProductID
--WHERE O.ShipCountry='Germany' AND P.ProductName='Chai'


-- Ernst Handel müþteriisne yapýlan satýþ tutarý.

--SELECT SUM(OD.UnitPrice * Quantity)
--FROM [Order Details] OD INNER JOIN Orders O 
--ON OD.OrderID=O.OrderID INNER JOIN Customers C
--ON O.CustomerID=C.CustomerID

--WHERE C.CustomerID='ERNSH'
--WHERE C.CompanyName='Ernst Handel'--- bir üsttekiyle ayný iþleve yarýyor.
