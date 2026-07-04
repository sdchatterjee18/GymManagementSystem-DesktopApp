EXEC spInsertDataIntoGenderTable
@GenderName = 'Male'

EXEC spInsertDataIntoGenderTable
@GenderName = 'Female'

EXEC spInsertDataIntoGenderTable
@GenderName = 'Other'

SELECT *FROM tblGender