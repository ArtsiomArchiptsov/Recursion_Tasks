

/*
   
        Задача 3: 
       
        Задайте произвольный массив. Выведете
        его элементы, начиная с конца. Использовать
        рекурсию, не использовать циклы.

        Пример

        [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 
 
 */


using System;


namespace Task_3_Recursion
{
    class ReversedArray
    {

        static int ReadInt(string msg)
        {
            System.Console.WriteLine(msg);
            return Convert.ToInt32(Console.ReadLine());
        }

        static int[] CreatArray(int size, int leftRange, int rightRange)
        {
            int[] array = new int[size];
            Random rnd = new Random();
            for (int i = 0; i < size; ++i)
            {
                array[i] = rnd.Next(leftRange, rightRange + 1);
            }
            return array;
        }

        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; ++i)
            {
                System.Console.Write(array[i] + "\t");
            }
        }

        static void ReversArray(int[] array, int first = 0)
        {
            if (first != array.Length)
            {
                ReversArray(array, first + 1);
                System.Console.Write(array[first] + "\t");
            }
        }


        static void Main(string[] args)
        {

            int size = ReadInt("Введите размер массива?");

            System.Console.WriteLine("Массив - ");

            int[] array = CreatArray(size, 1, 100);
            PrintArray(array);

            System.Console.WriteLine("\nРеверс массива - ");

            ReversArray(array);
        }
    }
}
