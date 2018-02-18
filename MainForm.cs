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
            Width = 800;
            Height = 600;
            BackColor = Color.Black;
            InitializeComponent();
            Initialize();
            //InitializeGUI();
            KeyDown += pf.MainForm_KeyPress;
        }

        private void Initialize()
        {
            this.Paint += new PaintEventHandler(Draw);

            pf = new PlayField(1, TilesX, TilesY);
            r = new Renderer(this, TilesX, TilesY);

            timer = new Timer();
            timer.Tick += new EventHandler(TimerEventHandler);
            timer.Interval = 1000 / 20;
            timer.Start();

        }

        private void InitializeGUI()
        {

            FlowLayoutPanel mainPanel = new FlowLayoutPanel();
            FlowLayoutPanel flowPanel = new FlowLayoutPanel();

            mainPanel.BackColor = Color.ForestGreen;
            
            mainPanel.Dock = DockStyle.Bottom;

            flowPanel.Dock = DockStyle.Fill;
            flowPanel.BackColor = Color.Aqua;

            this.Controls.Add(mainPanel);
            this.Controls.Add(flowPanel);
            //r = new Renderer(flowPanel.CreateGraphics());
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
