using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using L4.CastomMath;

namespace L4.Third
{
    public class PolyLine3D
    {
        public class Compare //: IComparer<PolyLine3D>
        {
            /*public int Compare(PolyLine3D x, PolyLine3D y)
            {
                float a = 0, b = 0;
                foreach (Vector3 v in x.Vertices)
                    a += v.Z;
                foreach (Vector3 v in y.Vertices)
                    b += v.Z;
                a = a/x.Vertices
            }*/
        }
        private List<Vector3> vertices;
        public PolyLine3D(IList<Vector3> v, bool closed = false)
        {
            vertices = new List<Vector3>(v);
            if (closed)
                vertices.Add(v[0]);
        }
        public List<Vector3> Vertices { get { return vertices; } }//PolyLine3D всего лишь набор точек
    }
}
