using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Projekt
{
    class SpeedyFood : Food
    {
        public static int AmountOfSpeedyFood;

        public SpeedyFood(Point position, PlayField playField) : base(position, playField, Brushes.Brown)
        {
            AmountOfSpeedyFood++;
            points = 0;
            growth = 0;
        }

        public override void CollisionEffect(SnakeBody sb)
        {
            base.CollisionEffect(sb);
            AmountOfSpeedyFood--;
        }
    }
}
