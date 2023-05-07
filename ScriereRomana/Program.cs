using System;

namespace ScriereRomana
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "MMCMXLVII";
            Console.WriteLine(s);
            int value = 0;
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (Roman(s[i]) >= Roman(s[i + 1]))
                    value += Roman(s[i]);
                else
                    value -= Roman(s[i]);
            }
            value += Roman(s[s.Length - 1]);
            Console.WriteLine(value);
        }

        static int Roman(char r)
        {
            switch (r)
            {
                case 'M':
                    return 1000;
                case 'D':
                    return 500;
                case 'C':
                    return 100;
                case 'L':
                    return 50;
                case 'X':
                    return 10;
                case 'V':
                    return 5;
                case 'I':
                    return 1;
                default:
                    break;
            }
            return -1;
        }
    }
}