using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swapping_Numbers
{
    class Program
    {
       public static void Main(string[] args)
        {
            //Create a new class for swappping nunmbers.
            //Call swapping function from here.
            int a = 10;
            int b = 20;
            Console.WriteLine("After swap a = {0} and b = {1}", a, b);
            Console.ReadLine();
            a = a + b; // a * b
            b = a - b; // a / b
            a = a - b; // a / b

            Console.WriteLine("After swap a = {0} and b = {1}", a, b);
            Console.ReadLine();

        }
    }
}