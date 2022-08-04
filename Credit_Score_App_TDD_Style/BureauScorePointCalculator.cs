using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credit_Score_App_TDD_Style
{
    public class BureauScorePointCalculator
    {
        public int CalculatePoint(int bureauScore)
        {
            int point = 0;
            if (bureauScore > 450 && bureauScore <= 700)
            {
                point = 1;
            }
            else if (bureauScore > 700 && bureauScore <= 850)
            {
                point = 2;
            }
            else if (bureauScore > 850 && bureauScore <= 1000)
            {
                point = 3;
            }
            else
            {
                point = 0;
            }
            return point;
        }
    }
}
