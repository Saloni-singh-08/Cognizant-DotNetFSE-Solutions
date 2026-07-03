DELIMITER $$
CREATE PROCEDURE sp_GetAllEmployeeNamesByDepartment(IN deptId INT)
    BEGIN
        SELECT CONCAT(FirstName, ' ', LastName) AS EmployeeName FROM Employees WHERE DepartmentID = deptId;
    END$$
DELIMITER ;
    
CALL sp_GetAllEmployeeNamesByDepartment(2);                      