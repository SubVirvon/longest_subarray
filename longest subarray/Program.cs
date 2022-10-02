using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace longest_subarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arrayLength = 30;
            int[] array = new int[arrayLength];
            Random random = new Random();
            int minValue = 1;
            int maxValue = 4;
            int nowNumber;
            int previousNumber;
            int frequentNumber = 0;
            int rowLength = 1;
            int maxRow = 1; 

            Console.Write("Массив: ");

            for(int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(minValue, maxValue);
                Console.Write(array[i] + " ");
            }

            for(int i = 1; i < array.Length; i++)
            {
                nowNumber = array[i];
                previousNumber = array[i - 1];

                if(nowNumber == previousNumber)
                {
                    rowLength++;

                    if(maxRow < rowLength)
                    {
                        maxRow = rowLength;
                        frequentNumber = nowNumber;
                    }
                }
                else
                {
                    rowLength = 1;
                }
            }

            Console.WriteLine("\nЧисло " + frequentNumber + " повторяется " + maxRow + " раз");
            Console.ReadKey();
        }
    }
}
