using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public static class StatisClass
    {
        public static double Distance(Point3D x, Point3D y)
        {
            double xd = y.X - x.X;
            double yd = y.Y - x.Y;
            double zd = y.Z - x.Z;
            return Math.Sqrt(xd * xd + yd * yd + zd * zd);
        }
    }
}
