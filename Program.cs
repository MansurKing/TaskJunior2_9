

using System;

namespace TaskJunior2._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstValue = 50;
            int finishValue = 151;
            int breakingValue;

            Console.WriteLine("Добро почаловать в мир чисел.\nСуть программы заключается в нахождении кол-ва чисел от 50 до 150 (включая эти числа), которые кратны N.\n" +
                              "Введите число N: ");
            breakingValue = Convert.ToInt32(Console.ReadLine());

            for (int i = firstValue; i < finishValue; i += breakingValue)
            {
                Console.WriteLine(i);
            }
        }
    }
}
