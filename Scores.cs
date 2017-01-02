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
        private decimal[] arrayScores = new decimal[501];

        public Scores()
        {


            for (int i = 2; i <= 100; i++)
            {
                Convert.ToDecimal(i);
                arrayScores[i] = Decimal.Truncate(Convert.ToDecimal((5000 / 3.0 * (4 * System.Math.Pow(i, 3) - 3 * System.Math.Pow(i, 2) - i)) + (1.25 * System.Math.Pow(1.8, i - 60))));
            }

            for (int i = 101; i <= 500; i++)
            {
                Convert.ToDecimal(i);
                arrayScores[i] = Decimal.Truncate(26931190829 + 100000000000 * (i - 100));
            }
        }

        internal string ProcessString(string p) //Эта функция добавляет во входную строку пробелы между разрядами
        {
            for (int i = p.Length; i > 1; i--)
            {
                if (i % 3 == 0)
                {
                    p = p.Insert(p.Length - i, " ");
                }
            }
            return p;
        }

        internal string Case(string p)
        {
            decimal v = Convert.ToDecimal(p);
            long x = Convert.ToInt64(v)/10;
            string o;
            if (x % 10 == 1)

            {
                o = " очков";
            }

            else if (v % 10 == 1)
            {
                o = " очко";
            }

            else if ((v % 10 == 2) || (v % 10 == 3) || (v % 10 == 4)) // Исправить, сцуко!!
            {
                o = " очка";
            }

            else o = " очков";

            return o;
        }

        internal string Percentage(string p)
        {
            decimal v = Convert.ToDecimal(p);
            string o;
            o = Convert.ToString((1000000*(v / arrayScores[(Convert.ToInt32(currentLevel)+1)])));
            v = Math.Truncate(Convert.ToDecimal(o));
            o = Convert.ToString((v / 10000));
            return o;
        }

        internal bool IfEx(decimal p)
        {
            if (p > arrayScores[300])
                return false;
            else return true;
        }

        internal string LvlNeeded(decimal p)
        {

                    for (int i = 1; i <= 499; i++)
                    {
                        if (p >= arrayScores[i] 
                            && p <= arrayScores[i + 1])
                        {
                            currentLevel = Convert.ToString(i);
                            break;
                        }
                    }
            return (currentLevel);
        }

        internal string NeededScores(string p)
        {
            decimal pd = Convert.ToDecimal(p);
            neededScores =  Convert.ToString(Convert.ToDecimal(arrayScores[Convert.ToInt32(currentLevel)+1]) - pd);
            ProcessString(neededScores); 
            return neededScores;
        }

        internal string TransString(string p) // Эта функция удаляет из входной строки все символы кроме цифр
        {
            for (int i = (p.Length) - 1; i >= 0; i--)
            {
                if ((p[i] != '0') && (p[i] != '1') && (p[i] != '2') && (p[i] != '3') && (p[i] != '4') && (p[i] != '5') && (p[i] != '6') && (p[i] != '7') && (p[i] != '8') && (p[i] != '9'))
                {
                    p = p.Remove(i, 1);
                }
            }
            // Пустой буфер вызывает ошибку, поэтому...
            if (p == "")
            {
                p = "0";
            }
            // Обожаю костыли ^^
            return p;

        }

        internal string NeededScoresLevels(string p)
        {
            string r;
            r = Convert.ToString(Convert.ToDecimal(arrayScores[Convert.ToInt32(p) + 1]) - Convert.ToDecimal(arrayScores[Convert.ToInt32(p)]));
            return ProcessString(r);
        }
    }
}
