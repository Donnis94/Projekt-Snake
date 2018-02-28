using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_Projekt
{
    public partial class MainForm : Form
    {
        PlayField pf;
        Timer timer;
        Renderer r;
        private Trigger trigger;
        public static int FPS = 40;

        public delegate void KeyPushedHandler(Keys key);
        public static event KeyPushedHandler keyPushed;

        private int TilesX = 50;
        private int TilesY = 50;

        public MainForm()
        {
            this.WindowState = FormWindowState.Maximized;
            BackColor = Color.Black;
            InitializeComponent();
            Initialize();
            KeyDown += MainForm_KeyPress;
            Resize += MainForm_Resize;
            
            Snake.ScoreChanged += OnScoreUpdated;
        }

        private void Initialize()
        {
            MainForm_Label.Paint += new PaintEventHandler(Draw);
            
            pf = new PlayField(1, TilesX, TilesY);
            r = new Renderer(MainForm_Label, TilesX, TilesY);
            timer = new Timer();
            timer.Tick += new EventHandler(TimerEventHandler);
            timer.Interval = 1000 / FPS;
            timer.Start();

        }


        

        private void Draw(Object obj, PaintEventArgs args)
        {
            r.UpdateGraphic(args.Graphics);
            pf.Draw(r);
        }

        private void TimerEventHandler(Object obj, EventArgs args)
        {
            pf.GameLoop();
            MainForm_Label.Refresh();
        }

        private void OnScoreUpdated(Snake source)
        {
            switch (source.player)
            {
                case Config.Player.Player1:
                    Player1_Score_Label.Text = source.Score.ToString();
                    break;
                case Config.Player.Player2:
                    Player2_Score_Label.Text = source.Score.ToString();
                    break;
                case Config.Player.Player3:
                    Player3_Score_Label.Text = source.Score.ToString();
                    break;
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            r.updateAreaSize();
        }

        public void MainForm_KeyPress(object sender, KeyEventArgs e)
        {
            keyPushed.Invoke(e.KeyCode);
        }
    }
}
