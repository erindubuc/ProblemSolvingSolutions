using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_AlternatingChars
{
    class Program
    {
        // Complete the alternatingCharacters function below.
        static int AlternatingCharacters(string s)
        {
            char[] sChars = s.ToCharArray();
            List<char> stringChars = new List<char>();
            stringChars.Add(sChars[0]);

            int deleteCount = 0;

            for (int letter = 1; letter < sChars.Length; letter++)
            {
                if (sChars[letter] == sChars[letter - 1])
                    deleteCount++;
                else
                    stringChars.Add(sChars[letter]);
            }

            return deleteCount;
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string s = Console.ReadLine();

                int result = AlternatingCharacters(s);

                textWriter.WriteLine(result);
            }

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
