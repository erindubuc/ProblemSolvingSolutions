using System;

public class FindLongestString
{
    string[] FindAllLongestStringsInArray(string[] inputArray)
    {
        int lengthOfLongestString = FindLongestStringLength(inputArray);

        List<string> longestStrings = new List<string>();

        for (int word = 0; word < inputArray.Length; word++)
        {
            if (inputArray[word].Length == lengthOfLongestString)
                longestStrings.Add(inputArray[word]);
        }

        return longestStrings.ToArray();
    }

    int FindLongestStringLength(string[] input)
    {
        int longestLengthOfString = 1;

        for (int str = 0; str < input.Length; str++)
        {
            if (input[str].Length > longestLengthOfString)
                longestLengthOfString = input[str].Length;
        }

        return longestLengthOfString;
    }
}
