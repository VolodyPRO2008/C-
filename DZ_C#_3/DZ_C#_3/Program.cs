using System;
using System.Net.WebSockets;
using System.Collections.Generic;
using System.Collections.Concurrent;

namespace DZ_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1

            //Console.Write("Введите размер массива: ");
            //int size = int.Parse(Console.ReadLine());
            //List<int> list = new List<int>();
            //int zeroCounter = 0;
            //int numberList;



            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write($"Введите {i + 1} элемент массива (если будет 0, то о исчезнит из массива): ");
            //    numberList = int.Parse(Console.ReadLine());
            //    list.Add(numberList);
            //    if (list[i] == 0)
            //    {
            //        zeroCounter++;
            //        list[i]--;
            //    }
            //    else { list[i]--; }
            //}

            //if (zeroCounter != 0)
            //{
            //    for (int i = 0; i < zeroCounter; i++)
            //    {
            //        list.Remove(-1);
            //    }
            //}

            //foreach (int i in list) { Console.Write($"{i} "); }
            //Console.WriteLine("\n");

            ////Задание 2

            //Console.Write("Введите размер массива: ");
            //size = int.Parse(Console.ReadLine());
            //int[] arr = new int[size];




            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write($"Введите {i + 1} элемент массива (если будет 0, то о исчезнит из массива): ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //arr.Sort();
            //Console.WriteLine("Отсортированный массив");
            //foreach (int i in arr) { Console.Write($"{i} "); }
            //Console.WriteLine("\n\n");

            ////Задание 3

            Random rnd = new Random();
            //arr = new int[rnd.Next(5, 10)];
            //int Counter = 0;


            //Console.Write($"Создан массив {arr.Length}, укажите как вы думайте какое число есть в этом массиве: ");
            //int number = int.Parse(Console.ReadLine());

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = rnd.Next(6);
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (number == i)
            //    {
            //        Counter++;
            //    }
            //}
            //Console.WriteLine($"Количество раз которое встричается ваше число: {Counter} \n");


            //Задание 4


            Console.Write("Введите количество строк: ");
            int M = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов: ");
            int N = int.Parse(Console.ReadLine());

            int[,] multidimensionalArr = new int[M, N];

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    multidimensionalArr[i, j] = rnd.Next(10,30);
                }
            }
            Console.WriteLine("Массив до изменений: ");

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write($"{multidimensionalArr[i, j]} "); 
                }
                Console.WriteLine();
            }

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (j == 0) { 
                        int b = multidimensionalArr[i , j];
                        multidimensionalArr[i, j] = multidimensionalArr[i, N -1];
                        multidimensionalArr[i, N-1] = b;
                    }

                }

            }

            Console.WriteLine("Массив после изменений");

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write($"{multidimensionalArr[i, j]} ");
                }
                Console.WriteLine();
            }



        }
    }
}