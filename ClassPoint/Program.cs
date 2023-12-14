using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Point2D p1 = new Point2D { X = 3.0, Y = 4.0 };
            Point2D p2 = new Point2D();
            Point2D p3 = new Point2D(3, 4);

            Console.WriteLine(p1);

            Point2D p4 = new Point2D(5);

            Point2D p5 = new Point2D(5.0, 6.0);

            Console.WriteLine(p5);

            Console.WriteLine($"Distanta de la origine la punctul {p1} este {p1.GetDistanceToOrigin()}");
            Console.WriteLine($"Distanta de la punctul {p4} la punctul {p5} este {p4.GetDistanceTo(p5)}");

            Point2D p6 = new Point2D(1, 1);
            p6.MoveBy(2, 2);
            Console.WriteLine(p6);
        }
    }
}
