using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Projekt
{
    class StandardFood : Food
    {
        public StandardFood(Point position, PlayField playField) : base(position, playField, Brushes.DarkBlue)
        {
        }
    }
}
