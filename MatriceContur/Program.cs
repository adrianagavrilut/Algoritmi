using System;

namespace MatriceContur
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrice = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    matrice[i, j] = int.Parse(data[j]);
                }
            }
            for (int i = 0; i < n - 1; i++)
                Console.Write($"{matrice[0, i]} ");
            for (int i = 0; i < n - 1; i++)
                Console.Write($"{matrice[i, n - 1]} ");
            for (int i = n - 1; i > 0; i--)
                Console.Write($"{matrice[n - 1, i]} ");
            for (int i = n - 1; i > 0; i--)
                Console.Write($"{matrice[i, 0]} ");
        }
    }
}