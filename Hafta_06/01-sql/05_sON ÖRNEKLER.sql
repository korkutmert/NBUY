USE Northwind
--DISTINCT : Tekil hale getitirir.Ka� gez ge�erse ge�sin bir kez yazar.
-- GROUP BY : DISTINICT ILE AYNIDIR A�A FARKLI KOMUTLAR DA ALABILIR
-- TOP(2): �STTEN 2 TANE YAZAR.
-- HAVING : Gruplama yap�lm��sa where yerine having ile filtreleme uygulanr.


--SELECT DISTINCT CategoryId FROM Products

--1)  Bugune kadar hangi �lkelere sat�� yap�ld�.?
--->  SELECT DISTINCT ShipCountry FROM Orders

--2)  Hangi �lkeye ne kadar sat�� yap�lm��?
--->  SELECT O.ShipCountry, SUM(OD.Quantity *OD.UnitPrice) AS 'TOPLAM TUTAR'
--	  FROM Orders O INNER JOIN [Order Details] OD 
--	  ON O.OrderID=OD.OrderID
--	  GROUP BY O.ShipCountry
--	  ORDER BY 'TOPLAM TUTAR' DESC

--3)  En �ok sat�� yap�lan 3 �lke ? // 
---> SELECT TOP(3) O.ShipCountry, SUM(OD.Quantity *OD.UnitPrice) AS 'TOPLAM TUTAR'
--	 FROM Orders O INNER JOIN [Order Details] OD 
--	 ON O.OrderID=OD.OrderID
--	 GROUP BY O.ShipCountry
--	 ORDER BY 'TOPLAM TUTAR' DESC


--4)  Elimizde en �ok sto�u bulunan ilk 3 �r�n
--->  SELECT TOP(3) P.ProductName, P.UnitsInStock FROM Products P
--    ORDER BY P.UnitsInStock DESC



--5)  Hangi kategoriden ka� �r�n var?
--->	SELECT C.CategoryName, COUNT(*) as Adet
--  	FROM Categories C INNER JOIN Products P
--  	ON C.CategoryID=P.CategoryID
--  	GROUP BY C.CategoryName
--   	HAVING COUNT(*) > 10 
	

--6)	Hangi �r�nden Ka� tane sat�lm��t�r ?
		--SELECT P.ProductName, SUM(OD.Quantity)
		--FROM Products P INNER JOIN [Order Details] OD 
		--ON P.ProductID=OD.ProductID INNER JOIN Orders O 
		--ON O.OrderID=OD.OrderID
		--GROUP BY P.ProductName
		--ORDER BY P.ProductName


--7)  En �ok kazand�ran ilk �r�n ?
		
		--SELECT TOP(3)  P.ProductName,SUM(OD.Quantity *OD.UnitPrice) AS 'TOPLAM F�YAT'
		--FROM Products P INNER JOIN	[Order Details] OD
		--ON P.ProductID =OD.ProductID
		--GROUP BY  P.ProductName
		--ORDER BY 'TOPLAM F�YAT' DESC


--8)    Hangi Kargo �irketine Ne Kadar �deme Yap�lm��t�r?
		
		--SELECT O.ShipName,SUM(O.Freight)
		--FROM Products P INNER JOIN [Order Details] OD
		--ON P.ProductID =OD.ProductID INNER JOIN Orders O 
		--ON O.OrderID=OD.OrderID
		--GROUP BY O.ShipName

--9)   En az hangi kargo �irketine �deme yap�ld�
		
		--SELECT TOP(1) O.ShipName,SUM(O.Freight)
		--FROM Products P INNER JOIN [Order Details] OD
		--ON P.ProductID =OD.ProductID INNER JOIN Orders O 
		--ON O.OrderID=OD.OrderID
		--GROUP BY O.ShipName
		--ORDER BY O.ShipName

--10) Hangi B�lgede hangi �r�nden ka� paral�k sat�� yap�lm��t�r.
		
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
		
	
--10) Hangi B�lgede hangi �r�nden ka� adet sat�� yap�lm��t�r	

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




--11) Hangi M��teriye ne kadar tutarda sat�� yap�lm��t�r
		
		--SELECT C.CompanyName, SUM(OD.Quantity * OD.UnitPrice) 
		--FROM Customers C 
		--INNER JOIN Orders O	ON C.CustomerID=O.CustomerID 
		--INNER JOIN [Order Details] OD
		--ON O.OrderID=OD.OrderID
		--GROUP BY C.CompanyName

