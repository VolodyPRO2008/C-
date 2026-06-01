using System;
using System.Security.Cryptography;
using System.Xml;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace DZ_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1 

            Console.WriteLine("Задание 1");

            Random rnd = new Random();

            Console.Write("Введите сколько должно быть элементов в массиве: ");
            int size = int.Parse(Console.ReadLine());
            int fairNumbers = 0, oddNumbers = 0, uniqueNumbers = 0, counterUnigueNumber = 0; // четные цифры, нечетные цифры, уникальные цифры,счетчик уникальные числа 

            int[] arr = new int[size];
            Console.Write("Ваш массив сейчас: ");
            for (int i = 0; i < size; i++)
            {
                arr[i] = rnd.Next(10, 30);
                Console.Write($"{arr[i]} ");
            }

            Console.WriteLine();

            for (int i = 0; i < size; i++)
            {
                counterUnigueNumber = 0;
                for (int j = 0; j < size; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        counterUnigueNumber++;
                    }
                }
                if (counterUnigueNumber == 1)
                {
                    uniqueNumbers++;
                }
                if (arr[i] % 2 == 0)
                {
                    fairNumbers++;
                }
                else { oddNumbers++; }

            }
            Console.WriteLine($"Количество четных элементов: {fairNumbers}. Колчество нечетных элеметнов: {oddNumbers}. Колчество уникалльных цифр: {uniqueNumbers}");

            //Задание 2

            Console.WriteLine("Задание 2");

            Console.Write("Введите значение и приложение покажет количество цифр в массиве которые меньше чем данное число: ");
            int number = int.Parse(Console.ReadLine());

            size = rnd.Next(4, 10);
            int[] array = new int[size];
            int numberMini = 0; // Числа которые меньше чем число введенное пользователем

            Console.Write("Массив: ");
            for (int i = 0; i < size; i++)
            {
                array[i] = rnd.Next(1, number + 3);
                Console.Write($"{array[i]} ");
                if (array[i] < number)
                {
                    numberMini++;
                }
            }
            Console.WriteLine($"\nКоличество значений меньше чем {number}: {numberMini}");

            //Задание 3

            Console.WriteLine("Задание 3");

            Console.Write("Введите 3 цифры, и программа покажет сколько раз это число встречается в массиве: ");
            string numbers = Console.ReadLine();
            int countArray = rnd.Next(111111, 999999);
            string countArrayString = Convert.ToString(countArray);
            int count = 0;

            for (int i = 0; i < countArrayString.Length; i++)
            {
                if (countArrayString[i] == numbers[0] && countArrayString[i + 1] == numbers[1] && countArrayString[i + 2] == numbers[2])
                {
                    count++;
                }
            }
            Console.WriteLine($"Какой массив был {countArrayString}");

            Console.WriteLine($"Колчиество совпадений: {count}");

            //Задание 4
            Console.WriteLine("Задание 4");


            int[] firstArr = new int[10];
            int[] secondArr = new int[10];
            List<int> thirdMassiv = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                firstArr[i] = rnd.Next(1, 14);
                secondArr[i] = rnd.Next(1, 14);
            }

            for (int i = 0; i < 10; i++)
            {

                if (Array.Exists(firstArr, n => n == firstArr[i]) == true && Array.Exists(secondArr, n => n == firstArr[i]) == true && thirdMassiv.Contains(firstArr[i]) == false)
                {
                    thirdMassiv.Add(firstArr[i]);
                }

            }
            Console.Write("Первый массив: ");
            foreach (int i in firstArr) { Console.Write($"{i} "); }
            Console.Write("\nВторой массив: ");
            foreach (int i in secondArr) { Console.Write($"{i} "); }
            Console.Write("\nТретий массив: ");
            thirdMassiv.ForEach(x => Console.Write($"{x} "));
            Console.WriteLine();


            //Задание 5
            Console.WriteLine("Задание 5 ");

            int[,] arrD2 = new int[2, 3] { { 3, 24, 32 }, { 1, -4, -6 } };
            int min = 9999999;
            int max = 0;

            Console.Write("Массив: ");

            for (int i = 0; i < arrD2.GetLength(0); i++)
            {
                for (int j = 0; j < arrD2.GetLength(1); j++)
                {
                    if (arrD2[i, j] < min)
                    {
                        min = arrD2[i, j];
                    }
                    if (arrD2[i, j] > max)
                    {
                        max = arrD2[i, j];
                    }
                    Console.Write($"{arrD2[i,j]} ");
                }
            }
            Console.WriteLine($"\nМинимальное значение {min}, Максимальное значение {max}");

            //Задание 6
            Console.WriteLine("Задание 6");

            Console.Write("Введите любое предложение: ");
            string str = Console.ReadLine();
            int predloj = str.Count(' ');

            if (predloj != 0) { Console.WriteLine($"Колчичество слов в предложении: {predloj + 1} "); }
            else { Console.WriteLine($"Колчичество слов в предложении: 0 "); }

            //Задание 7

            Console.WriteLine("Задание 7");

            string slovo = "Hello world";
            Console.WriteLine($"Слово до переворотки: {slovo}");
            Console.Write("Слово после перевортки: ");
            for (int i = slovo.Length;i > 0; i--)
            {
                Console.Write($"{slovo[i-1]} ");
            }

            //Задание 8

            Console.WriteLine("\nЗадание 8");


            char[] vowels = new char[] { 'А', 'Е', 'Ё', 'И', 'О', 'У', 'Ы', 'Э', 'Ю', 'Я' };

            Console.Write("Введите предложение и приложение посчитает сколько раз в нем встричается главные буквы: ");
            string predloj2 = Console.ReadLine();
            int counter = predloj2.ToUpper().Count(vowels.Contains);

            Console.WriteLine($"Количество гласных букв: {counter} ");

            //Задание 9

            Console.WriteLine("Задание 9");

            Console.Write("Введите предложение и приложение посчитает сколько раз в нем встричается главные буквы: ");
            string predloj3 = Console.ReadLine();
            string[] words = predloj3.Split(' ');

            Console.Write("Введите строку которую хотите найти в предложение которые ввели выше: ");
            string slovo2 = Console.ReadLine();
            string[] found = Array.FindAll(words, t => t == slovo2);
            int counter2 = found.Length;

            Console.WriteLine($"Количество гласных букв: {counter2} ");




        }
    }
}