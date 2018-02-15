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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            this.Paint += new PaintEventHandler(Draw);
            this.MouseClick += new MouseEventHandler(Form1_MouseClick);
            Renderer r = new Renderer(this.CreateGraphics());

            r.DrawAt(3, 3, Pens.Black);


        }

        private void Draw(Object obj, PaintEventArgs args)
        {
            Renderer r = new Renderer(args.Graphics);
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
