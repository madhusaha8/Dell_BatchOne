using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Misc_Project
{
    class SplittingTuplesExample
    {
        static (string, string, string, double) GetEmployeeDetails(long Empid)
        {
            string EmpName = "Karthik";
            string Gender = "Male";
            string Department = "Admin";
            double Salary = 12000;
            return (EmpName, Gender, Department, Salary);
        }
        //static void Main(string[] args)
        //{

        //    (string Name, string Gender, string Department, double Salary) = GetEmployeeDetails(1001);
        //    //var Name = empDetails.Item1;
        //    //var Gender = empDetails.Item2;
        //    //var Department = empDetails.Item3;
        //    //var Salary = empDetails.Item4;

        //    Console.WriteLine($"{Name} : {Gender} : {Department} : {Salary}");
        //    Console.ReadKey();
        //}
    }
}
