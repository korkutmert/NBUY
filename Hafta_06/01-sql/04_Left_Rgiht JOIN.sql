USE Northwind
--SELECT C.CompanyName
--FROM Customers C INNER JOIN Orders O
--ON C.CustomerID=O.CustomerID




--LEFT JO�N : E�LE�MEYE BAKMASIZIN SOLDAK� TABLOYU D�REKT GET�R�R
--SELECT C.CompanyName
--FROM Customers C LEFT JOIN Orders O  
--ON C.CustomerID=O.CustomerID
--WHERE O.OrderID IS NULL
-- SATI� YAPILMAYAN YAN� �D S� NULL OLANLARI GET�RD�K.



--SELECT C.CompanyName
--FROM Orders O  RIGHT JOIN  Customers C   
--ON C.CustomerID=O.CustomerID
--WHERE O.OrderID IS NULL


-- H�� SATILMAMI� �R�NLER

--SELECT P.ProductName 
--FROM Products P LEFT JOIN [Order Details] OD
--ON P.ProductID=OD.ProductID
--WHERE OD.ProductID IS NULL


-- Hen�z sat�� yapamam�� �al��anlar

SELECT E.FirstName+' ' + E.LastName as 'Ad Soyad' 
FROM Employees E LEFT JOIN Orders O
ON E.EmployeeID=O.EmployeeID
WHERE O.EmployeeID IS NULL