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
                if (scores.IfEx(nudScoresCurrentScores.Value))
                {
                    lblScoresCurrentLevel.Text = scores.LvlNeeded(nudScoresCurrentScores.Value);
                    lblScoresNeededScores.Text = scores.ProcessString(scores.NeededScores(nudScoresCurrentScores.Value));
                }
                else
                {
                    lblScoresCurrentLevel.Text = "Слишком большое значение. Достиг 300-го уровня?";
                    lblScoresNeededScores.Text = "";
                }

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

        private void cmbBoxCurLvl_SelectedIndexChanged(object sender, EventArgs e)
        {
            Scores scores = new Scores();
            string p = cmbBoxCurLvl.Text;
            lblLevelScoresNeeded.Text = scores.NeededScoresLevels(p);
        }
    }
}

