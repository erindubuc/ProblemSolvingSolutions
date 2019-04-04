using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{

    //Given the string, check if it is a palindrome.

    public class Program
    {
        public static void Main(string[] args)
        {
            string inputString = Console.ReadLine();

            
            Console.WriteLine($"Is the word {inputString} a palindrome? " + CheckPalindrome(inputString));
            Console.ReadLine();
        }

        public static bool CheckPalindrome(string inputString)
        {
            char[] reversedString = new char[inputString.Length];

            int forward = 0;

            for (int moveBackwards = inputString.Length - 1; moveBackwards >= 0; moveBackwards--)
            {
                reversedString[forward++] = inputString[moveBackwards];
            }

            string totalReversal = new string(reversedString);

            if (totalReversal == inputString)
                return true;

            return false;
        }
    }
}
