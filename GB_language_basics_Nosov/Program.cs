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
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите рост: ");
            float growth = float.Parse(Console.ReadLine());
            Console.Write("Введите вес: ");
            float mass = float.Parse(Console.ReadLine());
            float index_mass = CalcIndexMass(growth, mass);
            Console.WriteLine("\n" + name + " " + last_name + "\nВозраст: " + age + "\nРост: " + "\nРост: " + age + "\nВес: " + mass + "\nИнтедкс массы: " + index_mass);
        }

        private static float CalcIndexMass(float growth, float mass)
        {
            return mass/(growth*mass);
        }
    }
}
