using System;

namespace ApaVector
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int n = 13;
            int apa = 0;
            int[] v = Algoritmi.Array.Citire(n, 0, 10);
            Algoritmi.Array.Afisare(v);
            bool ok;
            for (int i = 1; i < n - 1; i++)
            {
                do
                {
                    ok = true;
                    int value = v[i] + 1;
                    bool br = false, bl = false;
                    int j = i;
                    while (j >= 0)
                    {
                        if (value <= v[j])
                        {
                            bl = true;
                            break;
                        }
                        j--;
                    }
                    j = i;
                    while (j < n)
                    {
                        if (value <= v[j])
                        {
                            br = true;
                            break;
                        }
                        j++;
                    }
                    if (bl && br)
                    {
                        v[i]++; apa++;
                        ok = false;
                    }
                } while (!ok);
            }
            Algoritmi.Array.Afisare(v);
            Console.WriteLine("apa : " + apa);
        }
    }
}