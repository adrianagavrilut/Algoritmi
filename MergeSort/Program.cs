using System;

namespace MergeSort
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Console.Write("Introduceti n = ");
            int n = int.Parse(Console.ReadLine());
            int[] vector = Algoritmi.Array.Citire(n, 0, 100);
            Console.Write("Vectorul initial: ");
            Algoritmi.Array.Afisare(vector);
            Console.Write("Vectorul sortat: ");
            MergeSort(vector, 0, n - 1);
            Algoritmi.Array.Afisare(vector);
            Console.ReadKey();
        }

        static public void MergeSort(int[] vector, int st, int dr)
        {
            if (st < dr)
            {
                int mij = st + (dr - st) / 2;
                MergeSort(vector, st, mij);
                MergeSort(vector, (mij + 1), dr);
                Interclasare(vector, st, mij, dr);
            }
        }

        static public void Interclasare(int[] vector, int st, int mij, int dr)
        {
            int[] vSt = new int[mij - st + 1];
            int[] vDr = new int[dr - mij];
            int i, j;
            for (i = st; i <= mij; i++)
            {
                vSt[i - st] = vector[i];
            }
            for (j = mij + 1; j <= dr; j++)
            {
                vDr[j - (mij + 1)] = vector[j];
            }
            i = 0; j = 0;
            int k = 0;
            while (i < vSt.Length && j < vDr.Length)
            {
                if (vSt[i] <= vDr[j])
                {
                    vector[st + k] = vSt[i];
                    i++; k++;
                }
                else
                {
                    vector[st + k] = vDr[j];
                    j++; k++;
                }
            }
            while (i < vSt.Length)
            {
                vector[st + k] = vSt[i];
                i++; k++;
            }
            while (j < vDr.Length)
            {
                vector[st + k] = vDr[j];
                j++;  k++;
            }
        }
    }
}
