using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class SwapTwoNumbers
    {
        public static void SwapNumbers()
        {
            Console.WriteLine("Enter first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before Swapping a = {0}, b = {1}", a, b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("After Swapping a = {0}, b = {1}", a, b);

            //a = a * b;
            //b = a / b;
            //a = a / b;
        }
    }
}
