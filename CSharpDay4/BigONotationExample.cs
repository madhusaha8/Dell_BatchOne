using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay5Project
{
    class BigONotationExample
    {
        public static void print(int[] numbers)
        {
            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[1]);

            //for (int i = 0; i < numbers.Length; i++)
            //{//Linear Notation: O(1)
            //    Console.WriteLine(numbers[i]);
            //}

            //Console.WriteLine("Hello Everyone");
            //for (int i = 0; i < numbers.Length; i++)
            //{//Linear Notation: O(1)
            //    Console.WriteLine(numbers[i]);
            //}
            //Console.WriteLine("Bye Everyone");


            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //Quadratic Notation: O(n^2)
            foreach (var first in numbers)
            {
                foreach (var second in numbers)
                {
                    Console.WriteLine(first + ":" + second);
                }

            }


        }
        static void Main(string[] args)
        {
                 int[] numbers = { 1, 2, 3, 4, 5 };
                    print(numbers);
                 Console.ReadKey();
        }
    }
}
