using System;
using System.Diagnostics;
using System.Runtime.ExceptionServices;
using static System.Collections.Specialized.BitVector32;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Myproject
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Задание 1
            Console.WriteLine("Введите число от 1 до 100: ");
            string num = Console.ReadLine();
            int number = int.Parse(num);

            if (number >= 1 && number <= 100)
            {
                if (number % 5 == 0 && number % 3 == 0)
                {
                    Console.WriteLine("Fizz Buzz");
                }
                else if (number % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (number % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(number);
                }
            }
            else { Console.WriteLine("Ошибка диапазона"); }
            ////Задание 2

            Console.WriteLine("Введите число: ");
            string numberOne = Console.ReadLine();
            Console.WriteLine("Введите процент для первого числа: : ");
            string numberTwo = Console.ReadLine();

            int numberOneInt = int.Parse(numberOne);
            int numberTwoInt = int.Parse(numberTwo);

            Console.WriteLine("Получилось число " + (numberOneInt * numberTwoInt) / 100);

            ////Задание 3
            string numberFull = "";

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Введите " + (i + 1) + " Число: ");
                string chslo = Console.ReadLine();
                numberFull += chslo;
            }
            Console.WriteLine("Ваше число: " + numberFull);
            //Задание 4


            Console.WriteLine("Введите шестизначное число:");
            string sixDigitNumber = Console.ReadLine();
            int lengthNumber = sixDigitNumber.Length;
            char[] chars = sixDigitNumber.ToCharArray();

            Console.WriteLine("Введите первый порядковый номер цифры которую хотите изменить: ");
            string numberSelectionOne = Console.ReadLine();
            int numberSelectionOneInt = (int.Parse(numberSelectionOne) - 1);

            Console.WriteLine("Введите второй порядковый номер цифры которую хотите изменить: ");
            string numberSelectionTwo = Console.ReadLine();
            int numberSelectionTwoInt = (int.Parse(numberSelectionTwo) - 1);


            if (lengthNumber == 6 && (numberSelectionOne.Length == 1 && numberSelectionTwo.Length == 1))
            {
                char chars2 = chars[numberSelectionOneInt];
                chars[numberSelectionOneInt] = chars[numberSelectionTwoInt];
                chars[numberSelectionTwoInt] = chars2;

                sixDigitNumber = new string(chars);
                Console.WriteLine(sixDigitNumber);
            }
            else
            {
                Console.WriteLine("Ошибка");
            }

            //Задание 5


            Console.Write("Введите день: ");
            string day = Console.ReadLine();

            Console.Write("Введите месяц: ");
            string month = Console.ReadLine();
            int monthInt = int.Parse(month);

            Console.Write("Введите год: ");
            string year = Console.ReadLine();




            try
            {
                DateTime data = DateTime.Parse($"{day}-{month}-{year}");

                DayOfWeek dayOfWeek = data.DayOfWeek;

                if (monthInt <= 3)
                {
                    Console.WriteLine($"Winter {dayOfWeek}");
                }
                else if (monthInt <= 6)
                {
                    Console.WriteLine($"Spring {dayOfWeek}");
                }
                else if (monthInt <= 9)
                {
                    Console.WriteLine($"Summer {dayOfWeek}");
                }
                else if (monthInt <= 12)
                {
                    Console.WriteLine($"Autumn {dayOfWeek}");
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Ошибка: {ex}");
                Console.WriteLine("Не удалось обработать дату");
            }

            ////Задание 6

            string? userSelection;
            string temperature;
            int temperatureInt;

            Console.WriteLine("Выберите из чего хотите переводить?");
            Console.WriteLine("1) Из Фаренгейтов в Цельсию");
            Console.WriteLine("2) Из Цельсии в Фаренгет");

            userSelection = Console.ReadLine();

            if (userSelection == "1")
            {
                Console.WriteLine("Введите температуру в Фаренгейтов");
                temperature = Console.ReadLine();
                temperatureInt = int.Parse(temperature);
                Console.WriteLine($"Температура в Цельсии: {(temperatureInt - 32) * 5 / 9}");
            }
            else if (userSelection == "2")
            {
                Console.WriteLine("Введите температуру в Цельсии");
                temperature = Console.ReadLine();
                temperatureInt = int.Parse(temperature);
                Console.WriteLine($"Температура в Фаренгейтов: {(temperatureInt * 9 / 5) + 32}");
            }
            else
            {
                Console.WriteLine("Ошибка, введино не существующий выбор");
            }


            //Заднаие 7


            Console.Write("Введите первый диапозон: ");
            numberOne = Console.ReadLine();
            numberOneInt = int.Parse(numberOne);
            Console.Write("Введите второй диапозон: ");
            numberTwo = Console.ReadLine();
            numberTwoInt = int.Parse(numberTwo);

            if (numberOneInt >= numberTwoInt)
            {
                for (; numberTwoInt <= numberOneInt; numberTwoInt++)
                {
                    if (numberTwoInt % 2 == 0)
                    {
                        Console.WriteLine($"Это число четное в данном диапозоне: {numberTwoInt}");
                    }
                }
            }
            else if (numberTwoInt > numberOneInt)
            {
                for (; numberOneInt <= numberTwoInt; numberOneInt++)
                {
                    if (numberOneInt % 2 == 0)
                    {
                        Console.WriteLine($"Это число четное в данном диапозоне: {numberOneInt}");
                    }
                }
            }
        }
    }
}