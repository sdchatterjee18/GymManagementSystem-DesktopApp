EXEC spInsertDataIntoDietPlanTable
     @CaloriesPerDay = 1800,
     @DietPlanDocument = '
Breakfast:
- 2 Boiled Eggs
- Oatmeal
- Green Tea

Snack:
- Apple

Lunch:
- Grilled Chicken Breast
- Brown Rice
- Salad

Snack:
- Almonds

Dinner:
- Grilled Fish
- Steamed Vegetables
',
     @ConditionStatus = 'Weight Loss';
GO

EXEC spInsertDataIntoDietPlanTable
     @CaloriesPerDay = 2500,
     @DietPlanDocument = '
Breakfast:
- 4 Whole Eggs
- Whole Wheat Bread
- Banana
- Milk

Snack:
- Peanut Butter Sandwich

Lunch:
- Chicken Breast
- Rice
- Salad

Snack:
- Protein Shake

Dinner:
- Fish Curry
- Chapati
',
     @ConditionStatus = 'Weight Gain';
GO

EXEC spInsertDataIntoDietPlanTable
     @CaloriesPerDay = 2200,
     @DietPlanDocument = '
Breakfast:
- Egg Whites
- Oats
- Banana

Post Workout:
- Whey Protein

Lunch:
- Chicken Breast
- Brown Rice
- Broccoli

Snack:
- Greek Yogurt

Dinner:
- Salmon
- Sweet Potato
',
     @ConditionStatus = 'Muscle Building';
GO

EXEC spInsertDataIntoDietPlanTable
     @CaloriesPerDay = 2000,
     @DietPlanDocument = '
Breakfast:
- Vegetable Omelette
- Toast

Snack:
- Orange

Lunch:
- Grilled Chicken
- Rice
- Salad

Snack:
- Mixed Nuts

Dinner:
- Fish
- Vegetables
',
     @ConditionStatus = 'Maintenance';
GO

EXEC spInsertDataIntoDietPlanTable
     @CaloriesPerDay = 1700,
     @DietPlanDocument = '
Breakfast:
- Oats
- Green Tea

Snack:
- Apple

Lunch:
- Grilled Fish
- Salad

Snack:
- Cucumber Slices

Dinner:
- Vegetable Soup
- Boiled Chicken
',
     @ConditionStatus = 'Fat Loss';
GO

EXEC spInsertDataIntoDietPlanTable
     @CaloriesPerDay = 2300,
     @DietPlanDocument = '
Breakfast:
- Egg Whites
- Protein Shake

Snack:
- Almonds

Lunch:
- Chicken Breast
- Quinoa

Snack:
- Greek Yogurt

Dinner:
- Tuna Fish
- Vegetables
',
     @ConditionStatus = 'High Protein';
GO

EXEC spInsertDataIntoDietPlanTable
     @CaloriesPerDay = 1900,
     @DietPlanDocument = '
Breakfast:
- Eggs
- Avocado

Snack:
- Nuts

Lunch:
- Grilled Chicken
- Green Vegetables

Snack:
- Cheese Cubes

Dinner:
- Fish
- Salad
',
     @ConditionStatus = 'Low Carb';
GO

EXEC spInsertDataIntoDietPlanTable
     @CaloriesPerDay = 2100,
     @DietPlanDocument = '
Breakfast:
- Oats
- Skim Milk

Snack:
- Guava

Lunch:
- Brown Rice
- Lentils
- Salad

Snack:
- Roasted Chickpeas

Dinner:
- Grilled Fish
- Vegetables
',
     @ConditionStatus = 'Diabetic';
GO

EXEC spInsertDataIntoDietPlanTable
     @CaloriesPerDay = 2400,
     @DietPlanDocument = '
Breakfast:
- Oats
- Banana
- Milk

Pre Workout:
- Peanut Butter Sandwich

Post Workout:
- Whey Protein

Lunch:
- Chicken Breast
- Rice

Dinner:
- Fish
- Sweet Potato
',
     @ConditionStatus = 'Athlete Performance';
GO

EXEC spInsertDataIntoDietPlanTable
     @CaloriesPerDay = 1600,
     @DietPlanDocument = '
Breakfast:
- Oatmeal
- Green Tea

Snack:
- Apple

Lunch:
- Grilled Fish
- Brown Rice

Snack:
- Walnuts

Dinner:
- Vegetable Soup
- Steamed Vegetables
',
     @ConditionStatus = 'Heart Healthy';
GO