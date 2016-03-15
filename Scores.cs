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
        private string currentLevel = "0";
        private string neededScores = "0";
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

        internal string LvlNeeded(decimal p)
        {

                    for (int i = 1; i <= 499; i++)
                    {
                        if (Convert.ToDouble(p) >= arrayScores[i] 
                            && Convert.ToDouble(p) <= arrayScores[i + 1])
                        {
                            currentLevel = Convert.ToString(i);
                            break;
                        }
                    }
            return (currentLevel);
        }

        internal string NeededScores(decimal p)
        {

            neededScores =  Convert.ToString(arrayScores[Convert.ToInt32(currentLevel)+1] - Convert.ToDouble(p));
             
            for (int i = neededScores.Length; i > 1 ; i--)
            {
                if (i % 3 == 0)
                {
                    neededScores = neededScores.Insert(neededScores.Length - i, " ");
                }
            }

            return neededScores;
        }
    }
}
