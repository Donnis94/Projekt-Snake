using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Projekt
{
    static class Config
    {
        public enum Player { Player1, Player2, Player3 }

        public static Brush GetPlayerColor(Player player)
        {
            switch (player)
            {
                case Player.Player1:
                    return Brushes.Red;
                case Player.Player2:
                    return Brushes.BlanchedAlmond;
                case Player.Player3:
                    return Brushes.Blue;
            }

            return Brushes.Black;
        }

        public static Controller GetPlayerControl(Player player)
        {
            switch (player)
            {
                case Player.Player1:
                    return new Controller1();
                case Player.Player2:
                    return new Controller3();
                case Player.Player3:
                    return new Controller3();
            }

            return new Controller1();
        }

        /*public static Snake.Direction GetPlayerDirection(Player player)
        {
            switch (player)
            {
                case Player.Player1:
                    return Snake.Direction.left;
                case Player.Player2:
                    return new Controller3();
                case Player.Player3:
                    return new Controller3();
            }
        }
        */
    }
}
