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

        private int TilesX = 50;
        private int TilesY = 50;

        public MainForm()
        {

            //this.WindowState = FormWindowState.Maximized;
            BackColor = Color.Black;
            InitializeComponent();
            Initialize();
            KeyDown += pf.MainForm_KeyPress;
            Resize += MainForm_Resize;
        }

        private void Initialize()
        {
            MainForm_Label.Paint += new PaintEventHandler(Draw);
            
            pf = new PlayField(1, TilesX, TilesY);
            r = new Renderer(MainForm_Label, TilesX, TilesY);
            timer = new Timer();
            timer.Tick += new EventHandler(TimerEventHandler);
            timer.Interval = 1000 / 20;
            timer.Start();

        }

        

        private void Draw(Object obj, PaintEventArgs args)
        {
            pf.Draw(r);
        }

        private void TimerEventHandler(Object obj, EventArgs args)
        {
            pf.GameLoop();
            MainForm_Label.Refresh();
            //Player1_Score_Label.Text = pf.GetPlayerScore(1).ToString();
            //Player2_Score_Label.Text = pf.GetPlayerScore(2).ToString();
            //Player3_Score_Label.Text = pf.GetPlayerScore(3).ToString();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            r.updateAreaSize();
        }

        public void OnScoreChanged(object source, EventArgs e)
        {

        }


    }
}
