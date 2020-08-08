using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilteredDisplayTrial.Classes
{
    class Init
    {
        private Rectangle ScBo = Screen.GetBounds(Point.Empty);
        Bitmap bmp;
        public void toScreenBounds(Form form,PictureBox PBox)
        {
            form.SetDesktopBounds(ScBo.X,ScBo.Y,ScBo.Width,ScBo.Height);
            PBox.SetBounds(ScBo.X, ScBo.Y, ScBo.Width, ScBo.Height);
            bmp = new Bitmap(form.Width, form.Height);
        }
        public void updateDisplayImage(Form form, PictureBox PBox)
        {
            Graphics gfx = Graphics.FromImage(bmp);
            gfx.CopyFromScreen(Point.Empty, Point.Empty, form.Size);
            gfx.Dispose();
            PBox.Image = bmp;
        }
    }
}
