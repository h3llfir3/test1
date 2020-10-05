
using System.Net.NetworkInformation;

namespace Vectores011020
{
    class Geometry
    {
        public static double GetVector2DLength(double x, double y)
        {
            double aux = x * x + y * y;
            return System.Math.Sqrt(aux);
        }

        public static double GetDistance2D(double x1, double y1, double x2, double y2)
        {
            double vx = x2 - x1;
            double vy = y2 - y1;
            return GetVector2DLength(vx, vy);
        }
        public static double GetVector3DLength(double x, double y, double z)
        {
            double aux = x * x + y * y + z * z;
            return System.Math.Sqrt(aux);
        }

        public static double GetCircleArea(double r)
        {
            double aux = System.Math.PI * (r * r);
            return aux;
        }

        public static bool AreOverlapping(double x1, double y1, double x2, double y2, double r1, double r2)
        {
            double aux = r1 + r2;

        }
    }
}
