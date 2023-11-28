using System;

namespace SahAmplasareCal
{
    class Program
    {
        static int n = 3;
        static int[,] tabla = new int[n, n];

        static void Main(string[] args)
        {
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    tabla[i, j] = -1;

            int[] xMutare = { 2, 1, -1, -2, -2, -1, 1, 2 };
            int[] yMutare = { 1, 2, 2, 1, -1, -2, -2, -1 };

            tabla[0, 0] = 0;

            if (!RezolvaSarituraCal(0, 0, 1, xMutare, yMutare))
            {
                Console.WriteLine("Nu exista solutie");
            }
            else
                Algoritmi.Matrix.AfisareCuSpatiu(tabla);
        }

        static bool RezolvaSarituraCal(int x, int y, int mutare, int[] xMutare, int[] yMutare)
        {
            int k, next_x, next_y;
            if (mutare == n * n)
                return true;

            for (k = 0; k < 8; k++)
            {
                next_x = x + xMutare[k];
                next_y = y + yMutare[k];
                if (EsteValid(next_x, next_y))
                {
                    tabla[next_x, next_y] = mutare;
                    if (RezolvaSarituraCal(next_x, next_y, mutare + 1, xMutare, yMutare))
                        return true;
                    else
                        tabla[next_x, next_y] = -1;
                }
            }
            return false;
        }

        static bool EsteValid(int x, int y)
        {
            return (x >= 0 && x < n && y >= 0 && y < n && tabla[x, y] == -1);
        }
    }
}
