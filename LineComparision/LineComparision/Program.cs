using System;

namespace LineComparision
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Line Comparison Computation Program");
            LineCalculating lineOne = new LineCalculating(8.0, 6.0, 6.0, 8.0);
            double lengthOne = lineOne.LengthCalculate();
            Console.WriteLine("The length of the first line is {0}", lengthOne);
            LineCalculating lineTwo = new LineCalculating(6.0, 7.0, 5.0, 9.0);
            double lengthTwo = lineTwo.LengthCalculate();
            Console.WriteLine("The length of the second line is {0}", lengthTwo);
            lineTwo.Check(lengthOne, lengthTwo);
        }
    }
}


