using System;

namespace Queue
{
    internal class Coada
    {
        int[] valori;

        public Coada()
        {
            valori = new int[0];
        }

        internal void Push(int v)
        {
            int[] tmp = new int[valori.Length + 1];
            for (int i = 0; i < valori.Length; i++)
                tmp[i + 1] = valori[i];
            tmp[0] = v;
            valori = tmp;
        }

        internal int Pop()
        {
            int valPop = valori[valori.Length - 1];
            int[] tmp = new int[valori.Length - 1];
            for (int i = 0; i < valori.Length - 1; i++)
                tmp[i] = valori[i];
            valori = tmp;
            return valPop;
        }

        internal void View()
        {
            Algoritmi.Array.Afisare(valori);
        }
    }
}