﻿using System;
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
        bool isAlive = true;
        Point point;
        private int size;
        public enum Direction { up, down, left, right };
        private Direction currentDirection;
        private int speed = 10;
        
        Color color
        {
            set;
            get;
        }

        public Snake(int x, int y, int size, Controller controller, Color color) : this(new Point(x, y), size, controller, color) { }
        public Snake(Point point, int size, Controller controller, Color color)
        {
            this.point = point;
            this.size = size;
            this.controller = controller;
            this.color = color;
            this.score = 0;
            this.isAlive = true;
            body.Add(new SnakeBody(point, this));
            for (int i = 0; i < size; i++)
                expand();

        }

        public void ControllerInput(Keys key)
        {
            controller.ValidMove(key);
        }

        public void Move()
        {
            for (int i = body.Count - 1; i > 0; i--)
                body[i].position = body[i - 1].position;


            MoveSnakeHead();
        }

        private void MoveSnakeHead()
        {
            if (!isValidMove())
            {
                controller.direction = currentDirection;
            }
            switch (controller.direction)
            {
                case Snake.Direction.left:
                    body[0].position = new Point(body[0].position.X - 1, body[0].position.Y);
                    break;
                case Snake.Direction.right:
                    body[0].position = new Point(body[0].position.X + 1, body[0].position.Y);
                    break;
                case Snake.Direction.up:
                    body[0].position = new Point(body[0].position.X, body[0].position.Y - 1);
                    break;
                case Snake.Direction.down:
                    body[0].position = new Point(body[0].position.X, body[0].position.Y + 1);
                    break;
            }

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

        public void expand()
        {
            body.Add(new SnakeBody(body[body.Count - 1].position, this));//need to set the actual position of the last bodypart
        }

        public List<SnakeBody> getHead()
        {
            return this.body;
        }

        public void CollisionEffect()
        {
            /*
            if ()//collides with standard food 
            {
                expand();
                this.score = score + 1;
            }
            else if ()//collides with special food
            {
                expand();
                expand();
                this.score = score + 2;
            }
            else if ()//collide with speedy food
            {
                this.speed = speed * 2;
                //set timer for speed at 10 seconds
            }
            */
        }

        public void Draw(Renderer renderer)
        {
            for (int i = 0; i < body.Count; i++)
            {
                body[i].Draw(renderer);
            }
        }

    }
}
