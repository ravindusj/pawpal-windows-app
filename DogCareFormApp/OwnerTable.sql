CREATE TABLE DogOwner (
    OwnerID INT PRIMARY KEY IDENTITY,
    OwnerName NVARCHAR(100),
    OwnerContact NVARCHAR(50),
	OwnerAddress NVARCHAR(100),
	OwnerEmail NVARCHAR(100)
);