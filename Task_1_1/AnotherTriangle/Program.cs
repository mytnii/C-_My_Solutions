/*
  Написать программу, которая запрашивает с клавиатуры число N и выводит на экран следующее
«изображение», состоящее из N строк:




        *
       ***
      *****
     *******
    *********
   ***********
  *************
 */

using System;

namespace AnotherTriangle
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк");
            string? str = Console.ReadLine();

            int value;
            int.TryParse(str, out value);
            
            if(value <= 0)
            {
                Console.WriteLine("Неверный ввод");

                return;
            }

            for(int i = 0; i < value; i++)
            {
                for(int j = 0; j < value * 2; j++)
                {
                  if(j >= value  - i && j <= value + i)
                        Console.Write('*');
                  else
                        Console.Write(' ');
                }
                    Console.WriteLine();
            }
        }
    }
}