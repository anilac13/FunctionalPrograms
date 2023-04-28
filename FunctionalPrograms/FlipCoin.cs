using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class FlipCoin
    {
        public static void CalculatePercentage()
        {
            Console.WriteLine("\nPlease enter number of times to flip a coin");
            int flipCoin = Convert.ToInt32(Console.ReadLine());
            if (flipCoin > 0)
            {
                int headsCount = 0, tailsCount = 0;
                for (int i=1; i<=flipCoin; i++)
                {
                    Random random = new Random();
                    double result = random.NextDouble();
                    if (result > 0.5)
                    {
                        headsCount++;
                    }
                    if (result < 0.5)
                    {
                        tailsCount++;
                    }
                }
                Console.WriteLine("Heads count = {0} times", headsCount);
                Console.WriteLine("Tails count = {0} times", tailsCount);
                double headsPercentage = headsCount * 100 / flipCoin;
                double tailsPercentage = tailsCount * 100 / flipCoin;
                Console.WriteLine("Heads percentage = {0}%", headsPercentage);
                Console.WriteLine("Tails percentage = {0}%", tailsPercentage);
            }
            else
            {
                Console.WriteLine("Enter positive integer only");
            }
        }
    }
}
