using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayThree_Project
{
    class Calculation
    {
        public int Addition(int num1, int num2)
        {
            return num1 + num2;
        }
        public int Addition(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }
        public float Addition(float num1, float num2)
        {
            return num1 + num2;
        }
        public float Addition(int num1, float num2)
        {
            return num1 + num2;
        }
        public float Addition(float num1, int num2)
        {
            return num1 + num2;
        }
    }
    //class OverloadingExample
    //{
    //    static void Main(string[] srgs)
    //    {
    //        Calculation calc = new Calculation();
    //        Console.WriteLine(calc.Addition(100,200,300));
    //        Console.WriteLine(calc.Addition(100,200));
    //        Console.WriteLine(calc.Addition(100,200.50f));

    //        Console.ReadKey();
    //    }
    //}
}
