using System;

namespace Assignment_4_Employee_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Prem = new Employee("Prem", new DateTime(2004, 6, 17), "Student", 12000);
            Console.WriteLine(Employee.GetNumberOfEmployees());
            Console.WriteLine(Prem.GetMonthlySalary());
            Console.WriteLine(Prem.isBirthday());
            Console.WriteLine(Prem.GetYearsUntilRetirement());
            Console.WriteLine(Prem.GetInformation());
            Employee Prem2 = new Employee("Prem2", new DateTime(2004, 6, 17), "Student", 10000);
            Console.WriteLine(Employee.GetNumberOfEmployees());
        }   

    }
}
