using System;
using System.Net.WebSockets;
using System.Runtime.ExceptionServices;

namespace DZ_2
{
    class Class1
    {
        static void Main(string[] args)
        {
            //Задание 1

            Console.Write("Ввдеите сторону A в прямоугольнике: ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Введите сторону B в прямоугольнике: ");
            int B = int.Parse(Console.ReadLine());
            Console.Write("Введите стоону C в квадрате: ");
            int C = int.Parse(Console.ReadLine());

            if (A * B > C)
            {
                Console.WriteLine($"Количество квадратов в прямоугольнике: {(A / C) * (B / C)} ");
                Console.WriteLine($"Площадь незанятой части прямоугольника: {A * B - ((A / C) * (B / C) * C * C)}");
            }
            else { Console.WriteLine("Ошибка"); }

            ////Задание 2

            double amount = 10000; // число изначально в 
            int K = 0; // количество месяцев
            Console.Write("Введите ваш процент, который не должен быть меньше 0 и больше 25 (пример 1.4): ");
            double P = double.Parse(Console.ReadLine());

            if (P > 0 && P < 25)
            {
                for (; amount < 11000; K++)
                {
                    amount = amount * (1 + P / 100);
                }
                Console.WriteLine($"Через {K} месецев/месяц у вас будет 11000 руб");
            }
            else { Console.WriteLine("Ошибка: не доступный процент"); }

            //Задание 3

            Console.Write("Введите первое число: ");
            int AInt = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int BInt = int.Parse(Console.ReadLine());

            if (AInt < BInt)
            {
                for (; AInt <= BInt; AInt++)
                {
                    for (int i = 0; i < AInt; i++)
                    {
                        Console.Write($"{AInt} ");
                    }
                    Console.WriteLine();
                }
            }
            else { Console.WriteLine("Ошибка первое число больше чем второе"); }

            //Задание 4

            Console.Write("Введите число для отзеркаливание: ");
            string number = Console.ReadLine();
            string revers = "";

            if (int.Parse(number) > 0)
            {
                for (int i = number.Length - 1; i >= 0; i--)
                {
                    revers += number[i];
                }
                Console.WriteLine(revers);
            }
            else { Console.WriteLine("Ошибка, число не может быть отрецательным "); }
        }
    }
}
