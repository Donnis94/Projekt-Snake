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

        private int tilesX;
        private int tilesY;

        public PlayField(int AmountOfPlayers, int tilesX, int tilesY)
        {
            //Players.Add(new Snake(1, 1, 5, Config.Player.Player1));
            SpawnNewPlayer(3, tilesX, tilesY);
            this.tilesX = tilesX;
            this.tilesY = tilesY;

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
            renderer.DrawAt(0, 0, tilesX, tilesY, Brushes.Orange);

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
                    Food.Add(foodFactory.ProduceFood(this.tilesX, this.tilesY, this, FoodFactory.FoodType.StandardFood, colliderMatrix));
                }
                else if (Random.Next(50) == 0)
                {
                    Food.Add(foodFactory.ProduceFood(this.tilesX, this.tilesY, this, FoodFactory.FoodType.ValuableFood, colliderMatrix));
                }
                else
                    Food.Add(foodFactory.ProduceFood(this.tilesX, this.tilesY, this, FoodFactory.FoodType.StandardFood, colliderMatrix));
                
            }
        }

        
        private void SpawnNewPlayer(int amountOfPlayers, int tilesX, int tilesY)
        {
            switch (amountOfPlayers)
            {
                case 1:
                {
                    var startLocation = GetStartLocation(tilesX, tilesY, Config.Player.Player1);
                    Players.Add(SnakeFactory.ProduceSnake(startLocation.X, startLocation.Y, 5, Config.Player.Player1));
                    return;
                }
                case 2:
                {
                    var startLocation1 = GetStartLocation(tilesX, tilesY, Config.Player.Player1);
                    var startLocation2 = GetStartLocation(tilesX, tilesY, Config.Player.Player2);
                    Players.Add(SnakeFactory.ProduceSnake(startLocation1.X, startLocation1.Y, 5, Config.Player.Player1));
                    Players.Add(SnakeFactory.ProduceSnake(startLocation2.X, startLocation2.Y, 5, Config.Player.Player2));
                    return;
                }
                case 3:
                {
                    var startLocation1 = GetStartLocation(tilesX, tilesY, Config.Player.Player1);
                    var startLocation2 = GetStartLocation(tilesX, tilesY, Config.Player.Player2);
                    var startLocation3 = GetStartLocation(tilesX, tilesY, Config.Player.Player3);
                    Players.Add(SnakeFactory.ProduceSnake(startLocation1.X, startLocation1.Y, 5, Config.Player.Player1));
                    Players.Add(SnakeFactory.ProduceSnake(startLocation2.X, startLocation2.Y, 5, Config.Player.Player2));
                    Players.Add(SnakeFactory.ProduceSnake(startLocation3.X, startLocation3.Y, 5, Config.Player.Player3));
                    return;
                }

            }
        }

        private Point GetStartLocation(int tilesX, int tilesY, Config.Player player)
        {
            switch (player)
            {
                case Config.Player.Player1:
                    var startPoint1 = new Point(tilesX / 10, tilesY / 10);
                    return startPoint1;
                case Config.Player.Player2:
                    var startPoint2 = new Point(tilesX - 10, tilesY / 10);
                    return startPoint2;
                case Config.Player.Player3:
                    var startPoint3 = new Point(tilesX / 2, tilesY / 10);
                    return startPoint3;
                default:
                {
                    throw new MissingFieldException();
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
