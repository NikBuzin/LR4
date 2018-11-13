using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using L4.CastomMath;

namespace L4.Third
{
    public class Screen
    {
        public Size Size { get; set; }
        public RectangleF Rectangle { get; set; }

        public Screen (Size sz, RectangleF r)
        {
            Size = sz;
            Rectangle = r;
        }

        public Point Convert (Vector3 v)
        {
            float x = (v.X - Rectangle.X) / Rectangle.Width * Size.Width;
            float y = (-Rectangle.Y + v.Y) / Rectangle.Height * Size.Height;
            return new Point((int)x, (int)y);
        }

        public static Matrix4 Translate(int dx, int dy, int dz)//матрциа переноса
        {
            Matrix4 m = Matrix4.One();
            m[0, 3] = dx;
            m[1, 3] = dy;
            m[2, 3] = dz;
            return m;
        }
        public static Matrix4 Rotate(int xyz, float a)
        {
            Matrix4 m = Matrix4.One();
            int r1 = (xyz + 1) % 3;
            int r2 = (xyz + 2) % 3;
            m[r1, r1] = (float)Math.Cos(a);
            m[r1, r2] = (float)-Math.Sin(a);
            m[r2, r1] = (float)Math.Cos(a);
            m[r2, r2] = (float)Math.Sin(a);
            return m;
        }
    }
}
