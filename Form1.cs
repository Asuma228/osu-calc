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
                double[] arrayScores = new double[501];

                for (int i = 2; i <= 101; i++)
                {
                    Convert.ToDouble(i);
                    arrayScores[i] = (5000 / 3.0 * (4 * System.Math.Pow(i, 3) - 3 * System.Math.Pow(i, 2) - i)) + (1.25 * System.Math.Pow(1.8, i - 60));
                }

                for (int i = 1; i <= 101; i++)
                {
                    if (Convert.ToDouble(txtboxScoresCurrentScores.Text) <= arrayScores[i] && Convert.ToDouble(txtboxScoresCurrentScores.Text) >= arrayScores[i-1])
                    {
                        lblScoresCurrentLevel.Text = Convert.ToString(i);
                        break;
                    }
                }
            }
        }
    }
}
