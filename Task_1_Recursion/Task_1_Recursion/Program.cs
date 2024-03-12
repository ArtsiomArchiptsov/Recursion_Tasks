
/*
 
     Задача 1: 
   
     Задайте значения M и N. Напишите
     программу, которая выведет все натуральные числа
     в промежутке от M до N. Использовать рекурсию, не
     использовать циклы.

     Пример
 
     M = 1; N = 5 -> "1, 2, 3, 4, 5"
     M = 4; N = 8 -> "4, 5, 6, 7, 8"
 
 
 */



using System;


namespace Task_1_Recursion
{
    class OutputOfIntegers
    {

        static int ReadInt(string msg)
        {
            System.Console.WriteLine(msg);
            return Convert.ToInt32(Console.ReadLine());
        }

        static int PrintSequenceOfNumbers(int m, int n)
        {
            if (m > n)
            {
                if (m == n)
                {
                    System.Console.WriteLine(m);
                    return m;
                }
                System.Console.Write(m + " ");
                return PrintSequenceOfNumbers(m - 1, n);
            }
            else
            {
                if (m == n)
                {
                    System.Console.WriteLine(m);
                    return m;
                }
                System.Console.Write(m + " ");
                return PrintSequenceOfNumbers(m + 1, n);
            }
        }

        static void Main()
        {

            int number_1 = ReadInt("Введите значение числа M - ");
            int number_2 = ReadInt("Введите значение числа N - ");

            Console.WriteLine("Последовательность из чисел на интерввале от М = {0} до N = {1} будет иметь вид - ", number_1, number_2);

            PrintSequenceOfNumbers(number_1, number_2);

        }
    }
}
