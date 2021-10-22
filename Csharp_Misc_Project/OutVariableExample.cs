using System;

namespace Csharp_Misc_Project
{
    class OutVariableExample
    {
        static void GetEmployeeDetails(out string EmpName,out string Gender, out string Department, out long EmpSalary)
        {
            EmpName = "Karthik";
            Gender = "Male";
            Department = "Admin";
            EmpSalary = 20000;
        }
        //static void Main(string[] args)
        //{
            
        //    GetEmployeeDetails(out var EmpName, out var Gender, out var Department, out var EmpSalary);
        //    Console.WriteLine("Employee Details : ");
        //    Console.WriteLine("{0} : {1} : {2} : {3}", EmpName, Gender, Department, EmpSalary);
        //    Console.ReadKey();
        //}
    }
}
