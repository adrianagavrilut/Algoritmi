using System;
using System.IO;

namespace GrafMatrici
{
    class Program
    {
        public static int n, inf = 99999;
        public static int[,] matrAdiacenta, matrPonderi, matrDrum, matrCostMin;

        static void Main(string[] args)
        {
            TextReader load = new StreamReader(@"..\..\TextFile1.txt");
            n = int.Parse(load.ReadLine());
            matrAdiacenta = new int[n, n];
            matrPonderi = new int[n, n];
            matrDrum = new int[n, n];
            matrCostMin = new int[n, n];
            string buffer;
            while ((buffer = load.ReadLine()) != null)
            {
                string[] data = buffer.Split(' ');
                int nodStart = int.Parse(data[0]);
                int nodSfarsit = int.Parse(data[1]);
                int cost = int.Parse(data[2]);
                matrAdiacenta[nodStart, nodSfarsit] = 1;
                matrPonderi[nodStart, nodSfarsit] = cost;
            }
            load.Close();
            Console.WriteLine(" Matricea de adiacenta: ");
            AfisareMatrice(matrAdiacenta);
            Console.WriteLine(" Matricea ponderilor: ");
            AfisareMatrice(matrPonderi);
            Console.WriteLine(" Matricea drumurilor: ");
            RoyWarshall();
            AfisareMatrice(matrDrum);
            Console.WriteLine(" Matricea drumurilor de cost minim: ");
            RoyFLoyd();
            AfisareMatrice(matrCostMin);
        }

        private static void RoyWarshall()
        {
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    matrDrum[i, j] = matrAdiacenta[i, j];
            for (int k = 0; k < n; k++)
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                        if (i != j && matrDrum[i, j] == 0)
                            matrDrum[i, j] = matrDrum[i, k] * matrDrum[k, j];
        }

        private static void RoyFLoyd()
        {
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                        matrCostMin[i, j] = 0;
                    else if (matrPonderi[i, j] != 0)
                        matrCostMin[i, j] = matrPonderi[i, j];
                    else
                        matrCostMin[i, j] = inf;
                }
            for (int k = 0; k < n; k++)
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                        if (matrCostMin[i, k] + matrCostMin[k, j] < matrCostMin[i, j])
                            matrCostMin[i, j] = matrCostMin[i, k] + matrCostMin[k, j];
        }

        private static void AfisareMatrice(int[,] m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (m[i, j] == inf)
                        Console.Write(" f");
                    else
                        Console.Write($" {m[i, j]}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
