using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double X , double Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public double Distance (Point P2)
        {
            double xDiff = X - P2.X;
            double yDiff = Y - P2.Y;
            return Math.Sqrt(xDiff * xDiff + yDiff * yDiff);
        }
    }
}
