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

        public Collider()
        {
            collidables = new ICollideble[10, 10];
        }

        public void EnterCollidableObject(ICollideble objectsToCollide)
        {
            collidables[objectsToCollide.position.X, objectsToCollide.position.Y] = objectsToCollide;
        }

        public void SnakeHeadCollisions(SnakeBody snakeHead)
        {
            if (collidables[snakeHead.position.X, snakeHead.position.Y] != null)
            {
                collidables[snakeHead.position.X, snakeHead.position.Y].CollisionEffect(snakeHead);
            }
        }

    }
}
