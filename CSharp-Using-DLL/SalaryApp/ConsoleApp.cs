using System;
using SalaryLibrary;
namespace SalaryApp;

public class ConsoleApp
{
    private readonly SalaryCalculator calculator = new SalaryCalculator();
    Employee ? employee;

    double grosssalary;
    double netsalary;
    double tax;
    String salarygrade = "";
    public void choices()
    {
        Boolean isTrue = true;
        while (isTrue)
        {
            Console.WriteLine("\n========================================");
            Console.WriteLine("\nEmployee Salary System");
            Console.WriteLine("\n========================================");

            Console.WriteLine("1. Enter Employee Information");
            Console.WriteLine("2. Display Employee Information");
            Console.WriteLine("3. Calculate Gross Salary");
            Console.WriteLine("4. Calculate Tax");
            Console.WriteLine("5. Calculate Net Salary");
            Console.WriteLine("6. Display Salary Grade");
            Console.WriteLine("7. Exit");
            int choice = int.Parse(Console.ReadLine());
            Boolean isValid = false;
            switch (choice)
            {
                case 1: employee = EnterEmployeeInformation(); 
                        if (employee != null)
                    {
                        grosssalary = calculator.ComputeGrossSalary(employee.BasicSalary, employee.Allowance);
                        tax =  calculator.CalculateTax(grosssalary);
                        netsalary = calculator.ComputeNetSalary(grosssalary, tax, employee.Deduction);
                        salarygrade = calculator.GetSalaryGrade(grosssalary);
                    }  
                        break;
                case 2: if(employee != null) DisplayEmployeeInformation(employee);  break;
                case 3: if(employee != null) Console.WriteLine(grosssalary);  break;
                case 4: if(employee != null) Console.WriteLine(tax);  break;
                case 5: if(employee != null) Console.WriteLine(netsalary);  break;
                case 6: if(employee != null) Console.WriteLine(salarygrade); break;
                case 7: Console.WriteLine("Program Successfully Closed."); isTrue = false; break;
                default: Console.WriteLine("Please Enter A Numerical Input From [1-7]"); break;
            }
            if (employee == null && choice >= 2 && choice <=6) Console.WriteLine("Enter Employee Information First!");
        }


    }
    Employee EnterEmployeeInformation()
    {
        Console.WriteLine("Enter Employee Name: ");
        string name = Console.ReadLine();

        Console.WriteLine("Enter Employee ID: ");
        string id = Console.ReadLine();

        Console.WriteLine("Enter Employee Basic Salary: ");
        double basic = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter Employee allowance: ");
        double allowance = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter Employee deduction: ");
        double deduction = double.Parse(Console.ReadLine());



        return new Employee(name, id, basic, allowance, deduction);
    }

    void DisplayEmployeeInformation(Employee employee)
    {
        Console.WriteLine("Employee Name: " + employee.EmployeeName);
        Console.WriteLine("Employee ID: " + employee.EmployeeID);
        Console.WriteLine("Employee Basic Salary: " + employee.BasicSalary);
        Console.WriteLine("Employee Allowance: " + employee.Allowance);
        Console.WriteLine("Employee Deduction: " + employee.Deduction);

    }

}