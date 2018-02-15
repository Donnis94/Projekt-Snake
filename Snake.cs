﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

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
        public enum Direction { up,down,left, right};
        private int speed=10;
        Color color
        {
            set;
            get;
        }

        public Snake(int x, int y, int size, Controller controller, Color color) : this(new Point(x, y), size, controller, color) { }
        public Snake (Point point, int size, Controller controller,Color color)
        {
            this.point = point;
            this.size = size;
            this.controller = controller;
            this.color = color;
            this.score = 0;
            this.isAlive = true;
            body.Add(new SnakeBody(point,this));
            for(int i = 0; i < size; i++)
                expand();
                
        }

        public void Move ()
        {
             for(int i = body.Count-1; i > 0; i--)
                body[i].position = body[i-1].position;

             body[0].position = new Point(body[0].position.X + 1, body[0].position.Y);
        }
    
        public void isValidMove (Direction direction)
        {
            

        }

        public void expand ()
        {
            body.Add(new SnakeBody(body[body.Count-1].position, this));//need to set the actual position of the last bodypart
        }

        public List<SnakeBody> getHead ()
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
