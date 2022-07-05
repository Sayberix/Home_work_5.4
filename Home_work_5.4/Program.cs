using System;

namespace Home_work_5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
            // 3, 5-> 243(3⁵)
            // 2, 4-> 16

            int[] array = new int[2];
            enterArray();                        
            Console.WriteLine($"Число: {array[0]} в степени: {array[1]} равно: {Math.Pow(array[0], array[1])}");

            void enterArray()
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == 0)
                    {
                        Console.WriteLine("Введите значение, которое будет возводится в степень: ");
                        array[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    if (i == 1)
                    {
                        Console.WriteLine("Введите степень, в которую возведется предыдущее введеное значение: ");
                        array[i] = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }
        }
    }
}
