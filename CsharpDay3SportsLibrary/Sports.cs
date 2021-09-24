using CsharpDay3MarksLibrary;
using System;

namespace CsharpDay3SportsLibrary
{
    public class Sports : Marks
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
}
