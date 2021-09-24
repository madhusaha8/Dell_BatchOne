using CsharpDay3SportsLibrary;
using System;

namespace CSharp_Day3ResultLibrary
{
    public class Result : Sports
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
}
