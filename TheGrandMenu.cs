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
    partial class TheGrandMenu : Form
    {
        public TheGrandMenu() => InitializeComponent();

        private void button1_Click(object sender, EventArgs e)
        {
            int Players = 1;   
            MainForm Form = new MainForm(Players);
            Form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Players = 2;
            MainForm Form = new MainForm(Players);
            Form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int Players = 3;
            MainForm Form = new MainForm(Players);
            Form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HsForm Form = new HsForm();
            Form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
