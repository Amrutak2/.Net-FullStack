using System;

namespace OOP_Assignment_3
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Manager emp = new Manager();
            MarketingExecutive M = new MarketingExecutive();
            Console.WriteLine("Enter Employee Number: ");
            emp.EMPNO = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee name: ");
            emp.EMPNAME = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Employee Salary: ");
            emp.SALARY = Convert.ToDouble(Console.ReadLine());
            //emp.CalculateDetails();
            //emp.DisplayEmpDetails();

            emp.CalculateSalary();
            emp.CalculateDetails();
            emp.DisplayManDetails();
            M.CalculteMarketing();
            M.CalculateDetails();
            M.DisplayMarketing();
            Console.ReadKey();
        }
    }
}

