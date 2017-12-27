using PracticeProgramming.InheritanceExamples.RationalNumbers;
using System;

namespace PracticeProgramming
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int num = -4;
            int den = 3;

            var rational = new SimplifiedRational(num, den);

            Console.WriteLine(rational.ToString());
        }
    }
}
