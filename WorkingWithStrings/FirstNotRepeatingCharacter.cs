using System;

public class FirstNotRepeatingCharacter
{
    public char FindFirstNotRepeatingCharacterInString(string s)
    {
        foreach (char c in s)
        {
            if (s.LastIndexOf(c) == s.IndexOf(c))
                return c;
        }

        return '_';
    }
}
