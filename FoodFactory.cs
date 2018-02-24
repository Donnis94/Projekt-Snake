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

        public enum FoodType { StandardFood, ValuableFood, SpeedyFood}

        public Food ProduceFood(int XSize, int YSize, PlayField playField, FoodType food, Collider collider)
        {
            int XCoor = Random.Next(XSize);
            int YCoor = Random.Next(YSize);
            bool TileAvailable = collider.IsTileEmpty(XCoor, YCoor);
            int EmptyTileChecks = 0;

            while (!TileAvailable)
            {
                XCoor = Random.Next(XSize);
                YCoor = Random.Next(YSize);
                TileAvailable = collider.IsTileEmpty(XCoor, YCoor);
                if (EmptyTileChecks++ == 1000)
                    break;
            }
            
                if (food == FoodType.SpeedyFood)
                {
                    Food producedFood = new SpeedyFood(new Point(XCoor, YCoor),playField);
                    return producedFood;
                }
                else if (food == FoodType.ValuableFood)
                {
                    Food producedFood = new ValuableFood(new Point(XCoor, YCoor),playField);
                    return producedFood;
                }
                else
                {
                    Food producedFood = new StandardFood(new Point(XCoor, YCoor), playField);
                    return producedFood;
                }
                
        }
           
            
        }
}

