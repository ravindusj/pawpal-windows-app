CREATE TABLE [dbo].[DogOwner] (
    [OwnerID]      INT            IDENTITY (1, 1) NOT NULL,
    [OwnerName]    NVARCHAR (100) NULL,
    [OwnerContact] NVARCHAR (50)  NULL,
    [OwnerAddress] NVARCHAR (100) NULL,
    [OwnerEmail]   NVARCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([OwnerID] ASC)
);

