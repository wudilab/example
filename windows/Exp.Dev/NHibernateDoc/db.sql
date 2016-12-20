IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.Cat') AND type in (N'U'))
    DROP TABLE dbo.Cat
GO
CREATE TABLE dbo.Cat(
   CatId char(32) PRIMARY KEY,
   Name nvarchar(16) not null,
   Sex nchar(1),
   Weight real
)
GO


IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.Products') AND type in (N'U'))
    DROP TABLE dbo.Products
GO
CREATE TABLE dbo.Products(
   StoreID int,
   ProductID int,
   ProductName nvarchar(128),
   PRIMARY KEY (StoreID, ProductID)
)
GO

insert into Products(StoreID, ProductID, ProductName) values(1,1,'fish');
insert into Products(StoreID, ProductID, ProductName) values(1,2,'cake');
insert into Products(StoreID, ProductID, ProductName) values(2,1,'bread');
insert into Products(StoreID, ProductID, ProductName) values(2,2,'apple');



