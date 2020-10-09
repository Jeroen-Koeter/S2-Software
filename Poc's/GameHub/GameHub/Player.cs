using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace GameHub
{
    class Player: GameObject
    {
        public Player(int speed, string tag) : base(speed, tag)
        {
        }

        public override PictureBox BuildFullPictureBox(int x, int y, int row)
        {
            PictureBox player_unit = BuildPictureBox();
            player_unit.Image = Properties.Resources.tank;
            player_unit.Location = new Point(x, y);
            player_unit.Name = "player";
            return player_unit;
        }
    }
}
