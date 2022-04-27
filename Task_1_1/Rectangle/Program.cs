/*
  Написать программу, которая определяет площадь прямоугольника со сторонами a и b. Если
пользователь вводит некорректные значения (отрицательные или ноль), должно выдаваться
сообщение об ошибке. Возможность ввода пользователем строки вида «абвгд» или нецелых чисел
игнорировать.
 */

using System;

namespace Rectangle
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длинну прямоугольника");
            string? str = Console.ReadLine();

            int length;
            int.TryParse(str, out length);
            if (length <= 0)
            {
                Console.WriteLine("Неправильный ввод длинны");
                return;
            }

            Console.WriteLine("Введите ширину прямоугольника");
            str = Console.ReadLine();

            int width;
            int.TryParse(str, out width);
            if(width <= 0)
            {
                Console.WriteLine("Неправильный ввод ширины");
                return;
            }

            Console.WriteLine($"Площадь прямоугольника: {length * width}");

        }

    }
}