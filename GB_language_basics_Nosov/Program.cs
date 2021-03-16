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
            Console.WriteLine("1. " + name + " " + last_name + "\nВозраст: " + age + "\nРост: " + growth + "\nВес: " + mass + "\n\n");
            Console.WriteLine($"2. {name} {last_name}\nВозраст: {age}\nРост: {growth}\nВес: {mass}\n\n");
            Console.WriteLine(String.Format("3. {0} {1} \nВозраст: {2}\nРост: {3}\nВес: {4}\n\n", name, last_name, age, growth, mass));
        }
    }
}
