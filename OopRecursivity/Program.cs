using System;

namespace OopRecursivity
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            int n = ReadNumber("Element = ");

            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = ReadNumber($"Element at index {i}=");
            }

            int sum = RecursivityHelper.sumArray(array, n);
            int min = RecursivityHelper.minArray(array, n);

            Console.WriteLine($"Summ is: {sum}");
            Console.WriteLine($"Min is: {min}");
        }
        static int ReadNumber(string label)
        {
            Console.Write(label);
            string value = Console.ReadLine();
            int valueAsNumber = Convert.ToInt32(value);
            return valueAsNumber;
        }
    }
}
