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

        private int XSize = 100;
        private int YSize = 100;

        public Collider()
        {
            Clear();
        }

        public bool SnakeOutOfBounds(SnakeBody snakeHead)
        {
            if (snakeHead.position.X < 0 || snakeHead.position.X >= XSize)
            {
                return true;
            }

            if (snakeHead.position.Y < 0 || snakeHead.position.Y >= XSize)
            {
                return true;
            }

            return false;
        }

        public void EnterCollidableObject(ICollideble objectsToCollide)
        {
            collidables[objectsToCollide.position.X, objectsToCollide.position.Y] = objectsToCollide;
        }

        public void SnakeHeadCollisions(SnakeBody snakeHead)
        {
            if (SnakeOutOfBounds(snakeHead))
            {
                snakeHead.mySnake.isAlive = false;
            }
            if (collidables[snakeHead.position.X, snakeHead.position.Y] != null)
            {
                collidables[snakeHead.position.X, snakeHead.position.Y].CollisionEffect(snakeHead);
            }
        }

        public void Clear()
        {
            collidables = new ICollideble[XSize, YSize];
        }

    }
}
