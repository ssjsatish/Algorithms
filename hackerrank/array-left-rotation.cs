using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(string[] args)
    {
        // 5 4
        // 1 2 3 4 5
        // 5 1 2 3 4
        int n,k;
        string[] input = Console.ReadLine().Trim().Split(' ');
        n = Convert.ToInt32(LinkedList[0]);
        k = Convert.ToInt32(LinkedList[1]);
        string[] line = Console.ReadLine().Trim().Split(' ');
        for(int i = k;i<n;i++)
        {
            Console.Write("{0} ", line[i]);
        }
        for(int i=0;i<k;i++)
        {
            Console.Write("{0} ", line[i]);
        }


    }
}