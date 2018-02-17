﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Snake_Projekt
{
    abstract class Food : IDrawable
    {
        Brush brush;
        int points;
        Point position;
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
    }
    
}
