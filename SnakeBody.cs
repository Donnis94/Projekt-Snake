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
        Point position;

        public SnakeBody(Point _position , Snake _mySnake)
        {
            mySnake = _mySnake;
            position = _position;
        }

        public void Draw(Renderer renderer)
        {
            renderer.DrawAt(position.X, position.Y, pen);
        }

    }
}
