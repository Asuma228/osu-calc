using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace osu_calc
{
    public partial class MainForm : Form
    {
        public MainForm()
        {

            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            {
                Scores scores = new Scores();
                lblScoresCurrentLevel.Text = scores.LvlNeeded(txtboxScoresCurrentScores.Text);

            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
