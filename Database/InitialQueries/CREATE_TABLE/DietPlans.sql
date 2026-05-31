
CREATE TABLE tblDietPlans(
       DietPlanId INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
       CaloriesPerDay INT CHECK(CaloriesPerDay > 0) NOT NULL,
       DietPlanDocument VARCHAR(MAX),
       ConditionStatus VARCHAR(MAX) NOT NULL
)
