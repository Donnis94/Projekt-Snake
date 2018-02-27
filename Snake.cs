using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace Snake_Projekt
{
    class Snake
    {
        private List<SnakeBody> body = new List<SnakeBody>();
        private int score;

        public delegate void ScoreChangedHandler(Snake source);
        public static event ScoreChangedHandler ScoreChanged;

        public int Score
        {
            get { return score; }
            internal set
            {
                score = value;
            }
        }

        private Controller controller;
        private Direction currentDirection;
        private Trigger moveTrigger;
        private Trigger speedTimeTrigger;
        public Config.Player player { get; private set; }
        public bool isAlive { get; set; }
        public bool isSpeedy = false;

        public enum Direction { up, down, left, right };

        public Brush brush { get; private set; }

        public Snake(int x, int y, int size, Config.Player player) : this(new Point(x, y), size, player) { }
        public Snake(Point point, int size, Config.Player player)
        {
            this.currentDirection = Config.GetPlayerDirection(player);
            this.controller = Config.GetPlayerControl(player);
            this.brush = Config.GetPlayerColor(player);
            this.player = player;
            this.score = 0;
            this.isAlive = true;
            this.moveTrigger = new Trigger(1);
            this.moveTrigger.Triggered += Move;
            this.moveTrigger.Start();
            this.speedTimeTrigger = new Trigger((1000 / MainForm.FPS) * 10);
            this.speedTimeTrigger.Triggered += StopSpeedUp;
            body.Add(new SnakeBody(point, this));
            expand(size);
            Move();
        }

        public void ControllerInput(Keys key)
        {
            controller.ValidMove(key);
        }

        public void Move()
        {
            if (!isAlive)
            {
                return;
            }

            for (int i = body.Count - 1; i > 0; i--)
                body[i].MoveTo(body[i - 1]);

            MoveSnakeHead();
        }

        public void Update()
        {
            //Move();
            moveTrigger.Tick();
            speedTimeTrigger.Tick();
        }

        public void StartSpeedUp()
        {
            speedTimeTrigger.Start();
            moveTrigger.Threshold = 0;
        }

        public void StopSpeedUp()
        {
            speedTimeTrigger.Stop();
            moveTrigger.Threshold = 1;
        }

        private void MoveSnakeHead()
        {
            if (!isValidMove())
            {
                controller.direction = currentDirection;
            }

            body[0].MoveInDirection(controller.direction);

            currentDirection = controller.direction;
        }

        public bool isValidMove()
        {
            if (currentDirection == Direction.down && controller.direction == Direction.up)
            {
                return false;
            }

            if (currentDirection == Direction.up && controller.direction == Direction.down)
            {
                return false;
            }
            if (currentDirection == Direction.right && controller.direction == Direction.left)
            {
                return false;
            }

            if (currentDirection == Direction.left && controller.direction == Direction.right)
            {
                return false;
            }

            return true;
        }

        public void expand(int count)
        {
            for (int i = 0; i < count; i++)
                body.Add(new SnakeBody(body[body.Count - 1].position, this));
        }

        public void addScore(int extra)
        {
            Score += extra;
            ScoreChanged?.Invoke(this);
        }

        public void addHeadToCollider(Collider c)
        {
            if (!isAlive)
            {
                return;
            }
            c.SnakeHeadCollisions(this.body[0]);
        }

        public void addBodyToCollider(Collider c)
        {
            if (!isAlive)
            {
                return;
            }
            for (int i = 1; i < body.Count; i++)
            {
                c.EnterCollidableObject(body[i]);
            }
        }

        public int GetScore()
        {
            return this.score;
        }

        public void Draw(Renderer renderer)
        {
            if (!isAlive)
            {
                return;
            }
            for (int i = 0; i < body.Count; i++)
            {
                body[i].Draw(renderer, brush);
            }
        }
    }
}
