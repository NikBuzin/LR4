using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4.Models
{
    public class Function
    {
        public static float Calculate(double x, double y, string nameFunction)
        {
            float z = 0;
            switch (nameFunction)
            {
                case "z = e^sin(x*3) - cos (y^2)":
                    z = (float)(Math.Pow(Math.E, Math.Pow(Math.Sin(x), 3)) - Math.Cos(y * y));
                    break;
                case "z = x^3 - y^2":
                    z = (float)(Math.Pow(x, 3) - Math.Pow(y, 2));
                    break;
                case "z = x^(1/3) * sin(y)":
                    z = (float)(Math.Pow(x, 1.0 / 3) * Math.Sin(y));
                    break;
                case "z = ln(x^2 + 1) / (y^2 + 2)":
                    z = (float)(Math.Log(x * x + 1) / (y * y + 2));
                    break;
                case "z = (1 / (x^3 + 2)) + ln (y)":
                    z = (float)(1.0/(Math.Pow(x, 3)+2)+Math.Log(y));
                    break;
                case "z = abs(y^4 - y^3 + x^2 - x)":
                    z = (float)(Math.Abs(Math.Pow(y, 4) - Math.Pow(y, 3) + Math.Pow(x, 2) - x));
                    break;
                case "z = x^4+y^4*(x^2+y^2)":
                    z = (float)(Math.Pow(x, 4) + Math.Pow(y, 4) * (x * x + y * y));
                    break;
                case "z = e^((sin(x) + cos(x)) / (x^2 + 1))":
                    z = (float)(Math.Pow(Math.E, ((Math.Sin(x) + Math.Cos(x)) / (x * x + 1))));
                    break;
                default:
                    break;
            }
            return z;
        }
    }
}
