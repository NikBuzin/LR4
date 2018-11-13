using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using L4.CastomMath;

namespace L4.Third
{
    public class Camera //система координат, через которую мы смотрим
    {
        public Matrix4 View { get; set; }
        public Matrix4 Projcection { get; set; }
        public Camera()
        {
            View = Matrix4.One();
            Projcection = Matrix4.One();
        }
        public Vector3 Convert(Vector3 v)
        {
            return new Vector3((Projcection * View * new Vector4(v)).Normolized);
        }
    }
}
