using System;
using static BasicMethods.MathsUtilities;
namespace BasicMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SolveLinerEquation(3, 6));
            Console.WriteLine(GetBiggerNumber(10, 6));
            Console.WriteLine(GCD(56, 49));
            Console.WriteLine(IsPrime(17));
            Console.WriteLine(IsPrime(18));
            Console.WriteLine(AreCoprime(12, 9));
        }
    }
}