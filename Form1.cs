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
                    lblScoresCurrentLevel.Text = scores.LvlNeeded(Convert.ToDecimal(txtBoxScoresCurrentScores.Text))+"-ый уровень";
                    lblScoresNeededScores.Text = scores.ProcessString(scores.NeededScores(txtBoxScoresCurrentScores.Text)) + ' '+ scores.Case(scores.ProcessString(scores.NeededScores(txtBoxScoresCurrentScores.Text))) + '('+ scores.Percentage(scores.ProcessString(scores.NeededScores(txtBoxScoresCurrentScores.Text))) + "%)";
                    progressBar1.Value = 100 - Convert.ToInt32(Math.Truncate(Convert.ToDecimal(scores.Percentage(scores.ProcessString(scores.NeededScores(txtBoxScoresCurrentScores.Text))))));
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

        private void nudCurrentLevel_ValueChanged(object sender, EventArgs e)
        {
            Scores scores = new Scores();
            decimal p = nudCurrentLevel.Value;
            lblLevelScoresNeeded.Text = scores.NeededScoresLevels(Convert.ToString(p));

        }

 

        // Ахтунг! Чужой код!! Взято с http://www.cyberforum.ru/windows-forms/thread82595.html

        int iFormX, iFormY, iMouseX, iMouseY;//глобальные переменные

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            iFormX = this.Location.X;
            iFormY = this.Location.Y;
            iMouseX = MousePosition.X;
            iMouseY = MousePosition.Y;

        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            int iMouseX2 = MousePosition.X;
            int iMouseY2 = MousePosition.Y;
            if (e.Button == MouseButtons.Left)
                this.Location = new Point(iFormX + (iMouseX2 - iMouseX), iFormY + (iMouseY2 - iMouseY));

        }

        // Ахтунг! Чужой код!! Взято с http://www.cyberforum.ru/windows-forms/thread82595.html

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

