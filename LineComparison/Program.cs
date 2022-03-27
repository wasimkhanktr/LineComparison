using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class Program
    {
        public static double calculate(int x1, int y1, int x2, int y2)
        {
            double length = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return length;
        }

        static void Main(string[] args)
        {
            double LineOneLength = calculate(1, 2, 1, 3);
            double LineTwoLength = calculate(3, 4, 3, 4);
            int val = LineOneLength.CompareTo(LineTwoLength);
            if (val == 0)
                Console.WriteLine("Length of lines are equal");
            else if (val > 0)
                Console.WriteLine("Length of line 1 is greater than line 2");
            else
                Console.WriteLine("Length of line 2 is greater than line 1");
        }
    }
}