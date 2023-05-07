using System;
using System.IO;

namespace Algoritmi
{
    public static class Array
    {
        public static Random rnd = new Random();

        public static int[] Citire(int n, int min, int max)
        {
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
                v[i] = rnd.Next(min, max + 1);
            return v;
        }

        public static int[] Citire(int n)
        {
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
                int.Parse(Console.ReadLine());
            return v;
        }

        public static int[] Citire()
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
                int.Parse(Console.ReadLine());
            return v;
        }

        public static int[] Citire(string fileName, bool isN)
        {
            if (isN)
            {
                TextReader load = new StreamReader(fileName);
                int n = int.Parse(load.ReadLine());
                int[] v = new int[n];
                string[] data = load.ReadLine().Split(' ');
                for (int i = 0; i < n; i++)
                {
                    v[i] = int.Parse(data[i]);
                }
                return v;
            }
            else
            {
                TextReader load = new StreamReader(fileName);
                string[] data = load.ReadLine().Split(' ');
                int[] v = new int[data.Length];
                for (int i = 0; i < data.Length; i++)
                {
                    v[i] = int.Parse(data[i]);
                }
                return v;
            }
        }

        public static void Afisare(int[] v)
        {
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write(v[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
