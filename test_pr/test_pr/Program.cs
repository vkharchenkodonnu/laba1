using System;

namespace test_pr
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Tom";
            int age = 33;
            bool isEmployed = false;
            double weight = 78.65;
            Console.WriteLine($"Имя: {name}");
            Console.WriteLine($"Возраст:{ age}");
            Console.WriteLine($"Вес: {weight}");
            Console.WriteLine($"Работает: {isEmployed} ");
            Console.WriteLine($"Имя: {name}  Возраст {age}  Вес {weight}");
            Console.WriteLine("Имя: {0}  Возраст: {2}  Вес: {1}kg", name, weight, age);
        }
    }
}
