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
        public Snake mySnake { get; }
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
            if (sb.mySnake != this.mySnake)
            {
                this.mySnake.addScore(5);
            }
            sb.mySnake.isAlive = false;
        }

        public void MoveTo(SnakeBody sb)
        {
            this.position = sb.position;
        }

        public void MoveInDirection(Snake.Direction direction)
        {
            switch (direction)
            {
                case Snake.Direction.left:
                    position = new Point(position.X - 1, position.Y);
                    break;
                case Snake.Direction.right:
                    position = new Point(position.X + 1, position.Y);
                    break;
                case Snake.Direction.up:
                    position = new Point(position.X, position.Y - 1);
                    break;
                case Snake.Direction.down:
                    position = new Point(position.X, position.Y + 1);
                    break;
            }
        }
    }
}
