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
        private Random Random = new Random();

        private FoodFactory foodFactory = new FoodFactory();

        private int TilesX;
        private int TilesY;

        public PlayField(int AmountOfPlayers, int tilesX, int tilesY)
        {
            Players.Add(new Snake(1, 1, 5, new Controller1(), Brushes.DarkCyan));

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
            SpawnNewFood();
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
            colliderMatrix.Clear();
            foreach (var food in Food)
            {
                colliderMatrix.EnterCollidableObject(food);
            }

            foreach (var snake in Players)
            {
                snake.addBodyToCollider(colliderMatrix);
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
            if (Food.Count < 20)
            {
                if (Random.Next(1) == 0)
                {
                    Food.Add(foodFactory.ProduceFood(this.TilesX, this.TilesY, this, FoodFactory.FoodType.SpeedyFood, colliderMatrix));
                }
                else if (Random.Next(50) == 0)
                {
                    Food.Add(foodFactory.ProduceFood(this.TilesX, this.TilesY, this, FoodFactory.FoodType.ValuableFood, colliderMatrix));
                }
                else
                    Food.Add(foodFactory.ProduceFood(this.TilesX, this.TilesY, this, FoodFactory.FoodType.StandardFood, colliderMatrix));
                
            }
        }

        private void SpawnNewPlayer(int amountOfPlayers)
        {
            switch (amountOfPlayers)
            {
                case 1:
                {
                    Players.Add(SnakeFactory.ProduceSnake(1, 1, 5, new Controller1(), Brushes.DarkCyan,SnakeFactory.Players.Player1));
                    return;
                }
                case 2:
                {
                    Players.Add(SnakeFactory.ProduceSnake(1, 1, 5, new Controller1(), Brushes.DarkCyan,SnakeFactory.Players.Player1));
                    Players.Add(SnakeFactory.ProduceSnake(1, 1, 5, new Controller2(), Brushes.DarkCyan,SnakeFactory.Players.Player2));
                    return;
                }
                case 3:
                {
                    Players.Add(SnakeFactory.ProduceSnake(1, 1, 5, new Controller1(), Brushes.DarkCyan, SnakeFactory.Players.Player1));
                    Players.Add(SnakeFactory.ProduceSnake(1, 1, 5, new Controller2(), Brushes.DarkCyan, SnakeFactory.Players.Player2));
                    Players.Add(SnakeFactory.ProduceSnake(1, 1, 5, new Controller3(), Brushes.DarkCyan, SnakeFactory.Players.Player3));
                    return;
                }

            }
        }

        public int GetPlayerScore(int playerScore)
        {
            switch (playerScore)
            {
                case 1:
                    return Players.ElementAt(0).GetScore();
                    break;
                case 2:
                    return Players.ElementAt(1).GetScore();
                    break;
                case 3:
                    return Players.ElementAt(2).GetScore();
                    break;
            }

            return 0;
        }

        private void EndGame()
        {
            if (IsGameOver())
            {
                // Stop game somehow.
            }
        }

        public int AmountOfPlayers()
        {
            return Players.Count;
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
