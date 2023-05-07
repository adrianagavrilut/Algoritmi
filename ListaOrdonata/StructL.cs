using System;
namespace ListaOrdonata
{
    class StructL
    {
        int[] valori;
        int capacitate = 100;
        int index;

        public StructL()
        {
            valori = new int[capacitate];
            index = 0;
        }

        public void Push(int v)
        {
            if (index == 0)
            {
                AdaugareInceput(v);
                index++;
            }
            else
            {
                if (v < valori[0])
                {
                    AdaugareInceput(v);
                    index++;
                }
                else if (v > valori[index - 1])
                {
                    AdaugareSfarsit(v);
                    index++;
                }
                else
                {
                    AdaugareMijloc(v);
                    index++;
                }
            }
        }

        private void AdaugareMijloc(int v)
        {
            int[] t = new int[index + 1];
            int i = 0;
            while (v > valori[i])
            {
                t[i] = valori[i];
                i++;
            }
            t[i] = v;
            for (int j = i; j < index; j++)
                t[j + 1] = valori[j];
            valori = t;
        }

        public void AdaugareInceput(int v)
        {
            int[] t = new int[index + 1];
            for (int i = 0; i < index; i++)
                t[i + 1] = valori[i];
            t[0] = v;
            valori = t;
        }

        public void AdaugareSfarsit(int v)
        {
            int[] t = new int[index + 1];
            for (int i = 0; i < index; i++)
                t[i] = valori[i];
            t[index] = v;
            valori = t;
        }

        public void Afisare()
        {
            for (int i = 0; i < index; i++)
                Console.Write(valori[i] + " ");
        }
    }
}