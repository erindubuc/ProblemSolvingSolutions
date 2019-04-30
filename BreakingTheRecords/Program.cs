using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the breakingRecords function below.
    static int[] BreakingRecords(int[] scores)
    {
        int[] bestAndWorstChanges = new int[2];

        int highChanges = 0;
        int lowChanges = 0;

        int high = scores[0];
        int low = scores[0];

        for (int scoresIndex = 1; scoresIndex < scores.Length; scoresIndex++)
        {
            if (scores[scoresIndex] > high)
            {
                high = scores[scoresIndex];
                highChanges++;
            }
            if (scores[scoresIndex] < low)
            {
                low = scores[scoresIndex];
                lowChanges++;
            }
            else
                continue;
        }

        bestAndWorstChanges[0] = highChanges;
        bestAndWorstChanges[1] = lowChanges;
        return bestAndWorstChanges;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp))
        ;
        int[] result = breakingRecords(scores);

        textWriter.WriteLine(string.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
