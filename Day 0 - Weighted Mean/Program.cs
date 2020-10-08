using System;

namespace Day_0___Weighted_Mean
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double weight = 0.0;

            var size = Convert.ToInt32(Console.ReadLine());

            var stringArray1 = Console.ReadLine().Split(' ');
            var intArray1 = new double[100];



            for (var i = 0; i < size; i++)
            {
                intArray1[i] = double.Parse(stringArray1[i]);
            }

            var stringArray2 = Console.ReadLine().Split(' ');
            var intArray2 = new double[100];
            for (var j = 0; j < size; j++)
            {
                intArray2[j] = double.Parse(stringArray2[j]);
            }

            for (var k = 0; k < size; k++)
            {
                weight = (double)(weight + intArray1[k] * intArray2[k]);
                sum = (double)(sum + intArray2[k]);
            }

            var weightedMean = weight / sum;
            Console.WriteLine(weightedMean.ToString("0.0"));

        }
    }
}