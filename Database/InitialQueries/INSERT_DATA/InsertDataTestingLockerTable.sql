EXEC spInsertDataIntoLockerTable
@LockerNo = 'L001',
@LockerStatus = 'Available'

EXEC spInsertDataIntoLockerTable
@LockerNo = 'L002',
@LockerStatus = 'Occupied'

EXEC spInsertDataIntoLockerTable
@LockerNo = 'L003',
@LockerStatus = 'Maintenance'

SELECT *FROM tblLocker