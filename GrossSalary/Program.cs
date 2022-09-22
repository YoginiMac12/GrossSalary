using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrossSalary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int DA, HRA, Gross_Salary;
            Console.WriteLine("Enter a Basic Salary : ");
            int Basic_Salary = Convert.ToInt32(Console.ReadLine());
          
            if (Basic_Salary <= 10000)
            {
                DA = (Basic_Salary * 80) / 100;
                HRA = (Basic_Salary * 20) / 100;
                Gross_Salary = Basic_Salary + DA + HRA;
                Console.WriteLine($"Gross Salary is {Gross_Salary}");
            }
            else if (Basic_Salary <= 20000)
            {
                DA = (Basic_Salary * 90) / 100;
                HRA = (Basic_Salary * 35) / 100;
                Gross_Salary = Basic_Salary + DA + HRA;
                Console.WriteLine($"Gross Salary is {Gross_Salary}");
            }
            else 
            {
                DA = (Basic_Salary * 95) / 100;
                HRA = (Basic_Salary * 40) / 100;
                Gross_Salary = Basic_Salary + DA + HRA;
                Console.WriteLine($"Gross Salary is {Gross_Salary}");
            }
            Console.ReadLine();
        }
    }
}
    

