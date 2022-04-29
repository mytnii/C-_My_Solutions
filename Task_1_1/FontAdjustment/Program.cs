/*
  Для форматирования текста надписи можно использовать различные начертания:
полужирное, курсивное и подчёркнутое, а также их сочетания.
Предложите способ хранения информации о форматировании текста надписи и напишите программу,
которая позволяет устанавливать и изменять начертание:
 */

using System;

namespace FontAdjustment
{
    static class Program
    {
        static void Main(string[] args)
        {
            string infoFormattazione = "None";
            Console.WriteLine($"Параметры натписи: {infoFormattazione}");
            string typeface;
            
         while(true)
            {

                Console.WriteLine("Выбирите начертание");
                Console.WriteLine("1 - bold, 2 - italic, 3 - underline, 0 - exit");
                string? str = Console.ReadLine();

                int value;
                int.TryParse(str, out value);

                if(value == 0 && str == value.ToString())
                    return;

                

                    switch(value)
                    {
                    case 1:

                        typeface = "Bold ";
                        if (infoFormattazione.Contains("None"))
                            infoFormattazione = typeface;
                        else if (infoFormattazione.Contains(typeface))
                           infoFormattazione = infoFormattazione.Remove(infoFormattazione.IndexOf(typeface), typeface.Length);
                        else
                            infoFormattazione += typeface;
                        Console.WriteLine($"Параметры натписи: {infoFormattazione}");
                        break;

                    case 2:

                        typeface = "Italic ";
                        if (infoFormattazione.Contains("None"))
                            infoFormattazione = typeface;
                        else if (infoFormattazione.Contains(typeface))
                            infoFormattazione = infoFormattazione.Remove(infoFormattazione.IndexOf(typeface), typeface.Length);
                        else
                            infoFormattazione += typeface;
                        Console.WriteLine("Параметры натписи: " + infoFormattazione);
                        break;

                    case 3:

                        typeface = "Underline "; if (infoFormattazione.Contains("None"))
                            infoFormattazione = typeface;
                        else if (infoFormattazione.Contains(typeface))
                            infoFormattazione = infoFormattazione.Remove(infoFormattazione.IndexOf(typeface), typeface.Length);
                        else
                            infoFormattazione += typeface;
                        Console.WriteLine($"Параметры написания: {infoFormattazione}");
                        break;

                    default:

                        Console.WriteLine("Некоректный выбор начертания");
                        break;

                    }
               
                
            }
        }
    }
}