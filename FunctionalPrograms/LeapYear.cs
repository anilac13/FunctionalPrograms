using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class LeapYear
    {
        public static void CheckLeapYear()
        {
            Console.WriteLine("\nEnter an year to check Leap year");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year > 999 &&  year < 10000)
            {
                if (year % 4 == 0)
                {
                    Console.WriteLine("{0} is a Leap year", year);
                }
                else
                {
                    Console.WriteLine("{0} is not a Leap year", year);
                }
            }
            else
            {
                Console.WriteLine("Please enter year in YYYY format only");
            }
        }
    }
}
