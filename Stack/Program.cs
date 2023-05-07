using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stiva stiva = new Stiva();
            stiva.Push(1);
            stiva.Push(2);
            stiva.Push(3);
            stiva.View();
            stiva.Pop();
            stiva.View();
        }
    }
}
