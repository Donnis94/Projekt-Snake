using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Snake_Projekt
{
    class FoodFactory
    {
        private Random Random = new Random();

        public enum FoodType
        {
            StandardFood,
            SpeedyFood,
            ValuableFood
        };




        public Food ProduceFood(int XSize, int YSize, PlayField playField)
        {
                if (Random.Next(10) == 0)
                {
                    Food producedFood = new SpeedyFood(new Point(Random.Next(XSize),Random.Next(YSize)),playField);
                    return producedFood;
                }
                else if (Random.Next(100) == 0)
                {
                    Food producedFood = new ValuableFood(new Point(Random.Next(XSize),Random.Next(YSize)),playField);
                    return producedFood;
                }
                else
                {
                    Food producedFood = new StandardFood(new Point(Random.Next(XSize), Random.Next(YSize)), playField);
                    return producedFood;
                }
                
        }
           
            
        }
}

