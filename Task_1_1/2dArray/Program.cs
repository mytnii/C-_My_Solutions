/*
   Элемент двумерного массива считается стоящим на чётной позиции,
   если сумма номеров его позиций по обеим размерностям является чётным числом
   (например, [1,1] — чётная позиция, а [1,2] — нет). Определить сумму элементов массива, 
   стоящих на чётных позициях.
 */

using System;

namespace TwoDArray
{
    static class Program
    {
        static void Main(string[] args)
        {
            int size = 5;
            int[,] matrix = new int[size, size];

            Random random = new Random();

            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    matrix[i, j] = random.Next(0, 10);

           for (int i = 0;i < size; i++)
            {
                for (int j = 0;j < size; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

           int sumEvenPosition = 0;

           for(int i = 0; i < size;i++)
            for(int j = 0; j < size;j++)
                    if((i + j) % 2 == 0)
                        sumEvenPosition += matrix[i, j];

           Console.WriteLine(sumEvenPosition);
        }
    }
}