using System;
namespace BKProdusCartezian
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            int[] sol = new int[n];
            BKProdCart(0, n, sol);
        }

        private static void BKProdCart(int niv, int n, int[] sol)
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
                    sol[niv] = i + 1;
                    BKProdCart(niv + 1, n, sol);
                }
            }
        }
    }
}