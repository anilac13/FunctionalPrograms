using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class PrimeFactors
    {
        public static void FindPrimeFactors()
        {
            Console.WriteLine("Enter number to find prime factors");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Prime Factors are:");
            for (int i = 2; i <= num/2; i++)
            {
                if (num%i == 0)
                {
                    Console.Write(" "+i);
                }
            }
        }
    }
}
