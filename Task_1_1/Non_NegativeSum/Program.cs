/*
   Написать программу, которая определяет сумму неотрицательных элементов в одномерном массиве.
   Число элементов в массиве и их тип определяются разработчиком.
 */

using System;

namespace Non_NegativeSum
{
    static class Program
    {
        static void Main(string[] args)
        {
            int size = 5;
            int[] arr = new int[size];

            Random random = new Random();

            for(int i = 0; i < size; i++)
            {
                arr[i] = random.Next(-10, 10);
            }

            foreach(int i in arr)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();

            int sumPositiveNumber = 0;

            foreach(int i in arr)
                if(i> 0)
                    sumPositiveNumber += i;

            Console.WriteLine(sumPositiveNumber);
        }
    }
}