/*
   Напишите программу, которая заменяет первую букву первого слова в предложении на заглавную.
   В качестве окончания предложения можете считать только «.|?|!». Многоточие и «?!» можете
   опустить.

   Пример:

   ВВОД: я плохо учил русский язык. забываю начинать предложения с заглавной. хорошо, что можно написать
   программу!
   ВЫВОД: Я плохо учил русский язык. Забываю начинать предложения с заглавной. Хорошо, что можно
   написать программу!
 */

using System;

namespace Validator
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение");
            string? str = Console.ReadLine();

            if(str != null)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (i == 0 && char.IsLetter(str[i]) && char.IsLower(str[i]))
                    {
                        Console.Write(char.ToUpper(str[i]));
                    }
                    else if (char.IsPunctuation(str[i]) && str[i] != ',')
                    {
                        for (int j = i; j < str.Length; j++)
                        {
                            if (char.IsLetterOrDigit(str[j]))
                            {
                                if (char.IsLetter(str[j]) && char.IsLower(str[j]))
                                {
                                    Console.Write(char.ToUpper(str[j]));
                                    i = j;
                                    break;
                                }
                                else
                                {
                                   Console.Write(str[j]);
                                    i = j;
                                    break;
                                }
                            }
                            Console.Write(str[j]);
                            i = j;
                        }
                        
                    }
                    else
                    {
                    Console.Write(str[i]);
                    }

                }
            }
        }
    }
}