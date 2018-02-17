using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_Projekt
{
    class Controller2 : Controller
    {
        public override void ValidMove(Keys key)
        {
            switch (key)
            {
                case Keys.A:
                    direction = Snake.Direction.left;
                    break;
                case Keys.D:
                    direction = Snake.Direction.right;
                    break;
                case Keys.W:
                    direction = Snake.Direction.up;
                    break;
                case Keys.S:
                    direction = Snake.Direction.down;
                    break;
            }
        }
    }
}
