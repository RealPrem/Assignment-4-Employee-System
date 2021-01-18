using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_4_Employee_System
{
    class Employee
    {
        private string Name;
        private int Age;
        private DateTime DOB;
        private string Job;
        private double Salary;

        public static int EmployeeCount;
        private static int RetirementAge;
        public Employee(string Name, DateTime DOB, string Job, double Salary)
        {
            this.Name = Name;
            this.DOB = DOB;
            this.Job = Job;
            this.Salary = Salary;
            RetirementAge = 65;
            EmployeeCount = EmployeeCount + 1;
        }
        public double GetMonthlySalary()
        {
            double MonthlySalary = Salary / 12;
            return MonthlySalary;
        }
        public bool isBirthday()
        {
            int Month = DOB.Month;
            int Day = DOB.Day;
            if(Month == DateTime.Now.Month && Day == DateTime.Now.Day)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void SetAge()
        {
            Age = DateTime.Now.Year - DOB.Year;
        }
        public int GetYearsUntilRetirement()
        {
            SetAge();
            int YearsUntilRetirement = RetirementAge - Age;
            return YearsUntilRetirement;
        }
        public string GetInformation()
        {
            string information = Name + " " +  Age + " "  + Job + " " + Salary;
            return information;
        }
        public void SetJob(string NewJob)
        {
            Job = NewJob;
        }
        public void SetSalary(double NewSalary)
        {
            Salary = NewSalary;
        }
        public void SetName(string NewName)
        {
            Name = NewName;
        }
        public static int GetNumberOfEmployees()
        {
            return EmployeeCount;
        }


    }
    

}
