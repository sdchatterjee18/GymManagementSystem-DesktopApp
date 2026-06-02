EXEC spInsertDataIntoSalaryPaymentTable
    @SalaryId = 1,
    @PaymentMode = 'Bank Transfer',
    @PaymentMonth = 'January',
    @PaymentYear = 2026,
    @PaymentStatus = 'Paid';

EXEC spInsertDataIntoSalaryPaymentTable
    @SalaryId = 2,
    @PaymentMode = 'UPI',
    @PaymentMonth = 'January',
    @PaymentYear = 2026,
    @PaymentStatus = 'Paid';

EXEC spInsertDataIntoSalaryPaymentTable
    @SalaryId = 3,
    @PaymentMode = 'Cheque',
    @PaymentMonth = 'January',
    @PaymentYear = 2026,
    @PaymentStatus = 'Paid';

EXEC spInsertDataIntoSalaryPaymentTable
    @SalaryId = 4,
    @PaymentMode = 'Cash',
    @PaymentMonth = 'January',
    @PaymentYear = 2026,
    @PaymentStatus = 'Paid';

EXEC spInsertDataIntoSalaryPaymentTable
    @SalaryId = 5,
    @PaymentMode = 'Bank Transfer',
    @PaymentMonth = 'February',
    @PaymentYear = 2026,
    @PaymentStatus = 'Paid';

EXEC spInsertDataIntoSalaryPaymentTable
    @SalaryId = 6,
    @PaymentMode = 'UPI',
    @PaymentMonth = 'February',
    @PaymentYear = 2026,
    @PaymentStatus = 'Pending';

EXEC spInsertDataIntoSalaryPaymentTable
    @SalaryId = 7,
    @PaymentMode = 'Cheque',
    @PaymentMonth = 'February',
    @PaymentYear = 2026,
    @PaymentStatus = 'Paid';

EXEC spInsertDataIntoSalaryPaymentTable
    @SalaryId = 8,
    @PaymentMode = 'Cash',
    @PaymentMonth = 'March',
    @PaymentYear = 2026,
    @PaymentStatus = 'Paid';

EXEC spInsertDataIntoSalaryPaymentTable
    @SalaryId = 9,
    @PaymentMode = 'Bank Transfer',
    @PaymentMonth = 'March',
    @PaymentYear = 2026,
    @PaymentStatus = 'Failed';

EXEC spInsertDataIntoSalaryPaymentTable
    @SalaryId = 10,
    @PaymentMode = 'UPI',
    @PaymentMonth = 'March',
    @PaymentYear = 2026,
    @PaymentStatus = 'Paid';


