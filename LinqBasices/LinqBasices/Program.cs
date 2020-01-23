using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqBasics
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] grades = { 3, 2, 5, 8, 9, 3, 2, 5, 8, 9, 3, 2, 5, 8, 9 };

            //Features1(grades);
            //Feature2(grades);
            string[] names = { "Eve", "Abulla", "Boris", "Kateryna" };
            var sorted = names.OrderBy(x => x);
            foreach(var item in sorted )
            {
                Console.WriteLine(item);
            }
            var namesExist = names.Any(x =.x.EndsWith("a"));
            var allNamesLong = names.All(x => x.Length > 1);
        }

        private static void Feature2(double[] grades)
        {
            var myGoodgrades = grades
                 .Where(x => x > 3.5)
                 .OrderByDescending(x => x);
            foreach (var grade in myGoodgrades)
                Console.WriteLine(grade);
            var myFirstGrade = grades.First();
            var mylastGrade = grades.Last();

            var howManyTwos = grades.Count(x => x == 2);
            var myFavourtiveGrades = grades.Skip(3).Take(3);

            var ectsPoints = grades
                .Where(x => x > 2)
                .Select(x => x * 2)
                .OrderBy(x => x);
            foreach (var item in ectsPoints)
                Console.WriteLine(item);
        }
        private static void Features1(double[] grades)
        {
            double max = grades.Max();

            var positivegrades = grades.Where(x => x > 2);
            foreach (var grade in positivegrades)
                Console.WriteLine(grade);

            var evengrades = grades.Where(x => x % 2 == 0);
            foreach (var grade in evengrades)
                Console.WriteLine(grade);
        }
    }
}
