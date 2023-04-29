using System;
namespace FunctionalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nChoose an option to perform \n1.Flip Coin \n2.Leap Year \n3.Power of Two \n4.Nth Harmonic number \n5.Prime Factors of a Number " +
                    "\n6.Quotient and Remainder \n7.Swap two numbers \n8.Even or Odd \n9.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        FlipCoin.CalculatePercentage();
                        break;
                    case 2:
                        LeapYear.CheckLeapYear();
                        break;
                    case 3:
                        PowerOfTwo.FindPowerOf2();
                        break;
                    case 4:
                        HarmonicForm.PrintHarmonicForm();
                        break;
                    case 5:
                        PrimeFactors.FindPrimeFactors();
                        break;
                    case 6:
                        QuotientAndRemainder.Operation();
                        break;
                    case 7:
                        SwapTwoNumbers.SwapNumbers();
                        break;
                    case 8:
                        EvenOrOdd.CheckEvenOrOdd();
                        break;
                    case 9:
                        flag = false;
                        break;
                }
            }
        }
    }
}