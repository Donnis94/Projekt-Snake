using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Snake_Projekt
{
    class PlayField
    {
        ISet<Snake> Players = new HashSet<Snake>();
        ISet<Food> Food = new HashSet<Food>();
        Collider colliderMatrix;

        private FoodFactory foodFactory = new FoodFactory();

        private int TilesX;
        private int TilesY;

        public PlayField(int AmountOfPlayers, int tilesX, int tilesY)
        {
            //Food.Add(foodFactory.ProduceFood(0, tilesX, tilesY, this));
            Players.Add(new Snake(1, 1, 5, new Controller1(), Brushes.DarkCyan));
            //Food.Add(new SpeedyFood(new Point(3, 4), this));
            //Food.Add(new SpeedyFood(new Point(5, 6), this));
            //Food.Add(new StandardFood(new Point(7, 7), this));
            //Food.Add(new ValuableFood(new Point(3, 4), this));
            //Food.Add(new ValuableFood(new Point(5, 6), this));
            //Food.Add(new ValuableFood(new Point(7, 7), this));
            //Food.Add(new ValuableFood(new Point(1, 2), this));
            //Food.Add(new ValuableFood(new Point(5, 7), this));

            TilesX = tilesX;
            TilesY = tilesY;

            colliderMatrix = new Collider(tilesX, tilesY);
        }

        public void RemoveItem(Food food)
        {
            Food.Remove(food);
        }

        public void GameLoop()
        {
            foreach (var player in Players)
            {
                player.Move();
            }
            CheckCollisions();

            if (IsGameOver())
            {

            }
        }

        private bool IsGameOver()
        {
            foreach (var player in Players)
            {
                //return player.IsAlive();
            }

            return false;
        }

        private void CheckCollisions()
        {
            
            foreach (var food in Food)
            {
                colliderMatrix.EnterCollidableObject(food);
            }

            foreach (var snakeHead in Players)
            {
                colliderMatrix.SnakeHeadCollisions(snakeHead.getHead());
            }
        }

        public void Draw(Renderer renderer)
        {
            renderer.DrawAt(0, 0, TilesX, TilesY, Brushes.Orange);

            foreach (var player in Players)
            {
                player.Draw(renderer);
            }
            foreach (var food in Food)
            {
                food.Draw(renderer);
            }
        }

        private void SpawnNewFood()
        {

        }

        private void EndGame()
        {
            if (IsGameOver())
            {
                // Stop game somehow.
            }
        }

        public void MainForm_KeyPress(object sender, KeyEventArgs e)
        {
                foreach (var player in Players)
                {
                    player.ControllerInput(e.KeyCode);
                }
        }
    }
}
