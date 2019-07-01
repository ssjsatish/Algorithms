using System;
using System.Collections.Generic;
using System.IO;
public class Knapsack
{
    public static void Main(string[] args)
    {
        int t = int.Parse(Console.ReadLine().Trim());
        int W,n;
        while(t>0)
        {
            string[] token = Console.ReadLine().Trim().Split();
            n = int.Parse(token[0]);
            W = int.Parse(token[1]);
            string[] v = Console.ReadLine().Trim().Split();
            string[] wt = Console.ReadLine().Trim().Split();
            Console.WriteLine(ComputeKnapsackValue(W,wt,v,n));
            t--;
        }
    }
    public static int ComputeKnapsackValue(int W, string[] wt, string[] v, int n)
    {
        int i,w;
        int[,] m = new int[n+1, W+1];
        for(i=0;i<=n;i++)
        {
            for(w=0;w<=W;w++)
            {
                if(i==0 || w==0)
                {
                    m[i][w] = 0;
                }
                else if(wt[i-1]<=w)
                {
                    m[i,w] = Math.Max(int.Parse(v[i-1])+m[i-1,w-int.Parse(wt[i-1])], m[i-1,w]);
                }
                else{
                    m[i,w] = m[i-1,w];
                }
            }
        }
        return m[n,W];
    }
}