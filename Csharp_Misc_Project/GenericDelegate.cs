using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Misc_Project
{
    class GenericDelegate
    {
       // public delegate double additionOneDelegate(int x, float y, double z);
        //public delegate void additionTwoDelegate(int x, float y, double z);
        //public delegate bool checkLengthDelegate(string name);
        class Calculation
        {
            public static double addition1(int num1, float num2, double num3)
            {
                return num1 + num2 + num3;
            }
            public static void addition2(int num1, float num2, double num3)
            {
                Console.WriteLine("Addition Two Result: " + (num1 + num2 + num3));
            }
            public static bool CheckLength(string name)
            {
                if (name.Length > 5) return true;
                return false;
            }
        }
    //    static void Main(string[] args)
    //    {
    //        //Stack<string> stack = new Stack<string>();//Generic Collection
    //        //additionOneDelegate objOne = new additionOneDelegate(Calculation.addition1);
    //        //double result = objOne.Invoke(100, 125.25f, 456.678);
    //        //Console.WriteLine("Addition One Result: " + result);

    //        //additionTwoDelegate objTwo = new additionTwoDelegate(Calculation.addition2);
    //        //objTwo.Invoke(100, 125.25f, 456.678);

    //        //checkLengthDelegate objThree = new checkLengthDelegate(Calculation.CheckLength);
    //        //bool result1 = objThree.Invoke("Madhu Saha");
    //        //Console.WriteLine("String Length : " + result1);

    //        //Func<int, float, double, double> ObjOne = new Func<int, float, double, double>(Calculation.addition1);
    //        Func<int, float, double, double> ObjOne = (num1, num2, num3) =>
    //        {
    //            return num1 + num2 + num3;
    //        };
    //        double result = ObjOne.Invoke(100, 125.25f, 456.678);
    //        Console.WriteLine(result);

    //        //Action<int, float, double> objTwo = new Action<int, float, double>(Calculation.addition2);
    //        Action<int, float, double> objTwo = (num1, num2, num3) => { Console.WriteLine("Result: " + (num1 + num2 + num3)); };
    //        objTwo.Invoke(100, 125.25f, 456.678);

    //        Predicate<string> objThree = (name) =>
    //        {
    //            if (name.Length > 5) return true;
    //            return false;
    //        };
    //        //Predicate<string> objThree = new Predicate<string>(Calculation.CheckLength);
    //        bool result1 = objThree.Invoke("Madhu Saha");
    //        Console.WriteLine("String Length : " + result1);

    //        Console.ReadKey();
    //    }
    }
}
