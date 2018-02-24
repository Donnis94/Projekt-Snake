using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Snake_Projekt
{
    class Snake
    {
        private List<SnakeBody> body = new List<SnakeBody>();
        private int score;

        private Controller controller;
        private Direction currentDirection;
        public bool isAlive { get; set; }
        private int speed = 10;

        public enum Direction { up, down, left, right };

        Brush brush { get; set; }

        public Snake(int x, int y, int size, Controller controller, Brush color) : this(new Point(x, y), size, controller, color) { }
        public Snake(Point point, int size, Controller controller, Brush color)
        {
            this.currentDirection = Direction.down;
            this.controller = controller;
            this.brush = color;
            this.score = 0;
            this.isAlive = true;
            body.Add(new SnakeBody(point, this));
            expand(size);

        }

        public void ControllerInput(Keys key)
        {
            controller.ValidMove(key);
        }

        public void Move()
        {
            if (!isAlive)
            {
                return;
            }

            for (int i = body.Count - 1; i > 0; i--)
                body[i].MoveTo(body[i - 1]);

            MoveSnakeHead();
        }

        private void MoveSnakeHead()
        {
            if (!isValidMove())
            {
                controller.direction = currentDirection;
            }

            body[0].MoveInDirection(controller.direction);

            currentDirection = controller.direction;
        }

        public bool isValidMove()
        {
            if (currentDirection == Direction.down && controller.direction == Direction.up)
            {
                return false;
            }

            if (currentDirection == Direction.up && controller.direction == Direction.down)
            {
                return false;
            }
            if (currentDirection == Direction.right && controller.direction == Direction.left)
            {
                return false;
            }

            if (currentDirection == Direction.left && controller.direction == Direction.right)
            {
                return false;
            }

            return true;
        }

        public void expand(int count)
        {
            for (int i = 0; i < count; i++)
                body.Add(new SnakeBody(body[body.Count - 1].position, this));
        }

        public void addScore(int extra)
        {
            this.score += extra;
        }

        public SnakeBody getHead()
        {
            return this.body[0];
        }

        public void addBodyToCollider(Collider c)
        {
            for (int i = 1; i < body.Count; i++)
            {
                c.EnterCollidableObject(body[i]);
            }
        }

        public int GetScore()
        {
            return this.score;
        }

        public void Draw(Renderer renderer)
        {
            if (!isAlive)
            {
                return;
            }
            for (int i = 0; i < body.Count; i++)
            {
                body[i].Draw(renderer, brush);
            }
        }
    }
}
