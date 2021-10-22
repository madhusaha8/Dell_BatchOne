using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Misc_Project
{
    //partial class Emp
    //{
    //    public string FName { get; set; }
    //    public string LName { get; set; }
    //    public double Salary { get; set; }
    //    public string Gender { get; set; }
    //}
    //partial class Emp
    //{
    //    public void GetFullName()
    //    {
    //        Console.WriteLine($"{FName} {LName}");
    //    }
    //    public void DisplayEmployeeDetails()
    //    {
    //        Console.WriteLine($"First Name: {0}", FName);
    //        Console.WriteLine($"Last Name: {0}", LName);
    //        Console.WriteLine($"Salary: {0}", Salary);
    //        Console.WriteLine($"Gender {0}", Gender);
    //    }

    //}
    //class Emp
    //{
    //    public string FName { get; set; }
    //    public string LName { get; set; }
    //    public double Salary { get; set; }
    //    public string Gender { get; set; }

    //    public void DisplayEmployeeDetails()
    //    {
    //        Console.WriteLine($"First Name: {0}", FName);
    //        Console.WriteLine($"Last Name: {0}", LName);
    //        Console.WriteLine($"Salary: {0}", Salary);
    //        Console.WriteLine($"Gender {0}", Gender);
    //    }

    //}

    //class Emp { }
    //class Customer { }
    //class PartialClass: Emp { }
    //class PartialClass: Customer { }

    public interface IEmp
    {
        void empMethod();
    }
    public interface ICust
    {
        void custMethod();
    }
    public partial class PartialClass : IEmp
    {
        partial void PartialMethod();
        public void PublicMethod()
        {
            Console.WriteLine("Public Method Invoked");
            PartialMethod();
        }
        public void empMethod()
        {
            Console.WriteLine("Employee Method Invoked");
        }
    }
    public partial class PartialClass : ICust
    {
        partial void PartialMethod()
        {
            Console.WriteLine("Partial Method Invoked");
        }
        public void custMethod()
        {
            Console.WriteLine("Customer Method Invoked");
        }
    }
    class PartialClassExample
    {            
        //static void Main(string[] args)
        //{
        //    //Emp e = new Emp();
        //    //e.FName = "Madhu";
        //    //e.LName = "Saha";
        //    //e.Gender = "Female";
        //    //e.Salary = 20000;
        //    //e.DisplayEmployeeDetails();
        //    //e.GetFullName();
        //    //Console.WriteLine();

        //    PartialClass PC = new PartialClass();
        //    PC.custMethod();
        //    PC.empMethod();
        //    PC.PublicMethod();
        //    Console.ReadKey();

            
        //}
    }
}
