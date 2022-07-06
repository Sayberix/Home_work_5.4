using System;

namespace Home_work_5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
            // 452-> 11
            // 82-> 10
            // 9012-> 12

            Console.WriteLine("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 0)
            {
                int digits = numberOfDigits(number);
                Console.WriteLine($"Сумма элементов введеного числа {number} равна: {sum(number, digits)}");
            }
            else
                Console.WriteLine("Введенное число должно быть больше '0'! Программа завершает работу!");
            
            int numberOfDigits(int number)  // Функция подсчета цифр в введенном числе
            {
                int digits = 0;
                while(number != 0)
                {
                    number /= 10;
                    digits++;
                }
                return (digits);
            }

            int sum(int number, int digits)  // Функция суммы элементов числа
            {
                int sum = 0;
                for (int i = digits - 1; i >= 0; i--)
                {
                    sum += number % 10;
                    number /= 10;
                }
                return (sum);
            }
        }
    }
}