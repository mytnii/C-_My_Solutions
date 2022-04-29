/*
   Написать программу, которая запрашивает с клавиатуры число N и выводит на экран следующее
«изображение», состоящее из N треугольников:

     *
    ***
     *
    ***
   *****
     *
    ***
   *****
  *******
     *
    ***
   *****
  *******
 *********
 */

using System;

namespace X_MasTree
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество треугольников");
            string? str = Console.ReadLine();

            if(str == "0")
            {
                Console.WriteLine("Нулевое количество треугольников");
                return;
            }

            int numTriangles;
            int.TryParse(str, out numTriangles);

            if(numTriangles == 0)
            {
                Console.WriteLine("Неправельный ввод");
                return;
            }

            int lineTriangle = 2;

            for(int i = 0; i < numTriangles; i++)
            {
                for(int j = 0; j < lineTriangle; j++)
                {
                    for(int k = 0; k < numTriangles * 2 + 1; k++)
                    {
                        if (k >= numTriangles - j && k <= numTriangles + j)
                            Console.Write('*');
                        else
                            Console.Write(' ');
                    }
                    Console.WriteLine();
                }

                ++lineTriangle;
            }

            
        }
    }
}