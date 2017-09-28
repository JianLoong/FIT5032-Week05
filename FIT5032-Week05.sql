CREATE TABLE [dbo].[Customer] (
    [CustomerId]        INT            IDENTITY (1, 1) NOT NULL,
    [CustomerFirstName] NVARCHAR (50)  NOT NULL,
    [CustomerLastName]  NVARCHAR (50)  NULL,
    [CustomerEmail]     NVARCHAR (50)  NOT NULL,
    [CustomerAddress]   NVARCHAR (MAX) NOT NULL,
    PRIMARY KEY CLUSTERED ([CustomerId] ASC)
);


CREATE TABLE [dbo].[Order] (
    [OrderId]    INT      IDENTITY (1, 1) NOT NULL,
    [CustomerId] INT      NOT NULL,
    [OrderDate]  DATETIME NOT NULL,
    [OrderSum]   MONEY    NOT NULL,
    PRIMARY KEY CLUSTERED ([OrderId] ASC),
    CONSTRAINT [FK_Order_ToTable] FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[Customer] ([CustomerId]) ON DELETE CASCADE
);


