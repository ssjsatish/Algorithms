using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        List<List<int>> matrix = new List<List<int>>();
        for(int i=0;i<6;i++)
        {
            string[] elements = Console.ReadLine().Split(' ');
            matrix.Add(new List<int>());
            foreach (var item in elements)
            {
                matrix[i].Add(int.Parse(item));
            }
        }
        int max = -100500;
        int temp = 0;
        for (int i = 1; i <=4; i++)
        {
            for (int j = 1; j <=4; j++)
            {
                temp = matrix[i - 1][j + 1]+ matrix[i + 1][j + 1] + matrix[i - 1][j] + matrix[i][j] + matrix[i + 1][j] + matrix[i - 1][j - 1] + matrix[i + 1][j - 1];
            }
            max = Math.Max(max, temp);            
        }
        System.Console.WriteLine(max);

    }
}