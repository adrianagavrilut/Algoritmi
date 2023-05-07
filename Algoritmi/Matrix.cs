using System;
using System.Collections.Generic;
using System.IO;

namespace Algoritmi
{
    public static class Matrix
    {
        public static Random rnd = new Random();

        public static int[,] Citire(int n, int m, int min, int max)
        {
            int[,] matrix = new int[n, m];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    matrix[i, j] = rnd.Next(min, max + 1);
            return matrix;
        }

        public static int[,] Citire()
        {
            string[] nm = Console.ReadLine().Split(' ');
            int n = int.Parse(nm[0]);
            int m = int.Parse(nm[1]);
            int[,] matrix = new int[n, m];
            string[] data;
            for (int i = 0; i < n; i++)
            {
                data = Console.ReadLine().Split(' ');
                for (int j = 0; j < m; j++)
                    int.Parse(data[j]);
            }
            return matrix;
        }

        public static int[,] Citire(int n, int m)
        {
            int[,] matrix = new int[n, m];
            string[] data;
            for (int i = 0; i < n; i++)
            {
                data = Console.ReadLine().Split(' ');
                for (int j = 0; j < m; j++)
                    int.Parse(data[j]);
            }
            return matrix;
        }

        public static int[,] Citire(string fileName, bool isNM)
        {
            if (isNM)
            {
                TextReader load = new StreamReader(fileName);
                string[] nm = load.ReadLine().Split(' ');
                int n = int.Parse(nm[0]);
                int m = int.Parse(nm[1]);
                int[,] matrix = new int[n, m];
                for (int i = 0; i < n; i++)
                {
                    string[] data = load.ReadLine().Split(' ');
                    for (int j = 0; j < m; j++)
                        matrix[i, j] = int.Parse(data[j]);
                }
                return matrix;
            }
            else
            {
                TextReader load = new StreamReader(fileName);
                List<string> lines = new List<string>();
                string line;
                while ((line = load.ReadLine()) != null)
                    lines.Add(line);
                load.Close();
                int n = lines.Count;
                int m = lines[0].Split(' ').Length;
                int[,] matrix = new int[n, m];
                for (int i = 0; i < n; i++)
                {
                    string[] data = lines[i].Split(' ');
                    for (int j = 0; j < m; j++)
                        matrix[i, j] = int.Parse(data[j]);
                }
                return matrix;
            }
        }

        public static void Afisare(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i,j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
