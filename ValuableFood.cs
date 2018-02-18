﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Projekt
{
    class ValuableFood : Food
    {
        public static int AmountOfValuableFood;

        public ValuableFood(Point position, PlayField playField) : base(position, playField, Brushes.DarkGray)
        {
            AmountOfValuableFood++;
            points = 5;
            growth = 2;
        }

        public override void CollisionEffect(SnakeBody sb)
        {
            base.CollisionEffect(sb);
            AmountOfValuableFood--;
        }
    }
}
