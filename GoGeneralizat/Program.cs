using System;

namespace GoGeneralizat
{
    class Program
    {
        static int[,] matr;
        static bool[,] vizitat;
        static bool[] gasit;
        static int[] contoare;
        static int nr, nrTeritorii, poz;

        static void Main(string[] args)
        {
            matr = Algoritmi.Matrix.Citire(@"..\..\TextFile1.txt", false);
            Algoritmi.Matrix.Afisare(matr);
            nrTeritorii = MaxVal(matr);
            gasit = new bool[nrTeritorii];
            contoare = new int[nrTeritorii];
            int n = matr.GetLength(0);
            int m = matr.GetLength(1);
            vizitat = new bool[n, m];
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    if (!vizitat[i, j])
                    {
                        for (int k = 0; k < nrTeritorii; k++)
                            gasit[k] = false;
                        nr = 0;
                        pA(i, j);
                        if (OnePositionTrue(gasit))
                            contoare[poz] += nr;
                    }
                }
            }
            Console.WriteLine();
            for (int i = 0; i < nrTeritorii; i++)
                Console.WriteLine($"{i + 1} : {contoare[i]}");
            Console.WriteLine();
        }

        static void pA(int i, int j)
        {
            if (i >= 0 && j >= 0 && i < matr.GetLength(0) && j < matr.GetLength(1) && !vizitat[i, j])
            {
                if (matr[i, j] == 0)
                {
                    nr++;
                    vizitat[i, j] = true;
                    pA(i - 1, j);
                    pA(i, j + 1);
                    pA(i + 1, j);
                    pA(i, j - 1);
                }
                else
                {
                    for (int k = 0; k < gasit.Length; k++)
                        if (matr[i, j] == k + 1)
                            gasit[k] = true;
                }
            }
        }

        private static int MaxVal(int[,] matrix)
        {
            int max = -1;
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    if (matrix[i, j] > max)
                        max = matrix[i, j];
            return max;
        }

        private static bool OnePositionTrue(bool[] gasit)
        {
            int trueCount = 0;
            for (int i = 0; i < gasit.Length; i++)
            {
                if (gasit[i])
                {
                    trueCount++;
                    poz = i;
                }
            }
            if (trueCount == 1)
                return true;
            else 
                return false;
        }
    }
}
