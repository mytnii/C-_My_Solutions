/*
   Написать программу, которая заменяет все положительные элементы в трёхмерном массиве на нули.
  Число элементов в массиве и их тип определяются разработчиком.
 */

using System;

namespace NoPositive
{
    static class Program
    {
        static void Main(string[] args)
        {
            int size = 3;
            int[,,] matrix = new int[size, size, 5];

            Random randomNum = new Random();

            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    for (int k = 0; k < 5; k++)
                        matrix[i, j, k] = randomNum.Next(-10, 10);

            for (int i = 0; i < size; ++i)
            {
                for (int j = 0; j < size; ++j)
                {
                    for (int k = 0; k < 5; k++)
                        Console.Write(matrix[i, j, k] + "\t");
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            for (int i = 0; i < size; ++i)
            {
                for (int j = 0; j < size; ++j)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        if (matrix[i, j, k] > 0)
                            matrix[i, j, k] = 0;
                    }
                }
            }
            for (int i = 0; i < size; ++i)
            {
                for (int j = 0; j < size; ++j)
                {
                    for (int k = 0; k < 5; k++)
                        Console.Write(matrix[i, j, k] + "\t");
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}