using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Misc_Project
{
    class MainEntry
    {
        //static void PassByValue(int num)
        //{
        //    num = 200;
        //    Console.WriteLine("Number in passbyvalue method : " + num);

        //}
        //static void PassByReference(ref int num)
        //{
        //    num = 200;
        //    Console.WriteLine("Number in passbyreference method : " + num);

        //}
        //static void Swap(ref int num1, ref int num2)
        //{
        //    int temp = num1;
        //    num1 = num2;
        //    num2 = temp;
        //    Console.WriteLine("After Swapping");
        //    Console.WriteLine("Number1 in swap method : " + num1);
        //    Console.WriteLine("Number2 in swap method : " + num2);

        //}
        //static ref int GetFirstOddNum(int[] num)
        //{
        //    for(int i = 0;i<num.Length;i++)
        //    {
        //        if(num[i]%2==1)
        //        {
        //            return ref num[i];//returning reference
        //        }
        //    }
        //    throw new Exception("Odd num not found");
        //}

        static async Task<string> ShowInfo()
        {
            return $"Today is{DateTime.Today}\n Today's hours of leisure:{await GetLeisureHours()}";
        }

        static async Task<int> GetLeisureHours()
        {
            var today = await Task.FromResult<string>(DateTime.Now.DayOfWeek.ToString());
            int leisureHours;
            if(today.First()=='S')
            {
                leisureHours = 16;
            }
            else
            {
                leisureHours = 5;
            }
            return leisureHours;
        }
        //static void Main(string[] args)
        //{
            //int num1 = 100, num2=200;
            //Swap(ref num1, ref num2);
            //PassByValue(num);
            //PassByReference(ref num);
            //num = 300;
            //Console.WriteLine("After Swapping");
            //Console.WriteLine("Number1 in main method : " + num1);
            //Console.WriteLine("Number2 in main method : " + num2);

            //int num1 = 100;
            //ref int num2 = ref num1;
            //num2 = 1000;
            //Console.WriteLine("Num1: " + num1);
            //Console.ReadKey();

            //int[] nums = { 2, 6, 64, 56, 35, 57, 68, 73, 94 };
            //ref int oddNums = ref GetFirstOddNum(nums);
            //Console.WriteLine("Result: " + oddNums);
            //oddNums = 33;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}
        //    Console.WriteLine(ShowInfo().Result);
        //    Console.ReadKey();
        //}
    }
}
