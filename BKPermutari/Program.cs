using System;
namespace BKPermutari
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            int[] sol = new int[n];
            bool[] vizitat = new bool[n];
            BkPermut(0, n, sol);
            Console.WriteLine();
            //BkPermut2(0, n, sol, vizitat);
        }

        private static void BkPermut(int niv, int n, int[] sol)//n^n
        {
            if (niv >= n)
            {
                bool ok = true;
                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        if (sol[i] == sol[j])
                        {
                            ok = false;
                            break;
                        }
                    }
                }
                if (ok)
                {
                    for (int i = 0; i < n; i++)
                        Console.Write(sol[i] + " ");
                    Console.WriteLine();
                }
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    sol[niv] = i + 1;
                    BkPermut(niv + 1, n, sol);
                }
            }
        }

        public static void BkPermut2(int niv, int n, int[] sol, bool[] b)//n!
        {
            if (niv >= n)
            {
                for (int i = 0; i < n; i++)
                    Console.Write(sol[i] + " ");
                Console.WriteLine();
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    if (!b[i])
                    {
                        b[i] = true;
                        sol[niv] = i + 1;
                        BkPermut2(niv + 1, n, sol, b);
                        b[i] = false;
                    }
                }
            }
        }
    }
}
