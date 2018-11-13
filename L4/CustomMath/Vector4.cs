using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4.CastomMath
{
    public struct Vector4
    {
        private float[] coordinates;
        public Vector4(float x, float y, float z, float w = 1)
        {
            coordinates = new float[4];
            coordinates[0] = x;
            coordinates[1] = y;
            coordinates[2] = z;
            coordinates[3] = w;

        }

        public Vector4(Vector3 v): this (v.X, v.Y, v.Z)
        {

        }

        public float X { get { return coordinates[0]/10; } set { coordinates[0] = value; } }
        public float Y { get { return coordinates[1]/10; } set { coordinates[1] = value; } }
        public float Z { get { return coordinates[2]/10; } set { coordinates[2] = value; } }
        public float W { get { return coordinates[3]/10; } set { coordinates[3] = value; } }

        public float this[int i] { get { return coordinates[i]; } set { coordinates[i] = value; } }

        public Vector4 Normolized
        {
            get
            {
                return (W == 0) ? new Vector4(X, Y, Z, W) : new Vector4(X / W, Y / W, Z / W, 1);
            }
        }
    }
}
