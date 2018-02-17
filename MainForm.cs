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
        
        

        public MainForm()
        {
            Width = 800;
            Height = 600;
            BackColor = Color.Black;
            InitializeComponent();
            Initialize();
            KeyDown += pf.MainForm_KeyPress;
        }

        private void Initialize()
        {
            this.Paint += new PaintEventHandler(Draw);
            


            pf = new PlayField(1);
            r = new Renderer(this.CreateGraphics());

            timer = new Timer();
            timer.Tick += new EventHandler(TimerEventHandler);
            timer.Interval = 1000 / 1;
            timer.Start();


        }

        private void Draw(Object obj, PaintEventArgs args)
        {
            pf.Draw(r);
        }

        private void TimerEventHandler(Object obj, EventArgs args)
        {
            pf.GameLoop();
            this.Refresh();
        }
    }
}
