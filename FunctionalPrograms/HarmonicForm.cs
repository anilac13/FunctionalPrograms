using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class HarmonicForm
    {
        public static void PrintHarmonicForm()
        {
            Console.WriteLine("Enter number to print in Harmonic form");
            int num = Convert.ToInt32(Console.ReadLine());
            double result = 0;
            for (double i = 1; i <= num; i++)
            {
                Console.Write("1/"+i);
                if (i < num)
                    Console.Write(" +");
                result += 1 / i;
            }
            Console.WriteLine("\nNth Harmonic value is: "+result);
        }
    }
}
