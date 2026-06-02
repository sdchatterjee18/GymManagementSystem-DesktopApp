EXEC spInsertDataIntoLockerTable
@LockerNo = 'L001',
@LockerStatus = 'Available'

EXEC spInsertDataIntoLockerTable
@LockerNo = 'L002',
@LockerStatus = 'Occupied'

EXEC spInsertDataIntoLockerTable
@LockerNo = 'L003',
@LockerStatus = 'Maintenance'

EXEC spInsertDataIntoLockerTable
    @LockerNo = 'L004',
    @LockerStatus = 'Available';

EXEC spInsertDataIntoLockerTable
    @LockerNo = 'L005',
    @LockerStatus = 'Occupied';

EXEC spInsertDataIntoLockerTable
    @LockerNo = 'L006',
    @LockerStatus = 'Maintenance';

EXEC spInsertDataIntoLockerTable
    @LockerNo = 'L007',
    @LockerStatus = 'Available';

EXEC spInsertDataIntoLockerTable
    @LockerNo = 'L008',
    @LockerStatus = 'Occupied';

EXEC spInsertDataIntoLockerTable
    @LockerNo = 'L009',
    @LockerStatus = 'Maintenance';

EXEC spInsertDataIntoLockerTable
    @LockerNo = 'L010',
    @LockerStatus = 'Available';

EXEC spInsertDataIntoLockerTable
    @LockerNo = 'L011',
    @LockerStatus = 'Occupied';

EXEC spInsertDataIntoLockerTable
    @LockerNo = 'L012',
    @LockerStatus = 'Maintenance';

EXEC spInsertDataIntoLockerTable
    @LockerNo = 'L013',
    @LockerStatus = 'Available';

SELECT *FROM tblLocker