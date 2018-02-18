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
        public static int AmountOfStandardFood;

        public StandardFood(Point position, PlayField playField) : base(position, playField, Brushes.DarkBlue)
        {
            AmountOfStandardFood++;
            points = 1;
            growth = 1;
        }

        public override void CollisionEffect(SnakeBody sb)
        {
            base.CollisionEffect(sb);
            AmountOfStandardFood--;
        }

    }
}
