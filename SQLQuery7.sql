Select * 
From UserModel

Select *
From dbo.FoodEntryModel

Select * 
From dbo.CalorieCalculatorModel

Select * 
From dbo.RecipesModel

ALTER TABLE dbo.FoodEntryModel DROP CONSTRAINT  PK_FoodEntryModel
GO
ALTER TABLE dbo.FoodEntryModel DROP COLUMN UserId;
GO

SET IDENTITY_INSERT dbo.FoodEntryModel ON
GO
INSERT dbo.FoodEntryModel (Id, FoodName, Description, Calories, Servings, TotalCalories, TotalDayCalories, UserId) 
VALUES (18, 'Chocolate', 'Chocolate Bar', 100, 1, 100, 100, '3')
SET IDENTITY_INSERT dbo.FoodEntryModel OFF
GO

SET IDENTITY_INSERT dbo.CalorieCalculatorModel ON
GO
INSERT dbo.CalorieCalculatorModel(Id, Height, Age, ActualWeight, CalorieIntake, UserId) 
VALUES (1, '160', '22', '200', '1800','3')
SET IDENTITY_INSERT dbo.CalorieCalculatorModel OFF
GO

SELECT pd.FoodName, pd.Description, p.LastName
FROM dbo.UserModel p
LEFT JOIN dbo.FoodEntryModel pd ON p.UserId  = pd.Id
WHERE p.UserId = 1 

SELECT E.FirstName ,D.FoodName, D.Description, E.UserId
FROM UserModel E JOIN FoodEntryModel D
ON (E.UserId = D.UserId)
Where d.UserId =1