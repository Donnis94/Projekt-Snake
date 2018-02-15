using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Snake_Projekt
{
    abstract class Food : IDrawable
    {
        Pen pen;
        int points;
        Point position;
        PlayField playField;

        public Food(Point position, PlayField playField, Pen color)
        {
            this.position = position;
            this.playField = playField;
            this.pen = color;
        }

        public void Draw(Renderer renderer)
        {
            renderer.DrawAt(position.X, position.Y, pen);
        }
    }
    
}
