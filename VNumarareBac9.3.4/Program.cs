using System;

namespace VNumarareBac9._3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = Algoritmi.Array.Citire(@"..\..\BAC.txt", false);
            bool[] apareNr = new bool[1000];
            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] < 1000)
                    apareNr[v[i]] = true;
            }
            int nr1 = -1, nr2 = -1;
            for (int i = 999; i >= 100; i--)
            {
                if (!apareNr[i])
                {
                    if (nr1 == -1)
                        nr1 = i;
                    else if (nr2 == -1)
                        nr2 = i;
                    else 
                        break;
                }
            }
            if (nr1 != -1 && nr2 != -1)
                Console.WriteLine($"{nr2}, {nr1}");
            else
                Console.WriteLine("0");
            Console.WriteLine();
        }
    }
}