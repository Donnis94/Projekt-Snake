using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Snake_Projekt
{
    class Food : IDrawable
    {
        Pen pen;
        int points;
        Point position;

        public Food(Point position, PlayField playField)
        {
        }

        public void Draw(Renderer renderer)
        {
            throw new NotImplementedException();
        }
    }
}
