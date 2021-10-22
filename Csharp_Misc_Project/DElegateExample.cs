using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Misc_Project
{
    public delegate void myDelegate(int num1, int num2);
    class Calculation
    {
        public void addition(int num1, int num2)
        {
            Console.WriteLine("Sum of two number:" + (num1 + num2));
        }
        public void subtraction(int num1, int num2)
        {
            Console.WriteLine("Difference between two number:" + (num1 - num2));
        }
        public void product(int num1, int num2)
        {
            Console.WriteLine("Product of two number:" + (num1 * num2));
        }
        public void divide(int num1, int num2)
        {
            Console.WriteLine("Division of two number:" + (num1 / num2));
        }
    }
    class DElegateExample
    {

        //static void Main(string[] args)
        //{
            //Calculation calc = new Calculation();
            //myDelegate del1 = new myDelegate(calc.addition);
            //myDelegate del2 = new myDelegate(calc.subtraction);
            //myDelegate del3 = new myDelegate(calc.product);
            //myDelegate del4 = new myDelegate(calc.divide);
            //del1(100, 20);
            //del2(100, 20);
            //del3(100, 20);
            //del4(100, 20);
            //del1.Invoke(100, 20);
            //del2.Invoke(100, 20);
            //del3.Invoke(100, 20);
            //del4.Invoke(100, 20);

            //myDelegate mydel = new myDelegate(calc.addition);
            //mydel(100, 20);
            //mydel += calc.subtraction;
            //mydel += calc.product;
            //mydel += calc.divide;
            //mydel(1000, 20);
            //Console.WriteLine("-------------------------------");
            //mydel -= calc.addition;
            //mydel(1000, 20);
            //Console.ReadKey();
        //}
    }
}
