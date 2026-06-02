
CREATE TABLE tblDietPlans(
       DietPlanId INT PRIMARY KEY  NOT NULL IDENTITY(1,1),
       CaloriesPerDay INT CHECK(CaloriesPerDay > 0) NOT NULL,
       DietPlanDocument VARBINARY(MAX)NULL,
       ConditionStatus VARCHAR(MAX) NOT NULL
)