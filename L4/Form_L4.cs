using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using L4.Third;
using L4.CastomMath;

namespace L4
{
    public partial class Form_L4 : Form
    {
        float X, Y, W, H;
        Scene scene;
        Camera camera;
        public Form_L4()
        {
            InitializeComponent();
            X = -1f;
            Y = -1f;
            W = 2f;
            H = 2f;
            scene = new Scene();
            camera = new Camera();
            MouseWheel += new MouseEventHandler(Form1_MouseWheel);
        }

        private void Form_L4_Paint(object sender, PaintEventArgs e)
        {
            var screen = new Third.Screen(Size, new RectangleF(X, Y, W, H));
            Bitmap bmp = scene.DrawAll(screen, camera);
            e.Graphics.DrawImage(bmp, 0, 0);
            bmp.Dispose();
        }

        private void Form_L4_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }

        Point last = new Point();
        private void Form_L4_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button.HasFlag(MouseButtons.Left))
                last = e.Location;
        }

        private void Form_L4_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button.HasFlag(MouseButtons.Left) && !last.IsEmpty)
            {

                int dx = e.X - last.X;
                int dy = e.Y - last.Y;
                last = e.Location;
                camera.View = CastomMath.Matrix4.Rotate(2, dx * (float)Math.PI / 180) *
                              CastomMath.Matrix4.Rotate(0, dy * (float)Math.PI / 180) * camera.View;
                Invalidate();
            }
            
        }

        private void Form_L4_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button.HasFlag(MouseButtons.Left))
                last = new Point();
        }

        private void Form_L4_Load(object sender, EventArgs e)
        {

        }

        private void RB_1_CheckedChanged(object sender, EventArgs e)
        {
            if(RB_1.Checked)
            {
                scene.models.Add(new Models.DrawModels("z = e^sin(x*3) - cos (y^2)"));
            }
            else scene.models.RemoveRange(0, scene.models.Count);
            Invalidate();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {            
            if (radioButton2.Checked)
            {
                scene.models.Add(new Models.DrawModels("z = x^3 - y^2"));
            }
            else scene.models.RemoveRange(0, scene.models.Count);
            Invalidate();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {         
            if (radioButton3.Checked)
            {
                scene.models.Add(new Models.DrawModels("z = x^(1/3) * sin(y)"));
            }
            else scene.models.RemoveRange(0, scene.models.Count);
            Invalidate();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {           
            if (radioButton4.Checked)
            {
                scene.models.Add(new Models.DrawModels("z = ln(x^2 + 1) / (y^2 + 2)"));
            }
            else scene.models.RemoveRange(0, scene.models.Count);
            Invalidate();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {           
            if (radioButton5.Checked)
            {
                scene.models.Add(new Models.DrawModels("z = (1 / (x^3 + 2)) + ln (y)"));
            }
            else scene.models.RemoveRange(0, scene.models.Count);
            Invalidate();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {           
            if (radioButton6.Checked)
            {
                scene.models.Add(new Models.DrawModels("z = abs(y^4 - y^3 + x^2 - x)"));
            }
            else scene.models.RemoveRange(0, scene.models.Count);
            Invalidate();
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked)
            {
                scene.models.Add(new Models.DrawModels("z = x^4+y^4*(x^2+y^2)"));
            }
            else scene.models.RemoveRange(0, scene.models.Count);
            Invalidate();
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked)
            {
                scene.models.Add(new Models.DrawModels("z = e^((sin(x) + cos(x)) / (x^2 + 1))"));
            }
            else scene.models.RemoveRange(0, scene.models.Count);
            Invalidate();
        }
        void Form1_MouseWheel(object sender, MouseEventArgs e)
        {
            double k;
            if (e.Delta < 0)
                k = 1.23;
            else
                k = 0.77;
            W *= (float)k;
            X *= (float)k;
            Y *= (float)k;
            H *= (float)k;
            Invalidate();
        }
    }
}
