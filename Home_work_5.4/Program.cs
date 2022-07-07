using System;

namespace Home_work_5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
            //1, 2, 5, 7, 19-> [1, 2, 5, 7, 19]
            //6, 1, 33-> [6, 1, 33]

            int[] array = new int[8];
            fillArray(array);           // Функция заполнения массива случайными числами
            showArray(array);           // Функция выводит элементы массива в цикле

            void fillArray (int [] array)
            {
                for(int i = 0; i < array.Length; i++)
                {
                    array[i] = new Random().Next(1, 100);
                }
            }

            void showArray(int[] array)
            {
                Console.Write("Массив состоит из следующих элементов: ");
                for (int i = 0; i < array.Length; i++)
                {
                    if(i == 0)
                        Console.Write("[" + array[i] + ", ");
                    else
                        if (i == array.Length - 1)
                            Console.Write(array[i] + "]");
                        else
                            Console.Write(array[i] + ", ");
                }
            }
        }
    }
}