using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Snake_Projekt
{
    class Snake 
    {
        private List<SnakeBody> body = new List<SnakeBody>(); 
        private int score;
        private Controller controller;
        bool isAlive = true;
        Point point;
        private int size;
        public enum Direction { up,down,left, right};
        Color color
        {
            set;
            get;
        }
        public Snake(int x, int y, int size, Controller controller, Color color) : this(new Point(x, y), size, controller, color) { }
        public Snake (Point point, int size, Controller controller,Color color)
        {
            this.point = point;
            this.size = size;
            this.controller = controller;
            this.color = color;
            score = 0;
        }
        public void Move (Direction direction)
        {

        }
        public void isValidMove (Direction direction)
        {

        }
        public void expand ()
        {

        }
        public void getHead ()
        {

        }
        public void CollisionEffect()
        {

        }
        public void Draw(Renderer renderer)
        {
            for (int i = 0; i < body.Count; i++)
            {
                body[i].Draw(renderer);
            }
        }
    }
}
