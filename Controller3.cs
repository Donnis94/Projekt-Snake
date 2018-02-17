using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_Projekt
{
    class Controller3 : Controller
    {
        public override void ValidMove(Keys key)
        {
            switch (key)
            {
                case Keys.J:
                    direction = Snake.Direction.left;
                    break;
                case Keys.L:
                    direction = Snake.Direction.right;
                    break;
                case Keys.I:
                    direction = Snake.Direction.up;
                    break;
                case Keys.K:
                    direction = Snake.Direction.down;
                    break;
            }
        }
    }
}
