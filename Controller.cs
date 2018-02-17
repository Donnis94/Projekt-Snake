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

        public abstract void ValidMove(Keys key);

    }
}
