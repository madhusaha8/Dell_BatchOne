using System;

namespace CSharpDay3StudentLibrary
{
    public class Student
    {
        //Data Members
        int StudentId;
        string StudentName;
        int StudentAge;
        static string UniversityName;

        //Static Constructor
        static Student()
        {
            UniversityName = "Amity University";
        }

        //Member Function
        protected void AcceptDetails()
        {
            Console.Write("Enter Student Id :");
            this.StudentId = int.Parse(Console.ReadLine());
            Console.Write("Enter Student Name :");
            this.StudentName = Console.ReadLine();
            Console.Write("Enter Student Age :");
            this.StudentAge = int.Parse(Console.ReadLine());
        }

        protected void DisplayDetails()
        {
            Console.WriteLine("Student Details : ");
            Console.WriteLine("Student Id : {0}", this.StudentId);
            Console.WriteLine("Student Name : {0}", this.StudentName);
            Console.WriteLine("Student Age : {0}", this.StudentAge);
            Console.WriteLine("University Name : {0}", Student.UniversityName);
        }
    }
}
