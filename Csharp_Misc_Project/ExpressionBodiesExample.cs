using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Misc_Project
{
    class ExpressionBodiesExample
    {
        class Employee
        {
            private string _fName;
            //private string LName;

            //public Employee(string fName, string lName)
            //{
            //    FName = fName;
            //    LName = LName;
            //}
            public Employee(string fName) => _fName = fName;
            public string Name
            {
                get => _fName;
                set => _fName = value;
            }
            //public string GetFullName() => $"{FName}{LName}!!!";
            //public override string ToString() => $"{FName}{LName}!!!!";

            //public void DisplayDetails() => Console.WriteLine(GetFullName());
            //public void DisplayDetails()
            //{
            //    Console.WriteLine($"{FName}{LName}!!");
                
            //}
        }
        //static void Main(string[] args)
        //{
        //    //Employee emp = new Employee("Madhu", "Saha");
        //    Employee emp = new Employee("Madhu");
        //    Console.WriteLine(emp.Name);
        //    emp.Name = "Saha";
        //    Console.WriteLine(emp.Name);

        //    //Console.WriteLine(emp.GetFullName());
        //    //Console.WriteLine(emp);
        //    //emp.DisplayDetails();
        //    Console.WriteLine();

            
        //}
    }
}
