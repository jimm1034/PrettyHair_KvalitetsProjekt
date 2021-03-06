USE [A_DB09_2018]
GO
/****** Object:  StoredProcedure [dbo].[spRegisterNewCustomer]    Script Date: 28-02-2019 10:54:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spRegisterNewCustomer]
(
@CustomerFirstName		nVarChar(100),
@CustomerLastName		nVarChar(100),
@CustomerStreetName		nVarChar(200),
@CustomerZipCode				  Int
)

AS
BEGIN
INSERT INTO CUSTOMER_KVALITETSPROJEKT(CustomerFirstName, CustomerLastName, StreetName, ZipCode)
VALUES (@CustomerFirstName, @CustomerLastName, @CustomerStreetName, @CustomerZipCode)
END