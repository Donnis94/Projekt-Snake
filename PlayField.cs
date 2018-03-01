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

        public event EventHandler gameOver;
        public PlayField(int AmountOfPlayers, int tilesX, int tilesY)
        {
            SpawnNewPlayer(AmountOfPlayers, tilesX, tilesY);
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
                player.Update();
            }
            CheckCollisions();
            SpawnNewFood();
            if (IsGameOver())
            {
                gameOver.Invoke(this, null);  
            }
        }

        private bool IsGameOver()
        {
            foreach (var player in Players)
            {
                if (player.isAlive)
                {
                    return false;
                }
            }
            return true;
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

            foreach (var snake in Players)
            {
                snake.addHeadToCollider(colliderMatrix);
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
                if (Random.Next(20) == 0)
                {
                    Food.Add(foodFactory.ProduceFood(this.tilesX, this.tilesY, this, FoodFactory.FoodType.SpeedyFood, colliderMatrix));
                }
                else if (Random.Next(50) == 0)
                {
                    Food.Add(foodFactory.ProduceFood(this.tilesX, this.tilesY, this, FoodFactory.FoodType.SpeedyFood, colliderMatrix));
                }
                else
                    Food.Add(foodFactory.ProduceFood(this.tilesX, this.tilesY, this, FoodFactory.FoodType.SpeedyFood, colliderMatrix));
            }
        }

        public void GiveRandomSnakeSpeedUpEffect()
        {
            
            var random = new Random();
            foreach (var snake in Players)
            {
                if (snake.isAlive)
                {
                    SnakesAvailable.Add(snake);
                }
            }
            var playerToMakeSpeedy = random.Next(SnakesAvailable.Count);
            SnakesAvailable.ElementAt(playerToMakeSpeedy).StartSpeedUp();
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
                    var startPoint1 = new Point(1, 2);
                    return startPoint1;
                case Config.Player.Player2:
                    var startPoint2 = new Point(tilesX - 2, 2);
                    return startPoint2;
                case Config.Player.Player3:
                    var startPoint3 = new Point(tilesX / 2, tilesY-2);
                    return startPoint3;
                default:
                {
                    throw new MissingFieldException();
                }
            }
        }

        public int AmountOfPlayers()
        {
            return Players.Count;
        }
    }
}
