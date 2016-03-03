using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace osu_calc
{

    class Scores
    {
        private double[] arrayScores = new double[501];

        public Scores()
        {


            for (int i = 2; i <= 100; i++)
            {
                Convert.ToDouble(i);
                arrayScores[i] = (5000 / 3.0 * (4 * System.Math.Pow(i, 3) - 3 * System.Math.Pow(i, 2) - i)) + (1.25 * System.Math.Pow(1.8, i - 60));
            }

            for (int i = 101; i <= 500; i++)
            {
                Convert.ToDouble(i);
                arrayScores[i] = 26931190829 + 100000000000 * (i - 100);
            }
        }

        internal string LvlNeeded(string p)
        {
            string currentLevel = "0";
            for (int i = 0; i <= 50; i++)
            {
                if ((p[i] != '0') 
                    && (p[i] != '1') 
                    && (p[i] != '2') 
                    && (p[i] != '3') 
                    && (p[i] != '4') 
                    && (p[i] != '5') 
                    && (p[i] != '6') 
                    && (p[i] != '7') 
                    && (p[i] != '8') 
                    && (p[i] != '9') 
                    && (Convert.ToDouble(p) > arrayScores[500]) 
                    && (p == ""))
                {
                    currentLevel = "";
                    MessageBox.Show("Вы ввели неверные данные, повторите ввод");
                    char c = p[i];
                }
                else
                {
                    for (int j = 1; i <= 500; j++)
                    {
                        if (Convert.ToDouble(p) <= arrayScores[i] 
                            && Convert.ToDouble(p) >= arrayScores[i - 1])
                        {
                            currentLevel = Convert.ToString(i);
                            break;
                        }
                    }
                }
            }
            return (currentLevel);
        }
    }
}
