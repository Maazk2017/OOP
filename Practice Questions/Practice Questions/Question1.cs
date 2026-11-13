using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_Questions
{
    internal class Question1
    {
    }

        //// 1. Custom Business Exception
        //public class OutOfStockException : Exception
        //{
        //    public OutOfStockException(string message, Exception innerException)
        //        : base(message, innerException)
        //    {
        //    }
        //}

        //internal class Program
        //{
        //    static void Main(string[] args)
        //    {
        //        try
        //        {
        //            ProcessOrder();
        //        }
        //        catch (OutOfStockException ex)
        //        {
        //            // Business-level message
        //            Console.WriteLine("Business Error: " + ex.Message);

        //            // Root cause (InnerException)
        //            if (ex.InnerException != null)
        //            {
        //                Console.WriteLine("Root Cause: " + ex.InnerException.Message);
        //            }
        //        }
        //    }

        //    static void ProcessOrder()
        //    {
        //        try
        //        {
        //            Console.WriteLine("Processing order...");

        //            int[] stock = { 5, 0, 3 }; // product stock list

        //            int productIndex = 5; // invalid index → will cause exception

        //            // This will throw IndexOutOfRangeException
        //            int availableStock = stock[productIndex];

        //            if (availableStock == 0)
        //            {
        //                Console.WriteLine("Product is out of stock.");
        //            }
        //            else
        //            {
        //                Console.WriteLine("Order placed successfully!");
        //            }
        //        }
        //        catch (IndexOutOfRangeException ex)
        //        {
        //            // Wrap system exception into business exception
        //            throw new OutOfStockException(
        //                "Product could not be processed due to stock issue.",
        //                ex
        //            );
        //        }
        //    }
        //}
    //}
}
