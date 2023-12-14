using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPoint
{
    public class Point3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point3D() : this(0, 0, 0)
        { }

        public Point3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
            Console.WriteLine($"Am creat un obiect de tip Point ({X}, {Y}, {Z})");
        }

        public Point3D(int x) : this(x, 0, 0)
        { }
    }
}
