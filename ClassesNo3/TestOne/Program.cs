
using System;

 
namespace testone
    {
        class Program
        {
            static void Main(string[] args)
            {
                int i;
                Console.Write("Enter a Number : ");
                i = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    Console.Write("Entered Number is an Even Number");
                }
                else
                {
                    Console.Write("Entered Number is an Odd Number");
                }
            Console.Read();

        }


    }
}