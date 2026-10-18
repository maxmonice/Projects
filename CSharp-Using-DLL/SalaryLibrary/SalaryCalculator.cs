namespace SalaryLibrary;

public class SalaryCalculator
{
    public double ComputeGrossSalary(double basicSalary, double allowance)
    {
        return basicSalary + allowance;
    }

    public double ComputeNetSalary(double grossSalary, double tax, double deduction)
    {
        return grossSalary - tax - deduction;
        
    }

    public double CalculateTax(double grossSalary)
    {
        double tax = 0;
        if (grossSalary <= 20000)
        {
            tax  = 0.05 * grossSalary;
        }
        else if (grossSalary >= 20001 && grossSalary <= 40000)
        {
            tax = 0.10 * grossSalary;
        }
        else if (grossSalary >= 40001 && grossSalary <= 60000)
        {      tax = 0.15 * grossSalary;
      
        }
        else if (grossSalary > 60000)
        {
            tax = 0.20 * grossSalary;
        }

        return tax;
    }

    public String GetSalaryGrade(double grossSalary)
    {
        String salaryGrade = "";
        if (grossSalary <= 15000)
        {
            salaryGrade  = "Grade 1";
        }
        else if (grossSalary >= 15001 && grossSalary <= 25000)
        {
            salaryGrade = "Grade 2";
        }
        else if (grossSalary >= 25001 && grossSalary <= 40000)
        {
            salaryGrade = "Grade 3";
        }
        else if (grossSalary > 40000)
        {
            salaryGrade = "Grade 4";
        }

        return salaryGrade;
    }
}
