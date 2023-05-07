using System;
namespace BKAranjamente
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 4;
            int k = 3;
            int[] sol = new int[n];
            bool[] vizitat = new bool[n];
            BKAranj(0, n, k, sol, vizitat);
        }

        private static void BKAranj(int niv, int n, int k, int[] sol, bool[] b)
        {
            if (niv >= k)
            {
                for (int i = 0; i < k; i++)
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
                        BKAranj(niv + 1, n, k, sol, b);
                        b[i] = false;
                    }
                }
            }
        }
    }
}
