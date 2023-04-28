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
                Console.WriteLine("\nChoose an option to perform \n1.Flip Coin \n2.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        FlipCoin.CalculatePercentage();
                        break;
                    case 2:
                        flag = false;
                        break;
                }
            }
        }
    }
}