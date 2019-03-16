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

    // Complete the staircase function below.
    static void staircase(int n)
    {

        for (int line = 0; line < n; line++)
        {
            // spaces on first line are = to n - 1
            // then keep subtracting 1 space for each next line
            for (int spaces = 1; spaces <= n - 1 - line; spaces++)
                Console.Write(" ");

            // hashes on first line
            for (int hashes = 0; hashes < line + 1; hashes++)
                Console.Write("#");

            // start a new line
            Console.WriteLine();
        }
    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        staircase(n);
    }
}