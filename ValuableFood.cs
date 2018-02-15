using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Projekt
{
    class ValuableFood : Food
    {
        public ValuableFood(Point position, PlayField playField) : base(position, playField, Pens.DarkGray)
        {
        }
    }
}
