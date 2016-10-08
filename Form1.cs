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

        private void txtBoxScoresCurrentScores_TextChanged(object sender, EventArgs e)
        {
            {
                Scores scores = new Scores();
                if (txtBoxScoresCurrentScores.Text == "")
                {
                    txtBoxScoresCurrentScores.Text = "0";
                }
                txtBoxScoresCurrentScores.Text = scores.TransString(txtBoxScoresCurrentScores.Text);
                if (scores.IfEx(Convert.ToDecimal(txtBoxScoresCurrentScores.Text)))
                {
                    lblScoresCurrentLevel.Text = scores.LvlNeeded(Convert.ToDecimal(txtBoxScoresCurrentScores.Text));
                    lblScoresNeededScores.Text = scores.ProcessString(scores.NeededScores(Convert.ToDecimal(txtBoxScoresCurrentScores.Text)));
                }
                else
                {
                    lblScoresCurrentLevel.Text = "Слишком большое значение.";
                    lblScoresNeededScores.Text = "";
                }

            }
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            string p;
            Scores scores = new Scores();
            p = Clipboard.GetText();
            p = scores.TransString(p);
            txtBoxScoresCurrentScores.Text = p;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbBoxCurLvl_SelectedIndexChanged(object sender, EventArgs e)
        {
            Scores scores = new Scores();
            string p = cmbBoxCurLvl.Text;
            lblLevelScoresNeeded.Text = scores.NeededScoresLevels(p);
        }

       
    }
}

