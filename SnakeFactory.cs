using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Projekt
{
    class SnakeFactory
    {

        public enum Players { Player1 = 1, Player2 = 2, Player3 = 3}

        public static Snake ProduceSnake(int x, int y, int size, Controller controller, Brush color, Players player)
        {
            switch (player)
            {
                case Players.Player1:
                {
                    return new Snake(x, y, size, controller, color);
                }
                case Players.Player2:
                {
                    return new Snake(x, y, size, controller, color);
                }
                case Players.Player3:
                {
                    return new Snake(x, y, size, controller, color);
                }
                default:
                {
                    throw new MissingFieldException();
                }
            }
        }
    }
}
