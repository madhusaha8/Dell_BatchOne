using CSharpDay3StudentLibrary;
using System;

namespace CsharpDay3MarksLibrary
{
   public class Marks : Student
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
}
