using System;

namespace ArraysClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //FirstExample();
            //SecondExamples();
            //ThirdExamples();

        }

        private static void ThirdExamples()
        {
            double[] WeekTemperatures = { 1, 2.2, 3, 4.8, 5.9, 6, 7 };
            double[] reverted = new double[7];
            for (int i = 0; i < WeekTemperatures.Length; i++)
            {
                reverted[i] = WeekTemperatures[6 - i];//reverted of array

            }
            DisplayArray(reverted);
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
                DisplayArray(MyArray);


            MyArray[0] = 10;
            MyArray[1] = 60;
            MyArray[2] = 40;

            foreach (var MyElement in MyArray)
                DisplayArray(MyArray);

            for (int i = 0; i < MyArray.Length; i++)
                MyArray[i] += 3;

            foreach (var MyElement in MyArray)
                DisplayArray(MyArray);

        }
        private static void DisplayArray<T>(T[] array)
        {
            foreach (var item in array)
                Console.WriteLine(item);
        }
    }

}
