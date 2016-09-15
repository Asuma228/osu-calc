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
            string p; //переменная-буфер
            p = Clipboard.GetText();
            // Пустой буфер вызывает ошибку, поэтому...
            if (p == "")
            {
                p = "0";
            }
            // Обожаю костыли ^^
            for (int i = (p.Length)-1; i > 0; i--)
            {
                if ((p[i] != '0') && (p[i] != '1') && (p[i] != '2') && (p[i] != '3') && (p[i] != '4') && (p[i] != '5') && (p[i] != '6') && (p[i] != '7') && (p[i] != '8') && (p[i] != '9'))
                {
                    p = p.Remove(i, 1);
                }
            }
            nudScoresCurrentScores.Value = Convert.ToDecimal(p);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
