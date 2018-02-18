﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Snake_Projekt
{
    abstract class Food : IDrawable, ICollideble
    {
        Brush brush;
        protected int points;
        protected int growth;
        public Point position { get; set; }
        PlayField playField;

        public Food(Point position, PlayField playField, Brush brush)
        {
            this.position = position;
            this.playField = playField;
            this.brush = brush;
        }

        public void Draw(Renderer renderer)
        {
            renderer.DrawAt(position.X, position.Y, brush);
        }

        public virtual void CollisionEffect(SnakeBody sb)
        {
            sb.mySnake.addScore(points);
            sb.mySnake.expand(growth);

            playField.RemoveItem(this);
        }
        
    }
    
}
