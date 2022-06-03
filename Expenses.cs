using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG_POE_PART_1
{
    abstract class Expenses
    {
        protected Dictionary<string, double> expense = new Dictionary<string, double>();
        protected double totExp = 0;

        public void SetExp(Dictionary<string, double> e)
        {
            expense = e;
        }

        public double GetTotalExp()
        {
            foreach (int value in expense.Values)
            {
                totExp += value;
            }
            return totExp;
        }

        public abstract void availableMoney(double grossInc);

    }
}


