using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class QuotientAndRemainder
    {
        public static void Operation()
        {
            Console.WriteLine("Enter Dividend");
            int dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Divisor");
            int divisor = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dividend is: {0}, Divisor is: {1}", dividend, divisor);
            int quotient = dividend / divisor;
            int remainder = dividend % divisor;
            Console.WriteLine("Quotient = {0}", quotient);
            Console.WriteLine("Remainder = {0}", remainder);
        }
    }
}
