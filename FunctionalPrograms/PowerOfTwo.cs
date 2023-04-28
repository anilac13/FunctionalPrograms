using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class PowerOfTwo
    {
        public static void FindPowerOf2()
        {
            Console.WriteLine("Enter value for the power");
            int power = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < power; i++)
            {
                //double result = Math.Pow(2, i);
                //Console.WriteLine("2^" + i + " = " +result);

                Console.WriteLine("2^" + i + " = " + Math.Pow(2, i));
                if (i == 30)
                    break;
            }
        }
    }
}
