using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class LargestAmongThree
    {
        public static void GreatestNumber()
        {
            Console.WriteLine("Enter 1st number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 3rd number");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a > b && a > c)
            {
                Console.WriteLine("{0} is the Largest number", a);
            }
            else if (b > c)
            {
                Console.WriteLine("{0} is the Largest number", b);
            }
            else
            {
                Console.WriteLine("{0} is the Largest number", c);
            }
        }
    }
}
