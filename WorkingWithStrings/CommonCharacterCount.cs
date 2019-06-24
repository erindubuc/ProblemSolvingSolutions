using System;

public class CommonCharacters
{
    int FindCommonCharacterCountOfTwoStrings(string s1, string s2)
    {
        Dictionary<char, int> charCounter = new Dictionary<char, int>();
        int commonCharCount = 0;

        foreach (char c in s1)
        {
            if (charCounter.ContainsKey(c))
                charCounter[c]++;
            else
                charCounter.Add(c, 1);
        }

        foreach (char c in s2)
        {
            if (charCounter.ContainsKey(c) && charCounter[c] > 0)
            {
                charCounter[c]--;
                commonCharCount++;

            }
        }

        return commonCharCount;
    }
}
