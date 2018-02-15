using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_Projekt
{
    class PlayField
    {
        ISet<Snake> Players = new HashSet<Snake>();
        ISet<Food> Food = new HashSet<Food>();
        
        public PlayField(int AmountOfPlayers)
        {
            
        }
        
        public void Run()
        {
        }

        private bool IsGameOver()
        {
            foreach(var player in Players)
            {
                //return player.IsAlive();
            }

            return false;
        }

        private void CheckCollisions()
        {
            throw new NotImplementedException();
        }

        public void Draw(Renderer renderer)
        {
            foreach(var player in Players)
            {
                player.Draw(renderer);
            }
            foreach(var food in Food)
            {
                //food.Draw(renderer);
            }
        }

        private void SpawnNewFood()
        {

        }

        private void EndGame()
        {
            if(IsGameOver())
            {
                // Stop game somehow.
            }
        }
    }
}
