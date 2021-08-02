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

class Result
{

    static int checkTree(int s, int t, int tree, List<int> fruits, Func<int, bool> pred, Func<int,int> action)
    {
        var count = 0;
        foreach(var fruit in fruits)
        {
            if (pred(fruit))
            {
                var m = action(fruit);
                if (m >= s && m <= t) count++;
            }
        }
        return count;
    }

    public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
    {
        var applesHit = checkTree(s, t, a, apples, d => d > 0, x => x + a);
        var orangesHit = checkTree(s, t, b, oranges, d => d < 0, x => b + x);

        Console.WriteLine($"{applesHit}\n{orangesHit}");
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        /*
        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int s = Convert.ToInt32(firstMultipleInput[0]);

        int t = Convert.ToInt32(firstMultipleInput[1]);

        string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int a = Convert.ToInt32(secondMultipleInput[0]);

        int b = Convert.ToInt32(secondMultipleInput[1]);

        string[] thirdMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int m = Convert.ToInt32(thirdMultipleInput[0]);

        int n = Convert.ToInt32(thirdMultipleInput[1]);
        */

        List<int> apples = new List<int>(){2}; //Console.ReadLine().TrimEnd().Split(' ').ToList().Select(applesTemp => Convert.ToInt32(applesTemp)).ToList();

        List<int> oranges = new List<int>(){-2}; //Console.ReadLine().TrimEnd().Split(' ').ToList().Select(orangesTemp => Convert.ToInt32(orangesTemp)).ToList(); 
        
        int s = 2, t = 3, a = 1, b = 5;

        Result.countApplesAndOranges(s, t, a, b, apples, oranges);
    }
}
