using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_Comparison_day_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to line comparison");
            // UC1Linelength.LenghtOfSingleLine();
            //UC2Equalityofline.Equalityofline();
            //UC3Comparisonofline.Comparisonofline();
            UC4Compare2lengths obj = new UC4Compare2lengths();
            obj.userinput();
            obj.calculation();
            obj.comparison();
        }
    }
}
