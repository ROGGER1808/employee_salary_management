namespace employeeSalaryManagement.Models;

public class Department
{
    public String Name { get; set; }
    public String Description { get; set; }

    public ICollection<Employee> Employees;
}