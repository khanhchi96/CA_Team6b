 

-- -------------------------------------------------- 
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure 
-- -------------------------------------------------- 
-- Date Created: 10/03/2019 14:43:08 
-- Generated from EDMX file: C:\Users\Chi\source\repos\DB_6b\DB_6b\Model1.edmx 
-- -------------------------------------------------- 
  

SET QUOTED_IDENTIFIER OFF; 
GO 
USE [HumbleDB]; 
GO 
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]'); 
GO 


-- -------------------------------------------------- 
-- Dropping existing FOREIGN KEY constraints 
-- -------------------------------------------------- 


-- -------------------------------------------------- 
-- Dropping existing tables 
-- -------------------------------------------------- 


-- -------------------------------------------------- 
-- Creating all tables 
-- -------------------------------------------------- 
  

-- Creating table 'Customers' 

CREATE TABLE [dbo].[Customers] ( 
    [CustomerId] int IDENTITY(1,1) NOT NULL, 
    [FirstName] nvarchar(max)  NOT NULL, 
    [LastName] nvarchar(max)  NOT NULL, 
    [Username] nvarchar(max)  NOT NULL, 
    [Password] nvarchar(max)  NOT NULL, 
    [Email] nvarchar(max)  NOT NULL, 
    [Phone] nvarchar(max)  NOT NULL, 
    [BirthDate] datetime  NOT NULL 
); 
GO 


-- Creating table 'Orders' 

CREATE TABLE [dbo].[Orders] ( 
    [OrderId] int IDENTITY(1,1) NOT NULL, 
    [CustomerId] int  NOT NULL, 
    [OrderDate] datetime  NOT NULL, 
); 
GO 


-- Creating table 'OrderDetails' 

CREATE TABLE [dbo].[OrderDetails] ( 
    [OrderId] int  NOT NULL, 
    [ProductId] int  NOT NULL, 
    [UnitPrice] float  NOT NULL, 
    [Quantity] int  NOT NULL, 
    [Discount] float  NOT NULL, 
); 
GO 

  
-- Creating table 'Products' 

CREATE TABLE [dbo].[Products] ( 
    [ProductId] int IDENTITY(1,1) NOT NULL, 
    [ProductName] nvarchar(max)  NOT NULL, 
    [Description] nvarchar(max)  NOT NULL, 
    [Genre] nvarchar(max)  NOT NULL, 
    [Developer] nvarchar(max)  NOT NULL, 
    [Publisher] nvarchar(max)  NOT NULL, 
    [Platform] nvarchar(max)  NOT NULL, 
    [OperatingSystem] nvarchar(max)  NOT NULL, 
    [ESRB] nvarchar(max)  NOT NULL, 
    [ReleaseDate] datetime  NOT NULL, 
    [Price] float  NOT NULL, 
    [Discount] float  NOT NULL, 
    [DiscountStart] datetime  NOT NULL, 
    [DiscountEnd] datetime  NOT NULL, 
    [NumOfSales] int  NOT NULL 
); 
GO 


-- Creating table 'Images' 

CREATE TABLE [dbo].[Images] ( 
    [ImageId] int IDENTITY(1,1) NOT NULL, 
    [ImageName] nvarchar(max)  NOT NULL, 
    [ImageUrl] nvarchar(max)  NOT NULL, 
    [ImageType] nvarchar(max)  NOT NULL, 
	[ProductId] int NOT NULL
); 
GO 

  
-- Creating table 'ActivationCodes' 

CREATE TABLE [dbo].[ActivationCodes] ( 
    [CodeId] int identity(1,1) NOT NULL, 
    [OrderId] int  NOT NULL, 
    [ProductId] int  NOT NULL, 
    [ActCode] nvarchar(max)  NOT NULL 
); 
GO 

  

-- -------------------------------------------------- 
-- Creating all PRIMARY KEY constraints 
-- -------------------------------------------------- 
  

-- Creating primary key on [CustomerId] in table 'Customers' 

ALTER TABLE [dbo].[Customers] 
ADD CONSTRAINT [PK_Customers] 
    PRIMARY KEY CLUSTERED ([CustomerId] ASC); 
GO 

  
-- Creating primary key on [OrderId] in table 'Orders' 
ALTER TABLE [dbo].[Orders] 
ADD CONSTRAINT [PK_Orders] 
    PRIMARY KEY CLUSTERED ([OrderId] ASC); 
GO 
  

