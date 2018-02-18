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




        public Food ProduceFood(int amountOfFood, int XSize, int YSize, PlayField playField)
        {
            if (amountOfFood < 10)
            {
                if (Random.Next(10) == 0)
                {
                    //Food producedFood = new StandardFood((new Point(Random.Next(XSize),Random.Next(YSize)),playField));
                    //return producedFood;
                }

                /*
                switch (foodToMake)
                {
                    case FoodType.SpeedyFood:
                        Food producedFood = new SpeedyFood();
                        return producedFood;
                    case FoodType.StandardFood:
                        Food producedFood = new StandardFood();
                        return producedFood;
                    case FoodType.ValuableFood:
                        Food producedFood = new ValuableFood();
                        return producedFood;
                }
                */
            }
                return null;
           
            
        }
    }
}
