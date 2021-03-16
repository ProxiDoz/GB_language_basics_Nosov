using System;

namespace GB_language_basics_Nosov
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя: ");
            var name = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            var last_name = Console.ReadLine();
            Console.Write("Введите возраст: ");
            var age = Console.ReadLine();
            Console.Write("Введите рост: ");
            var growth = Console.ReadLine();
            Console.Write("Введите вес: ");
            var mass = Console.ReadLine();
            Console.WriteLine(name + " " + last_name + "\nВозраст: " + age + "\nРост: " + "\nРост: " + age + "\nВес: " + mass);
        }
    }
}
