using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG_POE_PART_1
{
    class Rent : Expenses
    {
        // variables
        private double rentAmnt;


        override public void availableMoney(double grossInc)
        {
            Console.WriteLine("\n\n******************************************************************" + "\n\nRenting : \n");

            // prompt user for input
            Console.Write("Enter the monthly rental amount : ");
            rentAmnt = Convert.ToDouble(Console.ReadLine());
            double availableMoney = grossInc - (rentAmnt + GetTotalExp());
            Console.WriteLine("Available monthly money : R" + Math.Round(availableMoney));
        }

    }


}
