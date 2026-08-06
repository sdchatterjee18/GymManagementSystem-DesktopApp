CREATE PROC spDisplayAllEmployeeDetails
AS
BEGIN

    SELECT
        E.EmployeeId,
        E.FirstName + ' ' +ISNULL(E.MiddleName + ' ', '') +E.LastName AS EmployeeName,
        G.GenderName,
        E.PhoneNo,
        E.EmailId,
        E.JoiningDate,
        E.IsActive,
        R.Role AS RoleName,
        E.BankAccountNo,
        S.Amount AS Salary
    FROM tblEmployee E
    INNER JOIN tblGender G
        ON E.GenderId = G.GenderId
    INNER JOIN tblEmployeeRoleType R
        ON E.RoleId = R.RoleId
    INNER JOIN tblSalary S
        ON E.EmployeeId = S.EmployeeId
    ORDER BY E.EmployeeId;
END
