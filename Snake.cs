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
        enum Direction { up,down,left, right};
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
            score = 0;
            size = 2;
        }
        private void Move (Direction direction)
        {

        }
        private void isValidMove (Direction direction)
        {

        }
        private void expand ()
        {

        }
        private void getHead ()
        {

        }
        private void CollisionEffect()
        {

        }
        public void draw()
        {

        }

        
    }
}
