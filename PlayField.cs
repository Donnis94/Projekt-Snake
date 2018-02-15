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
        Timer timer;
        
        public PlayField(int AmountOfPlayers, Renderer renderer)
        {
            timer = new Timer();
        }
        
        public void Run()
        {
            playForm.Paint += new PaintEventHandler(Draw);
            timer.Tick += new EventHandler(TimerEventHandler);
            timer.Interval = 1000/25;
            timer.Start();
        }

        private bool IsGameOver()
        {
            foreach(var player in Players)
            {
                return player.IsAlive();
            }
        }

        private void CheckCollisions()
        {
            throw new NotImplementedException();
        }

        private void Draw()
        {
            foreach(var player in Players)
            {
                player.Draw();
            }
            foreach(var food in Food)
            {
                food.Draw();
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

        private TimeEventHandler(object sender, EventArgs args)
        {

        }
    }
}
