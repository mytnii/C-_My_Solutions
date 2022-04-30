/*
   Напишите программу, которая считает количество слов, начинающихся с маленькой буквы.
   Предлоги, союзы и междометия считаются словами. Финальную точку в предложении (как и любой
   другой знак) можно не учитывать.
   Вариант без * - разделителем между словами считать ТОЛЬКО пробелы
   Вариант со * - разделители между словами могут быть любые: запятые, двоеточия, точки с
   запятой.

   Пример без *:

   ВВОД: Антон выпил кофе и послушал Стинга
   ВЫВОД: 4

   Пример со *:

   ВВОД: Антон хорошо начал утро: послушал Стинга, выпил кофе и посмотрел Звёздные Войны
   ВЫВОД: 8
 */

using System;

namespace Lowercase
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введитие предложение");
            string? str = Console.ReadLine();

            int countStrSpace = 0 ;

            if (str != null)
                for (int i = 0; i < str.Length; i++)
                    if
                        (
                        char.IsWhiteSpace(str[i]) && i > 0 &&
                        char.IsLetterOrDigit(str[i - 1]) &&
                        char.IsLetterOrDigit(str[i + 1]) &&
                        char.IsLower(str[i + 1])
                        )
                        countStrSpace++;
                    else if
                        (
                        i == 0 && char.IsLetterOrDigit(str[i]) &&
                        char.IsLower(str[i])
                        )
                        ++countStrSpace;

            Console.WriteLine(countStrSpace);

            int countStrAddSeparator = 0;

            if (str != null)
                for (int i = 0; i < str.Length; i++)
                    if
                        (
                        char.IsSeparator(str[i]) &&
                        char.IsLetterOrDigit(str[i + 1]) && char.IsLower(str[i + 1])
                        )
                        countStrAddSeparator++;
                    else if
                        (
                        i == 0 && char.IsLetterOrDigit(str[i]) &&
                        char.IsLower(str[i])
                        )
                        ++countStrAddSeparator;

            Console.WriteLine(countStrAddSeparator);
        }
    }
}