-- Creating primary key on [ProductId], [OrderId] in table 'OrderDetails' 

ALTER TABLE [dbo].[OrderDetails] 
ADD CONSTRAINT [PK_OrderDetails] 
    PRIMARY KEY CLUSTERED ([OrderId], [ProductId] ASC); 
GO 

  
-- Creating primary key on [ProductId] in table 'Products' 
ALTER TABLE [dbo].[Products] 
ADD CONSTRAINT [PK_Products] 
    PRIMARY KEY CLUSTERED ([ProductId] ASC); 
GO 

  
-- Creating primary key on [ImageId] in table 'Images' 

ALTER TABLE [dbo].[Images] 
ADD CONSTRAINT [PK_Images] 
    PRIMARY KEY CLUSTERED ([ImageId] ASC); 
GO 


-- Creating primary key on [CodeId] in table 'ActivationCodes' 

ALTER TABLE [dbo].[ActivationCodes] 
ADD CONSTRAINT [PK_ActivationCodes] 
    PRIMARY KEY CLUSTERED ([CodeId] ASC); 
GO 

  
-- -------------------------------------------------- 
-- Creating all FOREIGN KEY constraints 
-- -------------------------------------------------- 


-- Creating foreign key on [CustomerId] in table 'Orders' 

ALTER TABLE [dbo].[Orders] 
ADD CONSTRAINT [FK_OrderCustomer] 
    FOREIGN KEY ([CustomerId]) 
    REFERENCES [dbo].[Customers] 
        ([CustomerId]) 
    ON DELETE NO ACTION ON UPDATE NO ACTION; 
GO 

  
-- Creating non-clustered index for FOREIGN KEY 'FK_OrderCustomer' 

CREATE INDEX [IX_FK_OrderCustomer] 
ON [dbo].[Orders] 
    ([CustomerId]); 
GO 


-- Creating foreign key on [OrderId] in table 'OrderDetails' 

ALTER TABLE [dbo].[OrderDetails] 
ADD CONSTRAINT [FK_OrderDetailOrder] 
    FOREIGN KEY ([OrderId]) 
    REFERENCES [dbo].[Orders] 
        ([OrderId]) 
    ON DELETE NO ACTION ON UPDATE NO ACTION; 
GO 
 

ALTER TABLE [dbo].[OrderDetails] 
ADD CONSTRAINT [FK_OrderDetailProduct] 
    FOREIGN KEY ([ProductId]) 
    REFERENCES [dbo].[Products] 
        ([ProductId]) 
    ON DELETE NO ACTION ON UPDATE NO ACTION; 
GO 

  
-- Creating non-clustered index for FOREIGN KEY 'FK_OrderOrderDetail' 

CREATE INDEX [IX_FK_OrderDetailOrder] 
ON [dbo].[OrderDetails] 
    ([OrderId]); 
GO 


CREATE INDEX [IX_FK_OrderDetailProduct] 
ON [dbo].[OrderDetails] 
    ([ProductId]); 
GO 

  
-- Creating foreign key on [ProductId] in table 'Images' 

ALTER TABLE [dbo].[Images] 
ADD CONSTRAINT [FK_ImageProduct] 
    FOREIGN KEY ([ProductId]) 
    REFERENCES [dbo].[Products] 
        ([ProductId]) 
    ON DELETE NO ACTION ON UPDATE NO ACTION; 
GO 

  
-- Creating non-clustered index for FOREIGN KEY 'FK_ImageProduct' 

CREATE INDEX [IX_FK_ImageProduct] 
ON [dbo].[Images] 
    ([ProductId]); 
GO 


-- Creating foreign key on [OrderId] and [ProductId] in table 'ActivationCodes' 

ALTER TABLE [dbo].[ActivationCodes] 
ADD CONSTRAINT [FK_CodeOrder] 
    FOREIGN KEY ([OrderId], [ProductId]) 
    REFERENCES [dbo].[OrderDetails] 
        ([OrderId], [ProductId]) 
    ON DELETE NO ACTION ON UPDATE NO ACTION; 
GO 

  
-- Creating non-clustered index for FOREIGN KEY 'FK_CodeOrder' 

CREATE INDEX [IX_FK_ActivationCode] 
ON [dbo].[ActivationCodes] 
    ([OrderId], [ProductId]); 
GO 

  
-- -------------------------------------------------- 
-- Script has ended 
-- -------------------------------------------------- 
