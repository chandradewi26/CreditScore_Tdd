using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credit_Score_App_TDD_Style
{
    public class AgePointCalculator
    {
        public int CalculatePoint(int age)
        {
            int point = 0;
            if (age >= 18 && age <= 25)
            {
                point = 3;
            }
            else if (age >= 26 && age <= 35)
            {
                point = 4;
            }
            else if (age >= 36 && age <= 50)
            {
                point = 5;
            }
            else if (age >= 51)
            {
                point = 6;
            }
            else
            {
                point = 0;
            }
            return point;
        }
    }
}
