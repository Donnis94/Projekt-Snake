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
        Renderer r;
        public MainForm()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            this.Paint += new PaintEventHandler(Draw);
            this.MouseClick += new MouseEventHandler(Form1_MouseClick);
            r = new Renderer(this.CreateGraphics());
            


        }

        private void Draw(Object obj, PaintEventArgs args)
        {
            r.DrawAt(1, 1, Pens.Black);
            r.DrawAt(0, 0, Pens.Black);
            r.DrawAt(1, 0, Pens.Black);
            r.DrawAt(0, 1, Pens.Black);
        }

        void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Refresh();
        }
    }
}
