using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_MakingAnagrams
{
    class Program
    {

        // Complete the makeAnagram function below.
        static int MakeAnagram(string a, string b)
        {
            List<char> aChars = new List<char>();
            List<char> bChars = new List<char>();

            aChars.AddRange(a);
            bChars.AddRange(b);

            int totalChars = aChars.Count() + bChars.Count();

            int charsInCommon = 0;

            for (int charInA = 0; charInA < aChars.Count(); charInA++)
            {
                if (bChars.Contains(aChars[charInA]))
                {
                    charsInCommon++;
                    bChars.Remove(aChars[charInA]);
                }
            }

            return totalChars - (charsInCommon * 2);
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string a = Console.ReadLine();

            string b = Console.ReadLine();

            int res = MakeAnagram(a, b);

            textWriter.WriteLine(res);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
