CREATE TABLE CUSTOMER_KVALITETSPROJEKT(
CustomerID				INT					NOT NULL IDENTITY(1,1),
CustomerFirstName		NVARCHAR(50)		NOT NULL,
CustomerLastName		NVARCHAR(50)		NOT NULL,
StreetName				NVARChAR(50)		NULL,
ZipCode					INT					NOT NULL
CONSTRAINT				CustomerID_PK2		PRIMARY KEY(CustomerID),
CONSTRAINT				Customer_Zip_FK2	FOREIGN KEY(ZipCode)
							References ZIPCODE_KVALITETSPROJEKT(ZipCode)
							ON UPDATE NO ACTION
);

CREATE TABLE	ZIPCODE_KVALITETSPROJEKT(
ZipCode			INT				NOT NULL,
City			NVARCHAR(50)	NULL
CONSTRAINT		Zip_PK2			PRIMARY KEY(ZipCode)
);


DROP TABLE KVALITET_CUSTOMER
DROP TABLE KVALITET_ZIPCODE
P