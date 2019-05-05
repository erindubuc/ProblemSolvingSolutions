using System.CodeDom.Compiler;
using System.Collections.Generic;
using System;

class Solution
{

    // Complete the checkMagazine function below.
    static void CheckMagazineForNoteWords(string[] magazine, string[] note)
    {

        Dictionary<string, int> magazineDictionary = new Dictionary<string, int>();
        foreach (var word in magazine)
        {
            if (magazineDictionary.ContainsKey(word))
                magazineDictionary[word]++;
            else
                magazineDictionary.Add(word, 1);
        }

        foreach (string word in note)
        {

            if (!magazineDictionary.ContainsKey(word) || magazineDictionary[word] < 1)
            {
                Console.WriteLine("No");
                return;
            }

            else
            {
                magazineDictionary[word]--;
            }

        }
        Console.WriteLine("Yes");
    }

    static void Main(string[] args)
    {
        string[] mn = Console.ReadLine().Split(' ');

        int m = Convert.ToInt32(mn[0]);

        int n = Convert.ToInt32(mn[1]);

        string[] magazine = Console.ReadLine().Split(' ');

        string[] note = Console.ReadLine().Split(' ');

        CheckMagazineForNoteWords(magazine, note);
    }
}

