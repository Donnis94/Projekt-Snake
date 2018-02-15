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
        Renderer r;
        Timer timer;

        public MainForm()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            this.Paint += new PaintEventHandler(Draw);

            pf = new PlayField(1, new Renderer(this.CreateGraphics()));

            timer.Tick += new EventHandler(TimerEventHandler);
            timer.Interval = 1000 / 25;
            timer.Start();


        }

        private void Draw(Object obj, PaintEventArgs args)
        {
            r.DrawAt(1, 1, Pens.Black);
            r.DrawAt(0, 0, Pens.Black);
            r.DrawAt(1, 0, Pens.Black);
            r.DrawAt(0, 1, Pens.Black);
        }

        private void TimerEventHandler(Object obj, EventArgs args)
        {

            this.Refresh();
        }
    }
}
