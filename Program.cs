using System;
using System.Text;
using System.Collections;
using System.Data;

namespace SmartGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number : ");
                int Number = Convert.ToInt16(Console.ReadLine());
                double SqrtNumber = Math.Sqrt(Number);
                Console.WriteLine("Square root of {0} is: {1}", Number, SqrtNumber);
                Console.ReadLine();


               if (Number <  0)
               {
                  Console.WriteLine ("Error, Number should be more than zero");
               }
               else
               {
                   Console.WriteLine("Square root of {0} is: {1}", Number, SqrtNumber);
                Console.ReadLine();
               }

               
        }
        
    }
}
