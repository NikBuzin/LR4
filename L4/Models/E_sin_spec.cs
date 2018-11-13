using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using L4.CastomMath;
using L4.Third;

namespace L4.Models
{
    public class E_sin_spec : IModel
    {
        public E_sin_spec() {}
        public List<PolyLine3D> GetLines()
        {
            List<PolyLine3D> answer = new List<PolyLine3D>();
            for (double x = -10; x < 10; x += 0.1)
            {
                answer.Add(new PolyLine3D(new List<Vector3>()
                    {
                    new Vector3((float)x, -(float)Math.Pow(Math.E,(Math.Sin(x)+Math.Cos(x))/(Math.Pow(x,2)+1)), 0),
                    new Vector3((float)x+0.1f, -(float)Math.Pow(Math.E,(Math.Sin(x+0.1)+Math.Cos(x+0.1))/(Math.Pow(x+0.1,2)+1)), 0)
                }, true));
            }

            return answer;
        }
    }
}
