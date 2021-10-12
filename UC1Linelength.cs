using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_Comparison_day_8
{
    class UC1Linelength
    {
            
                public static void LenghtOfSingleLine()
                {
                    Console.WriteLine("Enter co-ordinates (x1, y1): ");
                    double x1 = double.Parse(Console.ReadLine());
                    double y1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter co-ordinates (x2, y2): ");

                    double x2 = double.Parse(Console.ReadLine());
                    double y2 = double.Parse(Console.ReadLine());
                    double length = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
                    Console.WriteLine("The Length of the line is: " + length);

                }
            
        
    }
}
