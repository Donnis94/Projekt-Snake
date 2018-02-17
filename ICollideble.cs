using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Projekt
{
    interface ICollideble
    {
        Point position { get; set; }
        void CollisionEffect(SnakeBody sb);
    }
}
