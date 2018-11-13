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
        Scene scene;
        Camera camera;
        public Form_L4()
        {
            InitializeComponent();
            scene = new Scene();
            camera = new Camera();
            //scene.models.Add(new Models.E_sin());
            //scene.models.Add(new Models.x_3_x_2());
            //scene.models.Add(new Models.x___sin_x_());
            //scene.models.Add(new Models.Ln());
            //scene.models.Add(new Models._1andX());
            //scene.models.Add(new Models.Abs());
            //scene.models.Add(new Models.X_4());
            scene.models.Add(new Models.E_sin_spec());
        }

        private void Form_L4_Paint(object sender, PaintEventArgs e)
        {
            var screen = new Third.Screen(Size, new RectangleF(-1, -1, 2, 2));
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
    }
}
