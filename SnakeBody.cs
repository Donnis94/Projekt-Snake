using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Snake_Projekt
{
    class SnakeBody : IDrawable, ICollideble
    {
        Snake mySnake { get; }
        public Point position { get; set; }

        public SnakeBody(Point _position, Snake _mySnake)
        {
            mySnake = _mySnake;
            position = _position;
        }

        public void Draw(Renderer renderer, Brush b)
        {
            renderer.DrawAt(position.X, position.Y, b);
        }

        public void Draw(Renderer renderer)
        {
            renderer.DrawAt(position.X, position.Y, Brushes.Black);
        }

        public void CollisionEffect(SnakeBody sb)
        {
            throw new NotImplementedException();
        }
    }
}
