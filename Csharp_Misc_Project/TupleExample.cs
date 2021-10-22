using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Misc_Project
{
    class TupleExample
    {
        static (int count,double sum) Calculate(IEnumerable<double> list)
        {
            int count = 0;
            double sum = 0.0d;
            foreach(var value in list)
            {
                count++;
                sum += value;
            }
            //Tuple<int, double> tuple = Tuple.Create(count, sum);
            //return tuple;
            return (count, sum);
        }
        //static void Main(string[] args)
        //{
        //    var list = new List<double> { 10, 20, 30, 40, 50 };
        //    var (countResult, sumResult) = Calculate(list);
        //    //Tuple<int, double> t = Calculate(list);
        //    Console.WriteLine("There are {0} items in list ",countResult );
        //    Console.WriteLine("sum of their value in list: {0}", sumResult);
        //}
    }
}
