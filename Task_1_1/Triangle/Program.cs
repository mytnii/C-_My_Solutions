/*
  Написать программу, которая запрашивает с клавиатуры число N и выводит на экран следующее
«изображение», состоящее из N строк:

*
**
***
****
*****
******
*******
********
*********
 */

using System;

namespace Triangle
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк");
            string? str = Console.ReadLine();

            int value;
            int.TryParse(str, out value);

            if( value <= 0)
            {
                Console.WriteLine("Неправельный ввод");
                return;
            }

            for (int i = 0; i < value; i++)
            {
                for (int j = 0; j <= i; j++)
                    Console.Write('*');
                Console.WriteLine();
            }
        }
    }
}