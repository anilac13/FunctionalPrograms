using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class EvenOrOdd
    {
        public static void CheckEvenOrOdd()
        {
            Console.WriteLine("Enter any number");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num > 0)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine("{0} is an Even number",num);
                }
                else
                {
                    Console.WriteLine("{0} is an Odd number", num);
                }
            }
            else
            {
                Console.WriteLine("Enter positive integer only");
            }
        }
    }
}
