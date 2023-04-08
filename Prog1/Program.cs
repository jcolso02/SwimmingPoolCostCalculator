// Program 1
// Due: 09/30/2021
// By: S5034
// CIS 199-50



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            // Title
            //
            Console.WriteLine("Welcome to the EZ-Pools Cost Estimator");
            Console.WriteLine("");



            //
            // User Inputed Data
            //

            // Width
            Console.Write("Enter the max width of pool (in feet): ");
            double poolWidth;
            poolWidth = Convert.ToDouble(Console.ReadLine());

            // Length
            Console.Write("Enter the max length of pool (in feet): ");
            double poolLength;
            poolLength = Convert.ToDouble(Console.ReadLine());

            // Depth
            Console.Write("Enter the max depth of pool (in feet): ");
            double poolDepth;
            poolDepth = Convert.ToDouble(Console.ReadLine());

            //Materials
            Console.Write("Enter the materials price (per cubic yard): ");
            double materialPrice; 
            materialPrice = Convert.ToDouble(Console.ReadLine());

            //Excavation
            Console.Write("Enter whether excavation is needed (is this pool below ground?) ($15/yd^3) (1 = YES, 0 = NO): ");
            int poolExcavation;
            poolExcavation = Convert.ToInt32(Console.ReadLine());

            // Diving Board
            Console.Write("Will a diving board be installed? (+$50 to labor) (1 = YES, 0 = NO): ");
            int divingBoard;
            divingBoard = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");

            //
            // Calculations:
            //

            // Cubic Yards
            double cubicYards;
            cubicYards = (poolWidth * poolLength * poolDepth)/ 27;


            // Materials Cost
            double materialCost;
            double wastePercent = .10;
            materialCost = cubicYards * materialPrice;
            materialCost *= 1 + wastePercent;

            // Excavation Cost
            double excavationCost = 0;
            double excavationPrice = 15;

            if (poolExcavation == 1)
            {
                excavationCost = cubicYards * excavationPrice;
            }

            // Laboor Cost
            double laborRate = 3.25;
            double laborCost = laborRate * cubicYards;
            
            if (divingBoard == 1)
            {
                laborCost += 50;
            }

            // Total Cost
            double totalCost;
            totalCost = materialCost + excavationCost + laborCost;



            //
            // Rounding
            //

            cubicYards = Math.Round(cubicYards, 1);
            materialCost = Math.Round(materialCost, 2);
            excavationCost = Math.Round(excavationCost, 2);
            laborCost = Math.Round(laborCost, 2);
            totalCost = Math.Round(totalCost, 2);



            //
            // Output:
            //

            // Cubic Yards
            Console.WriteLine("Cubic Yards Needed:  " + cubicYards.ToString("F1"));

            // Material Cost
            Console.WriteLine("Materials Cost:     " + materialCost.ToString("C2"));
            
            // Excavation Cost
            Console.WriteLine("Excavation Cost:    " + excavationCost.ToString("C2"));
            
            // Labor Cost
            Console.WriteLine("Labor Cost:         " + laborCost.ToString("C2"));
            
            // Total Cost
            Console.WriteLine("Total Cost:         " + totalCost.ToString("C2"));



            //
            // Pause
            //

            Console.ReadLine();
            

        }
    }
}
