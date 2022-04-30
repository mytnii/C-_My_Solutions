/*
   Напишите программу, которая удваивает в первой введённой строке все символы, принадлежащие
второй введённой строке.

Пример:

ВВОД 1: написать программу, которая
ВВОД 2: описание
ВЫВОД: ннааппииссаать ппроограамму, коотоораая
 */

using System;

namespace Doubler
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первую строку");
            string? str = Console.ReadLine();

            Console.WriteLine("Введите вторую строку");
            string? str2 = Console.ReadLine();

            bool symbol;

            if (str != null && str2 != null)
                for (int i = 0; i < str.Length; i++)
                {
                    symbol = false;

                    for(int j = 0; j < str2.Length; j++)
                    {
                        if(str[i] == str2[j])
                        {
                            symbol = true;
                        }
                        


                    }

                    if (symbol)
                        Console.Write($"{str[i]}{str[i]}");
                    else
                        Console.Write(str[i]);
                }
        }
    }
}