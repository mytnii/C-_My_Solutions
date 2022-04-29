/*
   Напишите программу, которая определяет среднюю длину слова во введённой текстовой строке.
   Учтите, что символы пунктуации на длину слов влиять не должны. Не стоит искать каждый
   символ-разделитель вручную: пожалейте своё время и используйте стандартные методы классов
   String и Char.
   Регулярные выражения не использовать.
   В случае дробного результата (х.5) – можете как оставить его таким, так и округлить. Стоит
   оставить комментарий в коде, указывающий, какое решение вы приняли.

   Пример:

   ВВОД: Викентий хорошо отметил день рождения: покушал пиццу, посмотрел кино, пообщался со
   студентами в чате
   ВЫВОД: 6
 */

using System;

namespace Averages
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст");
            string? str = Console.ReadLine();

            int symbolSize = 0;
            int stringSize = 0;

            if (str != null)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if
                        (
                        char.IsPunctuation(str[i]) || char.IsWhiteSpace(str[i]) &&
                        symbolSize != 0 && char.IsLetterOrDigit(str[i - 1])
                        )
                        stringSize++;
                    else if(i == str.Length - 1 && char.IsLetterOrDigit(str[i]))
                    {
                        stringSize++;
                        symbolSize++;
                    }
                    else
                        symbolSize++;
                }
                if (symbolSize != 0 && stringSize == 0)
                    stringSize++;
            }

            int averageStringLength = symbolSize / stringSize;

            Console.WriteLine(averageStringLength);
        }
    }
}