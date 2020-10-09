using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameHub
{
    abstract class GameObject
    {
        protected string Tag { get; set; }
        protected int Speed { get; set; }
        protected int size = 50;
        public GameObject(int speed, string tag)
        {
            Tag = tag;
            Speed = speed;
        }
        protected PictureBox BuildPictureBox()
        {
            PictureBox basic  = new PictureBox();
            basic.MaximumSize = new Size(size, size);
            basic.SizeMode = PictureBoxSizeMode.StretchImage;
            return basic;
        }
        abstract public PictureBox BuildFullPictureBox(int x, int y, int row);
    }
}
