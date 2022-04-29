/*
   Написать программу, которая генерирует случайным образом элементы массива 
(число элементов в массиве и их тип определяются разработчиком),
определяет для него максимальное и минимальное значения, сортирует массив и выводит полученный результат на экран.
Примечание: LINQ запросы и готовые функции языка (Sort, Max и т.д.) использовать в данном задании запрещается.
 */

using System;

namespace ArrayProcessing
{
    static class Program
    {
        static void Main(string[] args)
        {
            int size = 10;
            int[] arr = new int[size];
            Random randNum = new Random();

            for(int i = 0; i < size; i++)
            {
                arr[i] = randNum.Next(0, 10);
            }

            foreach(int i in arr)
                Console.Write(i + "\t");
            Console.WriteLine();

            int min = arr[0];

            foreach(int i in arr)
                if(min > i)
                    min = i;

            Console.WriteLine(min);

            int max = arr[0];

            foreach(int i in arr)
                if(max < i)
                    max = i;

            Console.WriteLine(max);

            int number;

            for(int i = 0; i < size; ++i)
                for(int j = 0; j < size; ++j)
                    if(arr[i] < arr[j])
                    {
                        number = arr[i];
                        arr[i] = arr[j];
                        arr[j] = number;
                    }

            foreach (int i in arr)
                Console.Write(i + "\t");
            Console.WriteLine();
        }
    }
}