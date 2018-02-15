using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Snake_Projekt
{
    class SnakeBody : IDrawable
    {
        Pen pen = new Pen(Color.Black);

        Snake mySnake;

        public SnakeBody(Snake _mySnake)
        {
            mySnake = _mySnake;
        }

        public void Draw(Renderer renderer)
        {
            
        }
    }
}
