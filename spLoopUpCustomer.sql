USE [A_DB09_2018]
GO
/****** Object:  StoredProcedure [dbo].[spLookUpCustomer]    Script Date: 28-02-2019 10:54:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spLookUpCustomer]
(
@CustomerID int
)
AS
BEGIN
SELECT CustomerID, CustomerFirstName, CustomerLastName, ZipCode, StreetName
FROM CUSTOMER_KVALITETSPROJEKT
WHERE CustomerID = @CustomerID
END