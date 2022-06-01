using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG_POE_PART_1
{
    class Home_Loan : Expenses
    {
        private double propPrice;
        private double totalDep;
        private double intRate;
        private int monthsRepay;

        override public void availableMoney(double grossInc)
        {
            Console.WriteLine("\n\n******************************************************************* " + "\n\nBUYING A PROPERTY : \n");

            // prompt user for input
            Console.WriteLine("Enter the purchase price of property : ");
            propPrice = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the amount for total deposit : ");
            totalDep = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the interest rate (in percentage): ");
            intRate = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of months to repay (between 240 and 360) : ");
            monthsRepay = int.Parse(Console.ReadLine());

            // while loop used for monthly repayment
            while ((monthsRepay != 240) && (monthsRepay != 360))
            {
                Console.WriteLine("Invalid Entry!!! Please try again >>>>");
                Console.Write("Enter number of months repay (between 240 and 360) : ");
                monthsRepay = int.Parse(Console.ReadLine());
            }
            // Compound Interest Formula Used

            double prinAmnt = propPrice - totalDep;
            double interest = intRate / 100; //decimal
            int years = monthsRepay / 12; //in years

            double monthlyRepay = (prinAmnt * (interest * years));

            if (monthlyRepay > (grossInc / 3))
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nApproval of home loan is unlikey!!!");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }

            //output
            double availableMoney = grossInc - (monthlyRepay + GetTotalExp());
            Console.WriteLine("\nMonthly Repayment: R" + Math.Round(monthlyRepay));
            Console.WriteLine("\nAvaliable monthly money : R" + Math.Round(availableMoney));



        }
    }
}

