using System;
using System.Net.Http;

namespace CSharpDay4Project
{
    //class PriceException: Exception
    //{
    //    public PriceException(string message): base(message) { }
    //    public PriceException(): base("Invalid Price") { }

    //}
    //class ExceptionHandlingDemo5
    //{
    //    static void Main(string[] args)
    //    {
    //        try
    //        {
    //            float sellingPrice, costPrice;
    //            Console.Write("Enter Selling Price");
    //            sellingPrice = float.Parse(Console.ReadLine());
    //            Console.Write("Enter Cost Price");
    //            costPrice = float.Parse(Console.ReadLine());

    //            if (sellingPrice <= 0)
    //            {
    //                //throw new PriceException("Selling Price cannot be Zero or Less");
    //                throw new PriceException();
    //            }
    //            if (costPrice <= 0)
    //            {
    //                //throw new PriceException("Cost Price cannot be Zero or Less");
    //                throw new PriceException();
    //            }
    //            else
    //            {
    //                if (sellingPrice > costPrice)
    //                {
    //                    Console.WriteLine("Profit Occurred");
    //                }
    //                else if (sellingPrice < costPrice)
    //                {
    //                    Console.WriteLine("Loss Occurred");

    //                }
    //                else
    //                {
    //                    Console.WriteLine("No Profit No Loss");

    //                }
    //            }                
    //        }
    //        catch(FormatException ex)
    //        {
    //            Console.WriteLine("Format Exception " + ex.Message);

    //        }
    //        catch (PriceException ex)
    //        {
    //            Console.WriteLine("Price Exception " + ex.Message);

    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine("Generic Exception "+ex.Message);
    //        }
    //        Console.ReadKey();
    //    }
    //}
}
