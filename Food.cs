using System;
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
