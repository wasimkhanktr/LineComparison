using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Comparison line1 = new Comparison();
            Comparison line2 = new Comparison();
            double LineOneLength = line1.calculate(1, 2, 1, 3);
            double LineTwoLength = line2.calculate(3, 4, 3, 4);
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