using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PROG_POE_PART_1
{
    public class Program
    {
        // The delegate that will notify the user when expenses exceed 75% of income
        public delegate void notifyUserDelegate(double incomeDel, double totalExpenseDel);
        static void Main(string[] args)
        {
            Console.Write("Loading\n");
            for (int i = 5; i > 0; i--)
            {
                int num = 0;
                Console.Write(i+" ");
                Thread.Sleep(1000);
            }
            //method call introduction
            Introduction();
           
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("INCOME  \n");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            //Gross monthly income(before deductions)
            Console.Write("Enter the gross income : ");
            double grossInc = Convert.ToDouble(Console.ReadLine());


            //double[] userExp = (double[])allExp();
            Dictionary<string, double> a = (Dictionary<string, double>)allExp();

            Console.WriteLine("\n\n************************************************************************" + "\n\nACCOMODATION  \n");

            int option = Accomodation();

            if (option == 1)
            {
                //if the user is renting

                Rent r = new Rent();
                r.SetExp(a);
                r.availableMoney(grossInc);

            }
            else
            if (option == 2)
            {
                // if the user is buying a property
                Home_Loan hl = new Home_Loan();
                hl.SetExp(a);
                hl.availableMoney(grossInc);

            }
            Console.WriteLine("\n\n*************************************************************************" + "\n\nBuying A Vehicle ?  \n");
            //prompt user for input
            Console.Write("Enter '1' if you are buying a vehicle or '2' to continue : ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Vehicle v = new Vehicle();
            v.SetExp(a);
            //user is buying a vehicles
            if (option == 1)
            {
                v.availableMoney(grossInc);
            }
            v.SetExp(a);

            notifyUserDelegate nud = delegate (double incomeDel, double totalExpenseDel)
            {
                if (totalExpenseDel > (incomeDel * 0.75))
                {
                    //change color of text
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nYour total Expenses exceed 75% of your monthly income!!! ");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }
            };
            nud.Invoke(grossInc, v.GetTotalExp());
       
            //call method to display all expenses
            displayExp(a);

            Console.ReadLine();

        }

        public static int Accomodation()
        {
            Console.Write("Enter '1' if you are renting or '2' if you are buying a property : ");
            int option = Convert.ToInt32(Console.ReadLine());

            while ((option <= 0) || (option > 2))
            {
                Console.WriteLine("InValid Entry please try again!!! ");
                Console.Write("Enter '1' if you are renting or '2' if you are buying a property : ");
                option = Convert.ToInt32(Console.ReadLine());
            }
            return option;
        }

        public static Dictionary<string, double> allExp()
        {
            Console.WriteLine("\n\n**********************************************************************" +"\n\nEXPENSES  \n");

            //Estimated monthly tax deducted
            Console.Write("Enter estimated monthly tax deducted : ");
            double tax = Convert.ToDouble(Console.ReadLine());


            //Estimated monthly expenditure for :
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

            Dictionary<string, double> a = new Dictionary<string, double>();
            a.Add("Tax", tax);
            a.Add("Groceries", groceries);
            a.Add("Rates", watLight);
            a.Add("Travel", travCost);
            a.Add("Phone", phone);
            a.Add("Other", othExp);

            return a;
        }

        

        public static void displayExp(Dictionary<string, double> e)
        {
            // arranges the expenses in the dictionary in descending order 
            var dec = from expe in e orderby expe.Value descending select expe;

            //displays the expenses
            Console.WriteLine("\n**********************************************\nEXPENSES:\n***********************************************");
            foreach (KeyValuePair<string, double> expe in dec)
            {
                Console.WriteLine(" {0} : R{1}", expe.Key, expe.Value);
            }
            Console.ReadLine();

        }



        public static void Introduction()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\n\n\t\tBUDGET PLANNER" + "\n************************************************************************");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
