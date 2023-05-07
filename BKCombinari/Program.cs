using System;
namespace BKCombinari
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 4;
            int k = 3;
            int[] sol = new int[n];
            bool[] vizitat = new bool[n];
            BKComb(0, n, k, sol, vizitat);
            Console.WriteLine();
            int[] sol2 = new int[n + 1];
            sol2[0] = 0;
            //BKComb2(1, n, k, sol2);
        }

        private static void BKComb(int niv, int n, int k, int[] sol, bool[] b)
        {//conditia e la afisare
            if (niv >= k)
            {
                bool ok = true;
                for (int i = 0; i < k - 1; i++)
                {
                    if (sol[i] > sol[i + 1])
                    {
                        ok = false;
                        break;
                    }
                }
                if (ok)
                {
                    for (int i = 0; i < k; i++)
                        Console.Write(sol[i] + " ");
                    Console.WriteLine();
                }
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    if (!b[i])
                    {
                        b[i] = true;
                        sol[niv] = i + 1;
                        BKComb(niv + 1, n, k, sol, b);
                        b[i] = false;
                    }
                }
            }
        }

        private static void BKComb2(int niv, int n, int k, int[] sol)
        {//conditia e la generare
            if (niv > k)
            {
                for (int i = 1; i <= k; i++)
                    Console.Write(sol[i] + " ");
                Console.WriteLine();
            }
            else
            {
                for (int i = sol[niv - 1] + 1; i <= n; i++)
                {
                    sol[niv] = i;
                    BKComb2(niv + 1, n, k, sol);
                }
            }
        }
    }
}
