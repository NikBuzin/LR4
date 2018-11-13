using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using L4.CastomMath;
using L4.Third;

namespace L4.Models
{
    public class x_3_x_2 : IModel
    {
        public x_3_x_2()
        {
     
        }
        public List<PolyLine3D> GetLines()
        {
            List<PolyLine3D> answer = new List<PolyLine3D>();
            for (double x = -10; x < 10; x += 0.1)
            {
                answer.Add(new PolyLine3D(new List<Vector3>()
                {
                new Vector3((float)x, -(float)(Math.Pow(x,3)-Math.Pow(x,2)), 0),
                new Vector3((float)x+0.1f, -(float)(Math.Pow(x+0.1f,3)-Math.Pow(x+0.1f,2)), 0)
            }, true));
            }
            return answer;
        }
    }
}
