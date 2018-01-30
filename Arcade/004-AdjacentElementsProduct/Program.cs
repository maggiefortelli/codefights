using System;

namespace _004_AdjacentElementsProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[args.Length];
            for(int i=0; i<= args.Length - 1; i++)
                array[i] = int.Parse(args[i]);

            Console.WriteLine(AdjacentElementsProduct(array).ToString());
        }
        /* Given an array of integers, find the pair of adjacent elements that has the largest 
        product and return that product. */
        internal static int AdjacentElementsProduct(int[] inputArray) 
        {
            int largest = inputArray[0] * inputArray[1];
            for(int i=0; i <= inputArray.Length - 2; i++)
            {
                largest = inputArray[i] * inputArray[i+1] > largest ? inputArray[i] * inputArray[i+1] : largest;
            }
            return largest;
        }

    }
}
