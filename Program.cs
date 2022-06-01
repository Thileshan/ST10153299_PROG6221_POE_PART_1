using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG_POE_PART_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\n\n\t\tBUDGET PLANNER" + "\n************************************************************************");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("INCOME : \n");
            //Gross monthly income(before deductions)
            Console.Write("Enter the gross income : ");
            double grossInc = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n\n************************************************************************" + "\n\nEXPENSES : \n");
            //method called
            double[] userExp = (double[])allExp();

            Console.WriteLine("\n\n************************************************************************" + "\n\nACCOMODATION : \n");

            int option = Accomodation();

            if (option == 1)
            {
                //if the user is renting

                Rent r = new Rent();
                r.SetExp(userExp);
                r.availableMoney(grossInc);

            }
            else
            if (option == 2)
            {
                // if the user is buying a property
                Home_Loan hl = new Home_Loan();
                hl.SetExp(userExp);
                hl.availableMoney(grossInc);

            }



            Console.ReadLine();

        }

        public static int Accomodation()
        {
            Console.Write("Enter '1' if you are renting or '2' if you are buying a property : ");
            int option = Convert.ToInt32(Console.ReadLine());

            while ((option <= 0) || (option > 2))
            {
                Console.WriteLine("InValid Entry please try again .");
                Console.Write("Enter '1' if you are renting or '2' if you are buying a property : ");
                option = Convert.ToInt32(Console.ReadLine());
            }
            return option;
        }

        public static Array allExp()
        {

            //Estimated monthly tax deducted
            Console.Write("Enter estimated monthly tax deducted : ");
            double tax = Convert.ToDouble(Console.ReadLine());

            //Groceries
            Console.Write("Enter cost of groceries : ");
            double groceries = Convert.ToDouble(Console.ReadLine());

            //water and lights
            Console.Write("Enter cost of water and lights : ");
            double watLight = Convert.ToDouble(Console.ReadLine());

            //Travel costs (including petrol)
            Console.Write("Enter cost of travel (including petrol) : ");
            double travCost = Convert.ToDouble(Console.ReadLine());

            //Cellphone and telephone
            Console.Write("Enter cost of Cell phone and telephone : ");
            double phone = Convert.ToDouble(Console.ReadLine());

            //other expenses
            Console.Write("Enter the cost of any other expenses : ");
            double othExp = Convert.ToDouble(Console.ReadLine());

            //expenses stored in array
            double[] userExp = { tax, groceries, watLight, travCost, phone, othExp };
            return userExp;








        }
    }
}
