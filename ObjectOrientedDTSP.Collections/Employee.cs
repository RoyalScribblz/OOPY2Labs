namespace ObjectOrientedDTSP.Collections;

public class Employee(
    string employeeName,
    string employeeId,
    string employeePost,
    string empDepartment,
    double empSalary)
{
    public string EmployeeName { get; set; } = employeeName;
    public string EmployeeId { get; set; } = employeeId;
    public string EmployeePost { get; set; } = employeePost;
    public string EmpDepartment { get; set; } = empDepartment;
    public double EmpSalary { get; set; } = empSalary;
}