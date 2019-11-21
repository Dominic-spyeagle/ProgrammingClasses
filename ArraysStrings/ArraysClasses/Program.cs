using System;

namespace ArraysClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //FirstExample();
            //SecondExamples();
            double[] WeekTemperatures = { 1, 2.2, 3, 4.8, 5.9, 6, 7 };

        }

        private static void SecondExamples()
        {
            double[] WeekTemperatures = { 1, 2.2, 3, 4.8, 5.9, 6, 7 };
            double sum = 0;
            foreach (var temperature in WeekTemperatures)
                sum += temperature;
            double averageTemperature = sum / WeekTemperatures.Length;
            Console.WriteLine($"Average Temperture is{averageTemperature}");
        }

        private static void FirstExample()
        {
            int[] MyArray = new int[3];
            foreach (var MyElement in MyArray)
                Console.WriteLine(MyElement);


            MyArray[0] = 10;
            MyArray[1] = 60;
            MyArray[2] = 40;
            foreach (var MyElement in MyArray)
                Console.WriteLine(MyElement);
            for (int i = 0; i < MyArray.Length; i++)
                MyArray[i] += 3;

            foreach (var MyElement in MyArray)
                Console.WriteLine(MyElement);
        }
    }
}
