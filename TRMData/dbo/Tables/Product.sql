﻿CREATE TABLE [dbo].[Product]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[ProductName] NVARCHAR(100) NOT NULL,
	[Description] NVARCHAR(MAX) NOT NULL,
	[RetailPrice] MONEY NOT NULL,
	[CreateDate] DATETIME2 NOT NULL DEFAULT(GETUTCDATE()),
	[LastModified] DATETIME2 NOT NULL DEFAULT(GETUTCDATE())
)
