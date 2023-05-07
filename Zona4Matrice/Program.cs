using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zona4Matrice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split(' ');
            int n = int.Parse(data[0]);
            int zona = int.Parse(data[1]);
            int[,] matrice = new int[n, n];
            int sumaNord = 0, sumaSud = 0, sumaEst = 0, sumaVest = 0;
            for (int i = 0; i < n; i++)
            {
                string[] buffer = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                    matrice[i, j] = int.Parse(buffer[j]);
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i < j && i + j < n - 1)
                        sumaNord += matrice[i, j];
                    if (i < j && i + j > n - 1)
                        sumaEst += matrice[i, j];
                    if (i > j && i + j > n - 1)
                        sumaSud += matrice[i, j];
                    if (i > j && i + j < n - 1)
                        sumaVest += matrice[i, j];
                }
            }
            switch (zona)
            {
                case 1:
                    Console.WriteLine(sumaNord);
                    break;
                case 2:
                    Console.WriteLine(sumaEst);
                    break;
                case 3:
                    Console.WriteLine(sumaSud);
                    break;
                case 4:
                    Console.WriteLine(sumaVest);
                    break;
                default:
                    break;
            }
        }
    }
}
