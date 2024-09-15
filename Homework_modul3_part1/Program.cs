using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Homework_modul3_part1
{
    internal class Program
    {
        //Method for display square
        static void DisplaySquare(int sideLength, string symbol, bool isFilled = true)
        {
            for (int i = 0; i < sideLength; i++)
            {
                for (int j = 0; j < sideLength; j++)
                {
                    if (isFilled || i == 0 || i == sideLength - 1 || j == 0 || j == sideLength - 1)
                    {
                        Console.Write(symbol);
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }
        }
        //Method for check palindrome
        static bool IsPalindrome(int number)
        {
            // Конвертируем число в строку
            string str = number.ToString();
            int length = str.Length;

            // Проверяем строку на палиндром
            for (int i = 0; i < length / 2; i++)
            {
                if (str[i] != str[length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        //Method for filter array
        static int[] FilterArray(int[] originalArray, int[] filterArray)
        {
            // Способ с использованием LINQ
            //return originalArray.Where(x => !filterArray.Contains(x)).ToArray();

            int[] resultArray = new int[originalArray.Length];
            int count = 0;

            for (int i = 0; i < originalArray.Length; i++)
            {
                if (Array.IndexOf(filterArray, originalArray[i]) == -1)
                {
                    resultArray[count++] = originalArray[i];
                }
            }

            Array.Resize(ref resultArray, count);
            return resultArray;

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Set side of square->");
            int side = 0;
            if (!int.TryParse(Console.ReadLine(), out side))
            {
                Console.WriteLine("Invalid input");
            }
            Console.WriteLine("Set symbol of square->");
            string symbol = Console.ReadLine();

            DisplaySquare(side,symbol);
            Console.WriteLine();
//---------------------------------------------------------------------------------------------------------------------------

            // Пример использования метода для проверки палиндрома - IsPalindrome
            int number = 12321;
            Console.WriteLine($"{number} is palindrome: {IsPalindrome(number)}");
            Console.WriteLine();

//---------------------------------------------------------------------------------------------------------------------------
 
            int[] originalArray = { 1, 2, 6, -1, 88, 7, 6 };
            int[] filterArray = { 6, 88, 7 };

            int[] filteredArray = FilterArray(originalArray, filterArray);

            Console.WriteLine("Result filtered: " + string.Join(", ", filteredArray));

            //----------------------------------------------------------------------------------------------------------------------------

            Console.WriteLine();

            // Создание объекта с использованием конструктора
            Website website = new Website("Пример сайта", "https://example.com", "Описание примера", "192.168.0.1");



            // Ввод данных
            website.InputData();

            // Вывод данных
            website.DisplayData();

            // Пример использования свойств
            Console.WriteLine("Название сайта через свойство: " + website.Name);
            website.Name = "Новое название сайта";
            Console.WriteLine("Обновленное название сайта через свойство: " + website.Name);


            //Аналогично использование классов Journal и Shop
        }
    }
}
