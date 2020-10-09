using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace GameHub
{
    class Alien : GameObject
    {

        public Alien(int speed, string tag) : base(speed, tag)
        {
        }

        public override PictureBox BuildFullPictureBox(int x, int y, int row)
        {
            PictureBox alien_unit = BuildPictureBox();
            alien_unit.Image = ImageSelect(row);
            alien_unit.Location = new Point(x, y);
            alien_unit.Tag = "invaderLeft";
            return alien_unit;
        }
        public Image ImageSelect(int alien_picture)
        {
            Image image;
            switch (alien_picture)
            {
                case 0:
                    image = Properties.Resources.alien_1;
                    break;
                case 1:
                    image = Properties.Resources.alien_2;
                    break;
                case 2:
                    image = Properties.Resources.alien_3;
                    break;
                case 3:
                    image = Properties.Resources.alien_4;
                    break;
                default:
                    image = Properties.Resources.error;
                    break;

            }
            return image;
        }
    }
}
