using System.Collections.Generic;
using System.IO;
using System;

class Solution
{

    // Complete the twoStrings function below.
    static string DoTwoStringsHaveSameSubstring(string s1, string s2)
    {
        char[] charactersFromOne = s1.ToCharArray();
        char[] charactersFromTwo = s2.ToCharArray();

        IDictionary<char, int> stringOneDict = new Dictionary<char, int>();

        foreach (var character in charactersFromOne)
        {
            if (stringOneDict.ContainsKey(character))
                stringOneDict[character]++;

            else
                stringOneDict.Add(character, 1);
        }

        foreach (var character in charactersFromTwo)
        {
            if (stringOneDict.ContainsKey(character))
                return "YES";
        }
        return "NO";
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string s1 = Console.ReadLine();

            string s2 = Console.ReadLine();

            string result = DoTwoStringsHaveSameSubstring(s1, s2);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
