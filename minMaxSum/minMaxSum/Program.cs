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
    /* Given five positive integers, find the minimum and 
     * maximum values that can be calculated by summing exactly 
     * four of the five integers. Then print the respective 
     * minimum and maximum values as a single line of two 
     * space-separated long integers
    */
    // Complete the miniMaxSum function below.
    static void miniMaxSum(int[] arr)
    {
        long minSum = 0;
        long maxSum = 0;
        Array.Sort(arr);

        for (int i = 0; i < arr.Length - 1; i++)
            minSum += arr[i];

        for (int j = arr.Length - 1; j > 0; j--)
            maxSum += arr[j];

        Console.WriteLine(minSum + " " + maxSum);
    }

    static void Main(string[] args)
    {
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        miniMaxSum(arr);
    }
}

