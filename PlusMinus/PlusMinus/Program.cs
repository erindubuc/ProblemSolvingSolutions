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
    /* Given an array of integers, calculate the fractions 
     * of its elements that are positive, negative, and 
     * are zeros. Print the decimal value of each fraction 
     * on a new line.
    */
    // Complete the plusMinus function below.
    static void plusMinus(int[] arr)
    {
        decimal positive = 0m;
        decimal negative = 0m;
        decimal zero = 0m;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == 0)
                ++zero;
            if (arr[i] < 0)
                ++negative;
            if (arr[i] > 0)
                ++positive;
        }

        positive = positive / arr.Length;
        negative = negative / arr.Length;
        zero = zero / arr.Length;

        Console.WriteLine(positive.ToString("N" + 6));
        Console.WriteLine(negative.ToString("N" + 6));
        Console.WriteLine(zero.ToString("N" + 6));

    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        plusMinus(arr);
    }
}
