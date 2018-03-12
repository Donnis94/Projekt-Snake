using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Snake_Projekt
{
    public partial class HsForm : Form
    {
        public HsForm()
        {
            InitializeComponent();
            StreamReader SR = new StreamReader(Config.HighScoreTxtFileLocation);
            int[] scores = new int[5];
            for (int counter = 0; counter < 5; counter++)
            {
                scores[counter] = int.Parse(SR.ReadLine());
            }
            HsLabel.Text = $"1.  { scores[0]}\n\n2.  { scores[1]}\n\n3.  { scores[2]}\n\n4.  { scores[3]}\n\n5.  { scores[4]}";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
