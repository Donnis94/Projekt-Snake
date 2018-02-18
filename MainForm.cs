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

        FlowLayoutPanel flowPanel;

        private int TilesX = 70;
        private int TilesY = 70;

        public MainForm()
        {
            Width = 800;
            Height = 600;
            BackColor = Color.Black;
            InitializeComponent();
            InitializeGUI();
            Initialize();
            KeyDown += pf.MainForm_KeyPress;
            Resize += MainForm_Resize;
        }

        private void Initialize()
        {
            flowPanel.Paint += new PaintEventHandler(Draw);

            pf = new PlayField(1, TilesX, TilesY);

            timer = new Timer();
            timer.Tick += new EventHandler(TimerEventHandler);
            timer.Interval = 1000 / 20;
            timer.Start();

        }

        private void InitializeGUI()
        {

            FlowLayoutPanel mainPanel = new FlowLayoutPanel();
            mainPanel.Height = 100;
            flowPanel = new FlowLayoutPanel();

            mainPanel.BackColor = Color.ForestGreen;
            
            mainPanel.Dock = DockStyle.Bottom;

            flowPanel.Dock = DockStyle.Fill;
            flowPanel.BackColor = Color.Aqua;

            this.Controls.Add(flowPanel);
            this.Controls.Add(mainPanel);
            r = new Renderer(flowPanel, TilesX, TilesY);
        }

        private void Draw(Object obj, PaintEventArgs args)
        {
            pf.Draw(r);
        }

        private void TimerEventHandler(Object obj, EventArgs args)
        {
            pf.GameLoop();
            flowPanel.Refresh();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            r.updateAreaSize();
        }
    }
}
