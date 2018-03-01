using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Projekt
{
    class Collider
    {
        ICollideble[,] collidables;

        private int XSize;
        private int YSize;

        public Collider(int xSize, int ySize)
        {
            XSize = xSize;
            YSize = ySize;
            Clear();
        }

        public bool SnakeOutOfBounds(SnakeBody snakeHead)
        {
            if (snakeHead.position.X < 0 || snakeHead.position.X >= XSize)
            {
                return true;
            }

            if (snakeHead.position.Y < 0 || snakeHead.position.Y >= YSize)
            {
                return true;
            }
            return false;
        }

        public void EnterCollidableObject(ICollideble objectsToCollide)
        {
            if (collidables[objectsToCollide.position.X, objectsToCollide.position.Y] == null)
            {
                collidables[objectsToCollide.position.X, objectsToCollide.position.Y] = objectsToCollide;
            }
        }

        public void SnakeHeadCollisions(SnakeBody snakeHead)
        {
            if (SnakeOutOfBounds(snakeHead))
            {
                snakeHead.mySnake.isAlive = false;
            }
            else if (collidables[snakeHead.position.X, snakeHead.position.Y] != null)
            {
                collidables[snakeHead.position.X, snakeHead.position.Y].CollisionEffect(snakeHead);
            }
        }

        public bool IsTileEmpty(int x, int y)
        {
            return collidables[x, y] == null;
        }

        public void Clear()
        {
            collidables = new ICollideble[XSize, YSize];
        }

    }
}
