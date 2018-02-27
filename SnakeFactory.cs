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

        public static Snake ProduceSnake(int x, int y, int size, Config.Player player)
        {
            switch (player)
            {
                case Config.Player.Player1:
                {
                    return new Snake(x, y, size, Config.Player.Player1);
                }
                case Config.Player.Player2:
                {
                    return new Snake(x, y, size, Config.Player.Player2);
                }
                case Config.Player.Player3:
                {
                    return new Snake(x, y, size, Config.Player.Player3);
                }
                default:
                {
                    throw new MissingFieldException();
                }
            }
        }
    }
}
