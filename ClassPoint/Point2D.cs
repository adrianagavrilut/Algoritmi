using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPoint
{
    public class Point2D
    {
        #region Properties
        public double X { get; set; }
        public double Y { get; set; }
        #endregion

        #region Constructors
        public Point2D() : this(0, 0)
        { }

        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
            Console.WriteLine($"Am creat un obiect de tip Point ({X}, {Y})");
        }

        public Point2D(int x) : this(x, 0)
        { }
        #endregion

        #region Overrides
        public override string ToString()
        {
            return $"[({X}, {Y})]";
        }
        #endregion

        #region Methods
        public double GetDistanceToOrigin()
        {
            return Math.Sqrt(X * X + Y * Y);
        }

        public double GetDistanceTo(Point2D to)
        {
            return Math.Sqrt(Math.Pow(this.X - to.X, 2) +
                            Math.Pow(this.Y - to.Y, 2));
        }

        public void MoveBy(double dx, double dy)
        {
            X += dx;
            Y += dy;
        }

        public void RotateBy(double angle)
        {
            // TODO: formule pentru rotirea in jurul originii. 

        }
        #endregion
    }
}
