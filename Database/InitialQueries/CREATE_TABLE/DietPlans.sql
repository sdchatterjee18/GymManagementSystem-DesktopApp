
CREATE TABLE tblDietPlans(
       DietPlanId INT PRIMARY KEY  NOT NULL IDENTITY(1,1),
       CaloriesPerDay INT CHECK(CaloriesPerDay > 0) NOT NULL,
       DietPlanDocument VARCHAR(MAX),
       ConditionStatus VARCHAR(MAX) NOT NULL
)
