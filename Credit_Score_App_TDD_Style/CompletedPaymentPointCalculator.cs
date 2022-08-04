using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credit_Score_App_TDD_Style
{
    public class CompletedPaymentPointCalculator
    {
        public int CalculatePoint(int completedPayment)
        {
            int point = 0;
            if (completedPayment <= 0)
            {
                point = 0;
            }
            else if (completedPayment == 1)
            {
                point = 2;
            }
            else if (completedPayment == 2)
            {
                point = 3;
            }
            else if (completedPayment >= 3)
            {
                point = 4;
            }
            return point;
        }
    }
}
