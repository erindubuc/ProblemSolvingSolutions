using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewChallenges
{
    public class Strings_AmendTheSentence
    {
        /* You have been given a string s, which is supposed to be a sentence. 
         * However, someone forgot to put spaces between the different words, 
         * and for some reason they capitalized the first letter of every word. 
         * Return the sentence after making the following amendments:
            -Put a single space between the words.
            -Convert the uppercase letters to lowercase.
        */

        public string AmendTheSentence(string s)
        {
            StringBuilder allLowerWithSpaces = new StringBuilder();

            if (!string.IsNullOrEmpty(s))
                s = char.ToLower(s[0]) + s.Substring(1);

            foreach (char c in s)
            {
                if (char.IsUpper(c))
                    allLowerWithSpaces.Append(' ');

                allLowerWithSpaces.Append(char.ToLower(c));
            }

            return allLowerWithSpaces.ToString();
        }
    }
}
