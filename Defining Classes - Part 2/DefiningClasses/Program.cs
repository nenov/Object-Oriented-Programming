using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public struct Point3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        private static readonly Point3D start = new Point3D(0, 0, 0);

        public Point3D(double p1, double p2, double p3) : this()
        {
            // TODO: Complete member initialization
            this.X = p1;
            this.Y = p2;
            this.Z = p3;
        }

        public static Point3D PrintZero() 
        {
            return start;
        }

        public override string ToString() 
        {
            string result = String.Format("{{{0}, {1}, {2}}}", this.X, this.Y, this.Z);
            return result;
        }
    }
}
