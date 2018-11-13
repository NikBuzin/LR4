using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using L4.CastomMath;
using L4.Third;


namespace L4.Models
{
    public class Abs : IModel
    {
        public Abs() {}
        public List<PolyLine3D> GetLines()
        {
            List<PolyLine3D> answer = new List<PolyLine3D>();
            for (double x = -10; x < 10; x += 0.01)
            {
                answer.Add(new PolyLine3D(new List<Vector3>()
                    {
                    new Vector3((float)x, -(float)Math.Abs(Math.Pow(x,4)-Math.Pow(x,3)+Math.Pow(x,2)-x), 0),
                    new Vector3((float)x+0.01f, -(float)Math.Abs(Math.Pow(x+0.01,4)-Math.Pow(x+0.01,3)+Math.Pow(x+0.01,2)-x+0.01), 0)
                }, true));
            }

            return answer;
        }
    }
}
