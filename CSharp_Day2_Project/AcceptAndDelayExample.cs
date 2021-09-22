using System;

namespace CSharp_Day2_Project
{
    class Student
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
    class Marks: Student
    {
        protected float objectiveMarks, subjectiveMarks;

        protected new void AcceptDetails()
        {
            base.AcceptDetails();
            Console.Write("Enter Objective Marks:");
            this.objectiveMarks = float.Parse(Console.ReadLine());
            Console.Write("Enter Subjective Marks:");
            this.subjectiveMarks = float.Parse(Console.ReadLine());
        }
        protected new void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Student Marks Details : ");
            Console.WriteLine("Objective Marks : {0}", this.objectiveMarks);
            Console.WriteLine("Subjective Marks : {0}", this.subjectiveMarks);

        }
    }
    class Sports: Marks
    {
        protected float score;
        public new void AcceptDetails()
        {
            base.AcceptDetails();
            Console.Write("Enter Sports score:");
            this.score = float.Parse(Console.ReadLine());
        }
        public new void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Sports score : {0}", this.score);

        }
    }
    class Result : Sports
    {
        float totalMarks, AverageMarks;
        public void Calculate()
        {
            this.totalMarks = this.objectiveMarks + this.subjectiveMarks + this.score;
            this.AverageMarks = this.totalMarks / 3;
            Console.WriteLine("Total Marks : " + this.totalMarks);
            Console.WriteLine("Average Marks : " + this.AverageMarks);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Result std = new Result();
            std.AcceptDetails();
            std.DisplayDetails();
            std.Calculate();

            Console.ReadKey();
        }
    }
}
