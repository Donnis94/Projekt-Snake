using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_Projekt
{
    abstract class Controller
    {

        public Snake.Direction direction;

        public Controller()
        {
            MainForm.keyPushed += ValidMove;
        }

        public abstract void ValidMove(Keys key);

    }

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
