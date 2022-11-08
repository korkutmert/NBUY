USE Northwind
--SELECT C.CompanyName
--FROM Customers C INNER JOIN Orders O
--ON C.CustomerID=O.CustomerID




--LEFT JOÝN : EÞLEÞMEYE BAKMASIZIN SOLDAKÝ TABLOYU DÝREKT GETÝRÝR
--SELECT C.CompanyName
--FROM Customers C LEFT JOIN Orders O  
--ON C.CustomerID=O.CustomerID
--WHERE O.OrderID IS NULL
-- SATIÞ YAPILMAYAN YANÝ ÝD SÝ NULL OLANLARI GETÝRDÝK.



--SELECT C.CompanyName
--FROM Orders O  RIGHT JOIN  Customers C   
--ON C.CustomerID=O.CustomerID
--WHERE O.OrderID IS NULL


-- HÝÇ SATILMAMIÞ ÜRÜNLER

--SELECT P.ProductName 
--FROM Products P LEFT JOIN [Order Details] OD
--ON P.ProductID=OD.ProductID
--WHERE OD.ProductID IS NULL


-- Henüz satýþ yapamamýþ çalýþanlar

SELECT E.FirstName+' ' + E.LastName as 'Ad Soyad' 
FROM Employees E LEFT JOIN Orders O
ON E.EmployeeID=O.EmployeeID
WHERE O.EmployeeID IS NULL