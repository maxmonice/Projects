namespace SalaryApp;

public class Employee
{
    public string EmployeeName {get; set;} = "";
    public string EmployeeID {get; set;} = "";
    public double BasicSalary {get; set;}
    public double Allowance {get; set;}
    public double Deduction {get; set;}


    public Employee(string name, string id, double basic, double allowance, double deduction) {
        EmployeeName = name;
        EmployeeID = id;
        BasicSalary = basic;
        Allowance = allowance;
        Deduction = deduction;
    }
}