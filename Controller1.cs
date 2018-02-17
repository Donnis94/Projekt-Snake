using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_Projekt
{
    class Controller1 : Controller
    {
        public override void ValidMove(Keys key)
        {
            switch (key)
            {
                case Keys.Left:
                    direction = Snake.Direction.left;
                    break;
                case Keys.Right:
                    direction = Snake.Direction.right;
                    break;
                case Keys.Up:
                    direction = Snake.Direction.up;
                    break;
                case Keys.Down:
                    direction = Snake.Direction.down;
                    break;
            }
        }
    }
}
