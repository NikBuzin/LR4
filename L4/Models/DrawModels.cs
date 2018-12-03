using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using L4.CastomMath;
using L4.Third;

namespace L4.Models
{
    public class DrawModels : IModel
    {
        public string nameFunction { get; set; }
        public DrawModels(string nameFunction)
        {
            this.nameFunction = nameFunction;
        }
        public List<PolyLine3D> GetLines()
        {
            List<PolyLine3D> answer = new List<PolyLine3D>();
            
            for (float x = -5; x <= 5; x += 0.3f)
            {
                for (float y = -5; y <= 5; y += 0.3f)
                {
                    Vector3 vector1 = new Vector3(x, y, Function.Calculate(x, y, nameFunction));
                    Vector3 vector2 = new Vector3(x + 0.3f, y, Function.Calculate(x + 0.3f, y, nameFunction));
                    Vector3 vector3 = new Vector3(x, y + 0.3f, Function.Calculate(x, y + 0.3f, nameFunction));
                    Vector3 vector4 = new Vector3(x + 0.3f, y + 0.3f, Function.Calculate(x + 0.3f, y + 0.3f, nameFunction));
                    PolyLine3D polyLine3D = new PolyLine3D(new List<Vector3>() { vector1, vector2, vector4 });
                    answer.Add(polyLine3D);
                }
            }

            return answer;
        }
    }
}
