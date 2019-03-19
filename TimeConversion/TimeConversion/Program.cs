using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    /*Given a time in 12-hour AM/PM format, convert it to military 
     * (24-hour) time.
     * Complete the timeConversion function below.
     */
    static string timeConversion(string s)
    {
        DateTime military = new DateTime();
        bool parsedTime = DateTime.TryParse(s, out military);
        return military.ToString("HH:mm:ss");
    }

    static void Main(string[] args)
    {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = timeConversion(s);

        tw.WriteLine(result);

        tw.Flush();
        tw.Close();
    }
}