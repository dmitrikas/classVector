using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace classVector
{
    class Vector3d
    {
        public double x { get; set; }
        public double y { get; set; }
        public double z { get; set; }

        public Vector3d(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static Vector3d operator +(Vector3d v1, Vector3d v2)
        {
            return new Vector3d(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
        }

        public static Vector3d operator +(double k, Vector3d v)
        {
            return new Vector3d(v.x + k, v.y + k, v.z + k);
        }

        public static Vector3d operator -(Vector3d v1, Vector3d v2)
        {
            return new Vector3d(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z);
        }

        public static double operator *(Vector3d v1, Vector3d v2)
        {
            return v1.x * v2.x + v1.y * v2.y + v1.z * v2.z;
        }        

        public static Vector3d operator *(double k, Vector3d v)
        {
            return new Vector3d(v.x * k, v.y * k, v.z * k);
        }

        public static Vector3d operator /(Vector3d v, double k)
        {
            return new Vector3d(v.x / k, v.y / k, v.z / k);
        }

        public static Vector3d operator ^(Vector3d v1, Vector3d v2)
        {
            return new Vector3d(v1.y * v2.z - v1.z * v2.y, v1.z * v2.x - v1.x * v2.z, v1.x * v2.y - v1.y * v2.x);
        }

        public double Length()
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }

        public void normalize()
        {
            double locLength = Length();
            double inv_length = (1 / locLength);

            x *= inv_length;
            y *= inv_length;
            z *= inv_length;
        }

        public override string ToString()
        {
            return string.Format("X={0}, Y={1}, Z={2}", x, y, z);
        }

        

    }
}
