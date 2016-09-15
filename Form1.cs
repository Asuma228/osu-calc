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

        private void nudScoresCurrentScores_ValueChanged(object sender, EventArgs e)
        {
            {
                Scores scores = new Scores();
                lblScoresCurrentLevel.Text = scores.LvlNeeded(nudScoresCurrentScores.Value);
                lblScoresNeededScores.Text = scores.NeededScores(nudScoresCurrentScores.Value);


            }
        }


        private void btnPaste_Click(object sender, EventArgs e)
        {
            string p;
            Scores scores = new Scores();
            p = scores.TransString();
            nudScoresCurrentScores.Value = Convert.ToDecimal(p);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
