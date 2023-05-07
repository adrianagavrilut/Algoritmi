using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumereComplexe
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex a = new Complex(2, 3);
            Console.WriteLine(a.View());

            Complex b = new Complex(1, -5);
            Console.WriteLine(b.View());

            Complex c = new Complex(4, -3);
            c.Conjugat();
            Console.WriteLine(c.View());

            Complex calcul = new Complex();
            calcul = (((a * b) - c) / c) + a;
            Console.WriteLine(calcul.View());
            Console.WriteLine(calcul.Modul().ToString());
        }
    }
}
