/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
MERGE INTO Rentals AS Target 
USING (VALUES 
        (1, 100.00,'Cleveland', 2, 2, 4)       
        
) 
AS Source (TinyHouseId, Cost, Location, Capacity, Nights, Ratings) 
ON Target.TinyHouseId = Source.TinyHouseId 
WHEN NOT MATCHED BY TARGET THEN 
INSERT ( Cost, Location, Capacity, Nights, Ratings) 
VALUES ( Cost, Location, Capacity, Nights, Ratings);