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
        public class Compare 
        {
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
