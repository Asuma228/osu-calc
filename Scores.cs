using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu_calc
{

    class Scores
    {
        double[] arrayScores = new double[500];
        public Scores()
        {
            for (int i = 1; i <= 100; i++)
            {
                Convert.ToDouble(i);
                arrayScores[i] = 5000/3*((4*i)^3-(3*i^2) - i) + 1.25 * (1.8^(i-60));
            }
        }
    }
}
