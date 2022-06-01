using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG_POE_PART_1
{
    abstract class Expenses
    {
        protected double[] expense = new double[5];
        protected double totExp = 0;

        public void SetExp(double[] userExp)
        {
            expense = userExp;
        }

        public double GetTotalExp()
        {
            totExp = expense.Sum();
            return totExp;
        }

        public abstract void availableMoney(double grossInc);

    }
}


