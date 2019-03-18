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
    /* You are in charge of the cake for your niece's 
     * birthday and have decided the cake will have one 
     * candle for each year of her total age. When she 
     * blows out the candles, she’ll only be able to blow 
     * out the tallest ones. Your task is to find out how 
     * many candles she can successfully blow out.
    */
    // Complete the birthdayCakeCandles function below.
    static int birthdayCakeCandles(int[] ar)
    {
        int maxNumOfCandles = 0;
        Array.Sort(ar);
        int largestNumInAr = ar.Max();
        for (int i = 0; i < ar.Length; i++)
        {
            if (ar[i] == largestNumInAr)
                maxNumOfCandles++;
        }

        return maxNumOfCandles;

    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arCount = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
        ;
        int result = birthdayCakeCandles(ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}

