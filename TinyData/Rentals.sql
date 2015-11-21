CREATE TABLE [dbo].[Rentals]
(
	[TinyHouseId] INT Identity (1,1) NOT NULL, 
    [Cost] DECIMAL NOT NULL, 
    [Location] NVARCHAR(50) NOT NULL, 
    [Capacity] INT NULL, 
    [Nights] INT NULL, 
    [Ratings] INT NULL,
	PRIMARY KEY CLUSTERED ([TinyHouseId]ASC)
)
