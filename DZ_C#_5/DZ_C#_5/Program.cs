using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Net;
using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace DZ_5
{
    class Program
    {
        static void Square(int length, char symbol)
        {
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    Console.Write($"{symbol}");
                }
                Console.WriteLine();
            }
        }


        static bool Palindrome(string number)
        {
            for (int i = 0; i < number.Length; i++)
            {

                if (number[i] != number[(number.Length - 1) - i])
                {
                    return false;
                }
            }
            return true;
        }

        static int[] filteredArray(int[] originalArray, int[] filteringArray)
        {
            List<int> filteredArr = new List<int>();

            for (int i = 0; i < originalArray.Length; i++)
            {
                bool filter = false;
                for (int j = 0; j < filteringArray.Length; j++)
                {
                    if (originalArray[i] == filteringArray[j])
                    {
                        filter = true;
                        break;
                    }
                }
                if (filter == false)
                {
                    filteredArr.Add(originalArray[i]);
                }
            }
            return filteredArr.ToArray();

        }

        public class Website
        {
            private string _name;
            private string _path;
            private string _description;
            private string _ipAddress;

            public void Input()
            {
                Console.Write("Введите имя сайта: ");
                _name = Console.ReadLine();

                Console.Write("Введите путь сайта: ");
                _path = Console.ReadLine();

                Console.Write("Введите описание сайта: ");
                _description = Console.ReadLine();

                Console.Write("Введите ip адрес сайта: ");
                _ipAddress = Console.ReadLine();
            }

            public void Print()
            {

                Console.WriteLine("Данные сайта: ");

                Console.WriteLine($"Название сайта: {_name}");
                Console.WriteLine($"Путь сайта: {_path}");
                Console.WriteLine($"Описание сайта: {_description}");
                Console.WriteLine($"ip адрес сайта: {_ipAddress}");
            }

            public void SetName(string name)
            {
                if (!string.IsNullOrEmpty(name))
                {
                    _name = name;
                }
            }
            public void SetPath(string path)
            {
                if (!string.IsNullOrEmpty(path))
                {
                    _path = path;
                }
            }
            public void SetDescription(string description)
            {
                if (!string.IsNullOrEmpty(description))
                {
                    _description = description;
                }
            }
            public void SetIpAddress(string ipAddress)
            {
                if (!string.IsNullOrEmpty(ipAddress))
                {
                    _ipAddress = ipAddress;
                }
            }

            public string GetName() { return _name; }
            public string GetPath() { return _path; }
            public string GetDescription() { return _description; }
            public string GetIpAddress() { return _ipAddress; }

        }
        public class Magazine
        {

            private string _title;        // название журнала
            private int _foundingYear;    // год основания
            private string _description;  // описание журнала
            private string _phone;        // контактный телефон
            private string _email;        // контактный e-mail


            public void Input()
            {
                Console.WriteLine("Ввод данных журнала ");

                Console.Write("Введите название журнала: ");
                _title = Console.ReadLine();

                Console.Write("Введите год основания: ");
                _foundingYear = int.Parse(Console.ReadLine());

                Console.Write("Введите описание журнала: ");
                _description = Console.ReadLine();

                Console.Write("Введите контактный телефон: ");
                _phone = Console.ReadLine();

                Console.Write("Введите контактный e-mail: ");
                _email = Console.ReadLine();
            }


            public void Print()
            {
                Console.WriteLine("\n=== Данные журнала ===");
                Console.WriteLine($"Название журнала: {_title}");
                Console.WriteLine($"Год основания: {_foundingYear}");
                Console.WriteLine($"Описание журнала: {_description}");
                Console.WriteLine($"Контактный телефон: {_phone}");
                Console.WriteLine($"Контактный e-mail: {_email}");
            }


            public void SetTitle(string title)
            {
                if (!string.IsNullOrEmpty(title))
                {
                    _title = title;
                }
            }

            public void SetFoundingYear(int foundingYear)
            {
                if (foundingYear > 0 && foundingYear <= DateTime.Now.Year)
                {
                    _foundingYear = foundingYear;
                }
            }

            public void SetDescription(string description)
            {
                if (!string.IsNullOrEmpty(description))
                {
                    _description = description;
                }
            }

            public void SetPhone(string phone)
            {
                if (!string.IsNullOrEmpty(phone))
                {
                    _phone = phone;
                }
            }

            public void SetEmail(string email)
            {
                if (!string.IsNullOrEmpty(email))
                {
                    _email = email;
                }
            }


            public string GetTitle() { return _title; }
            public int GetFoundingYear() { return _foundingYear; }
            public string GetDescription() { return _description; }
            public string GetPhone() { return _phone; }
            public string GetEmail() { return _email; }
        }

        public class Shop
        {
            private string _name;         // название магазина
            private string _address;      // адрес
            private string _profile;      // описание профиля магазина
            private string _phone;        // контактный телефон
            private string _email;        // контактный e-mail

            public void Input()
            {
                Console.WriteLine("Ввод данных магазина ");

                Console.Write("Введите название магазина: ");
                _name = Console.ReadLine();

                Console.Write("Введите адрес магазина: ");
                _address = Console.ReadLine();

                Console.Write("Введите описание профиля магазина: ");
                _profile = Console.ReadLine();

                Console.Write("Введите контактный телефон: ");
                _phone = Console.ReadLine();

                Console.Write("Введите контактный e-mail: ");
                _email = Console.ReadLine();
            }


            public void Print()
            {
                Console.WriteLine("\n=== Данные магазина ===");
                Console.WriteLine($"Название магазина: {_name}");
                Console.WriteLine($"Адрес: {_address}");
                Console.WriteLine($"Профиль магазина: {_profile}");
                Console.WriteLine($"Контактный телефон: {_phone}");
                Console.WriteLine($"Контактный e-mail: {_email}");
            }


            public void SetName(string name)
            {
                if (!string.IsNullOrEmpty(name))
                {
                    _name = name;
                }
            }

            public void SetAddress(string address)
            {
                if (!string.IsNullOrEmpty(address))
                {
                    _address = address;
                }
            }

            public void SetProfile(string profile)
            {
                if (!string.IsNullOrEmpty(profile))
                {
                    _profile = profile;
                }
            }

            public void SetPhone(string phone)
            {
                if (!string.IsNullOrEmpty(phone))
                {
                    _phone = phone;
                }
            }

            public void SetEmail(string email)
            {
                if (!string.IsNullOrEmpty(email))
                {
                    _email = email;
                }
            }


            public string GetName() { return _name; }
            public string GetAddress() { return _address; }
            public string GetProfile() { return _profile; }
            public string GetPhone() { return _phone; }
            public string GetEmail() { return _email; }
        }




        static void Main(string[] args)
        {
            //Задание 1
            Console.WriteLine("Задание 1");

            Console.Write("Введите длину стороны квадрата: ");
            int length = int.Parse(Console.ReadLine());
            Console.Write("Введите символ из которого будет построин квадрат: ");
            char symbol = char.Parse(Console.ReadLine());

            Square(length, symbol);

            //Задание 2
            Console.WriteLine("Задание 2");

            Console.Write("Введите число программа проверит является ли оно палиндромом: ");
            string number = (Console.ReadLine());



            if (number.Length != 0)
            {
                foreach (char c in number)
                {
                    if (!char.IsDigit(c))
                    {
                        Console.WriteLine("Ошибка, введино не число, пожалуйста введите число");
                        break;
                    }
                }
                if (Palindrome(number) == true)
                {
                    Console.WriteLine("Число является палиндромом ");
                }
                else { Console.WriteLine("Число не является палиндромом "); }
            }
            else
            {
                Console.WriteLine("Ошибка, ничего не введино");
            }

            //Задание 3
            Console.WriteLine("Задание 3");

            Console.Write("Введите размер оригинального массива: ");
            int size = int.Parse(Console.ReadLine());
            int[] originalArray = new int[size];
            int[] filteringArray = new int[6];


            for (int i = 0; i < size; i++)
            {
                Console.Write($"Введите {i + 1} элемент массива: ");
                originalArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Введите массив для фильтрации 6 элементов ");

            for (int i = 0; i < 6; i++)
            {
                Console.Write($"Введите {i + 1} элемент массива: ");
                filteringArray[i] = int.Parse(Console.ReadLine());
            }

            int[] filterArr = filteredArray(originalArray, filteringArray);

            Console.Write("Изначальный массив: ");
            foreach (var item in originalArray) { Console.Write($"{item} "); }
            Console.Write("\nМассив для фильтрации: ");
            foreach (var item in filteringArray) { Console.Write($"{item} "); }
            Console.Write("\nОтфильтрованный массив:");
            foreach (var item in filterArr) { Console.Write($"{item} "); }

            //Задание 4
            Console.WriteLine("Задание 4");

            Website website = new Website();

            Console.WriteLine("Заполнения объекта через метод Input ");

            website.Input();

            Console.WriteLine("Вывод информации об объекте через метод Print ");

            website.Print();

            Console.WriteLine("Перезаполнения объекта через Set ");

            Console.Write("Переназовите страницу: ");
            string namesite = Console.ReadLine();
            website.SetName(namesite);

            Console.Write("Переукажите путь на страницу: ");
            string pathsite = Console.ReadLine();
            website.SetPath(pathsite);

            Console.Write("Заново перезапишите описание страницы: ");
            string descriptionsite = Console.ReadLine();
            website.SetDescription(descriptionsite);

            Console.Write("переназначте ip адрес: ");
            string ipAddresssite = Console.ReadLine();
            website.SetIpAddress(ipAddresssite);


            Console.WriteLine("Вывод через Get");

            Console.WriteLine($"\nВаше новое название сайта: {website.GetName()}\nВаш новый путь сайта: {website.GetPath()}\nВаше новое описание сайта: {website.GetDescription()}\nВаш новый ip сайта: {website.GetIpAddress()}");

            //Задание 5
            Console.WriteLine("Задание 5");

            Magazine magazine = new Magazine();


            Console.WriteLine("Заполнение объекта через метод Input");
            magazine.Input();

            Console.WriteLine("\nВывод информации об объекте через метод Print");
            magazine.Print();


            Console.WriteLine("\nПерезаполнение объекта через Set");

            Console.Write("Переназовите журнал: ");
            string newTitle = Console.ReadLine();
            magazine.SetTitle(newTitle);

            Console.Write("Переукажите год основания: ");
            int newYear = int.Parse(Console.ReadLine());
            magazine.SetFoundingYear(newYear);

            Console.Write("Заново перезапишите описание журнала: ");
            string newDescription = Console.ReadLine();
            magazine.SetDescription(newDescription);

            Console.Write("Переназначьте контактный телефон: ");
            string newPhone = Console.ReadLine();
            magazine.SetPhone(newPhone);

            Console.Write("Переназначьте контактный e-mail: ");
            string newEmail = Console.ReadLine();
            magazine.SetEmail(newEmail);


            Console.WriteLine("\nВывод через Get");
            Console.WriteLine($"Ваше новое название журнала: {magazine.GetTitle()}\nВаш новый год основания: {magazine.GetFoundingYear()}\nВаше новое описание журнала: {magazine.GetDescription()}\nВаш новый контактный телефон: {magazine.GetPhone()}\nВаш новый контактный e-mail: {magazine.GetEmail()}");

            //Задание 6
            Console.WriteLine("Задание 6");

            Shop shop = new Shop();


            Console.WriteLine("Заполнение объекта через метод Input");
            shop.Input();

            Console.WriteLine("\nВывод информации об объекте через метод Print");
            shop.Print();


            Console.WriteLine("\nПерезаполнение объекта через Set");

            Console.Write("Переназовите магазин: ");
            string newName = Console.ReadLine();
            shop.SetName(newName);

            Console.Write("Переукажите адрес магазина: ");
            string newAddress = Console.ReadLine();
            shop.SetAddress(newAddress);

            Console.Write("Заново перезапишите профиль магазина: ");
            string newProfile = Console.ReadLine();
            shop.SetProfile(newProfile);

            Console.Write("Переназначьте контактный телефон: ");
            string newPhone_2 = Console.ReadLine();
            shop.SetPhone(newPhone_2);

            Console.Write("Переназначьте контактный e-mail: ");
            string newEmail_2 = Console.ReadLine();
            shop.SetEmail(newEmail_2);


            Console.WriteLine("\nВывод через Get");
            Console.WriteLine($"\nВаше новое название магазина: {shop.GetName()}\nВаш новый адрес магазина: {shop.GetAddress()}\nВаш новый профиль магазина: {shop.GetProfile()}\nВаш новый контактный телефон: {shop.GetPhone()}\nВаш новый контактный e-mail: {shop.GetEmail()}");
        }
    }
}
