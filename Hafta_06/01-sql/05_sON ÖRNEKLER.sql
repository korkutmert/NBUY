USE Northwind
--DISTINCT : Tekil hale getitirir.Kaç gez geçerse geçsin bir kez yazar.
-- GROUP BY : DISTINICT ILE AYNIDIR AÖA FARKLI KOMUTLAR DA ALABILIR
-- TOP(2): ÜSTTEN 2 TANE YAZAR.
-- HAVING : Gruplama yapýlmýþsa where yerine having ile filtreleme uygulanr.


--SELECT DISTINCT CategoryId FROM Products

--1)  Bugune kadar hangi ülkelere satýþ yapýldý.?
--->  SELECT DISTINCT ShipCountry FROM Orders

--2)  Hangi ülkeye ne kadar satýþ yapýlmýþ?
--->  SELECT O.ShipCountry, SUM(OD.Quantity *OD.UnitPrice) AS 'TOPLAM TUTAR'
--	  FROM Orders O INNER JOIN [Order Details] OD 
--	  ON O.OrderID=OD.OrderID
--	  GROUP BY O.ShipCountry
--	  ORDER BY 'TOPLAM TUTAR' DESC

--3)  En Çok satýþ yapýlan 3 ülke ? // 
---> SELECT TOP(3) O.ShipCountry, SUM(OD.Quantity *OD.UnitPrice) AS 'TOPLAM TUTAR'
--	 FROM Orders O INNER JOIN [Order Details] OD 
--	 ON O.OrderID=OD.OrderID
--	 GROUP BY O.ShipCountry
--	 ORDER BY 'TOPLAM TUTAR' DESC


--4)  Elimizde en çok stoðu bulunan ilk 3 ürün
--->  SELECT TOP(3) P.ProductName, P.UnitsInStock FROM Products P
--    ORDER BY P.UnitsInStock DESC



--5)  Hangi kategoriden kaç ürün var?
--->	SELECT C.CategoryName, COUNT(*) as Adet
--  	FROM Categories C INNER JOIN Products P
--  	ON C.CategoryID=P.CategoryID
--  	GROUP BY C.CategoryName
--   	HAVING COUNT(*) > 10 
	

--6)	Hangi Üründen Kaç tane satýlmýþtýr ?
		--SELECT P.ProductName, SUM(OD.Quantity)
		--FROM Products P INNER JOIN [Order Details] OD 
		--ON P.ProductID=OD.ProductID INNER JOIN Orders O 
		--ON O.OrderID=OD.OrderID
		--GROUP BY P.ProductName
		--ORDER BY P.ProductName


--7)  En çok kazandýran ilk ürün ?
		
		--SELECT TOP(3)  P.ProductName,SUM(OD.Quantity *OD.UnitPrice) AS 'TOPLAM FÝYAT'
		--FROM Products P INNER JOIN	[Order Details] OD
		--ON P.ProductID =OD.ProductID
		--GROUP BY  P.ProductName
		--ORDER BY 'TOPLAM FÝYAT' DESC


--8)    Hangi Kargo Þirketine Ne Kadar Ödeme Yapýlmýþtýr?
		
		--SELECT O.ShipName,SUM(O.Freight)
		--FROM Products P INNER JOIN [Order Details] OD
		--ON P.ProductID =OD.ProductID INNER JOIN Orders O 
		--ON O.OrderID=OD.OrderID
		--GROUP BY O.ShipName

--9)   En az hangi kargo þirketine ödeme yapýldý
		
		--SELECT TOP(1) O.ShipName,SUM(O.Freight)
		--FROM Products P INNER JOIN [Order Details] OD
		--ON P.ProductID =OD.ProductID INNER JOIN Orders O 
		--ON O.OrderID=OD.OrderID
		--GROUP BY O.ShipName
		--ORDER BY O.ShipName

--10) Hangi Bölgede hangi üründen kaç paralýk satýþ yapýlmýþtýr.
		
		--SELECT R.RegionDescription,P.ProductName, SUM(OD.Quantity * OD.UnitPrice) 
		--FROM Employees E 
		--INNER JOIN EmployeeTerritories ET ON E.EmployeeID=ET.EmployeeID
		--INNER JOIN Territories T ON ET.TerritoryID=T.TerritoryID
		--INNER JOIN Region R ON T.RegionID=R.RegionID
		--INNER JOIN Orders O ON E.EmployeeID=O.EmployeeID
		--INNER JOIN [Order Details] OD ON O.OrderID=OD.OrderID
		--INNER JOIN Products P ON OD.ProductID=P.ProductID
		--GROUP BY R.RegionDescription,P.ProductName
		--ORDER BY R.RegionDescription,P.ProductName
		
	
--10) Hangi Bölgede hangi üründen kaç adet satýþ yapýlmýþtýr	

	SELECT R.RegionDescription, P.ProductName, SUM(Quantity) AS 'KAC ADET'
	FROM Region R 
	INNER JOIN Territories T ON R.RegionID=T.RegionID
	INNER JOIN EmployeeTerritories ET ON ET.TerritoryID=T.TerritoryID
	INNER JOIN Employees E ON E.EmployeeID = ET.EmployeeID
	INNER JOIN Orders O ON O.EmployeeID=E.EmployeeID
	INNER JOIN [Order Details] OD ON O.OrderID=OD.OrderID
	INNER JOIN Products P ON OD.ProductID=P.ProductID
	 
	 GROUP BY R.RegionDescription,P.ProductName
	 ORDER BY R.RegionDescription,P.ProductName




--11) Hangi Müþteriye ne kadar tutarda satýþ yapýlmýþtýr
		
		--SELECT C.CompanyName, SUM(OD.Quantity * OD.UnitPrice) 
		--FROM Customers C 
		--INNER JOIN Orders O	ON C.CustomerID=O.CustomerID 
		--INNER JOIN [Order Details] OD
		--ON O.OrderID=OD.OrderID
		--GROUP BY C.CompanyName

