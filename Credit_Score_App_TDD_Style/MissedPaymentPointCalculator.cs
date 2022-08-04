using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credit_Score_App_TDD_Style
{
    public class MissedPaymentPointCalculator
    {
        public int CalculatePoint(int missedPayment)
        {
            int point = 0;
            if (missedPayment <= 0)
            {
                point = 0;
            }
            else if (missedPayment == 1)
            {
                point = -1;
            }
            else if (missedPayment == 2)
            {
                point = -3;
            }
            else if (missedPayment >= 3)
            {
                point = -6;
            }
            return point;
        }
    }
}
