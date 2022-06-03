using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG_POE_PART_1 
{
    class Vehicle : Expenses
    {
        // variables declared
        private string model;
        private string make;
        private double purPrice;
        private double totDep;
        private double intRate;
        private double insurance;

        override public void availableMoney(double grossInc)
        {
            Console.WriteLine("\n\n*************************************************************************" +"\n\nBuying a vehicle : \n");

            //input from user
            Console.Write("Enter the make of the vehicle : ");
            make = Console.ReadLine();

            Console.Write("Enter the model of the vehicle : ");
            model = Console.ReadLine();

            Console.Write("Enter the purchase price of the vehicle : ");
            purPrice = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter total deposit for the veicle : ");
            totDep = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter interest rate (without %) : ");
            intRate = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter estimated insurance premium : ");
            insurance = Convert.ToDouble(Console.ReadLine());

            double vehCost = 0;
            double monthlyPay = 0;

            
            double principleAmt = purPrice - totDep; 
            intRate = intRate / 100; 
            vehCost = principleAmt * (1 + (intRate * 5)); 
            monthlyPay = (vehCost / 60) + insurance; 
            

            
            double avaMoney = grossInc - (monthlyPay + GetTotalExp());

            Console.WriteLine("\n Vehicle Monthly Repayment: R" + Math.Round(monthlyPay, 2));
            Console.WriteLine("\nAvaliable monthly money : R" + Math.Round(avaMoney, 2));
            
            expense.Add("Vehicle", Math.Round(monthlyPay, 2));

        }
       }
     }
