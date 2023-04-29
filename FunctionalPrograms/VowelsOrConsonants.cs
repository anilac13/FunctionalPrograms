using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class VowelsOrConsonants
    {
        public static void FindVowelOrConsonant()
        {
            Console.WriteLine("Enter any character");
            char ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'a'|| ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine("{0} is Vowel", ch);
            }
            else if((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                Console.WriteLine("{0} is Consonant", ch);
            }
            else
            {
                Console.WriteLine("Enter Valid alphabet");
            }
        }
    }
}
