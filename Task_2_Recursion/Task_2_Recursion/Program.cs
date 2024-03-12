
/*
 
        Задача 2: 

        Напишите программу вычисления функции Аккермана
        с помощью рекурсии. Даны два неотрицательных числа m и n. 

        Пример

         m = 3, n = 2 -> A(m,n) = 29
 
 */



using System;


namespace Task_2_Recursion
{
    class AckermanFunctionDemo
    {

        static int ReadInt(string msg)
        {
            System.Console.WriteLine(msg);
            return Convert.ToInt32(Console.ReadLine());
        }

        static int AckermanFunction(int m, int n)
        {
            if (m == 0)
                return (n + 1);
            else if (m > 0 && n == 0)
                return AckermanFunction(m - 1, 1);
            else
                return AckermanFunction((m - 1), AckermanFunction(m, n - 1));
        }

        static void Main(string[] args)
        {

            int number_1 = ReadInt("Введите значение числа m ?");
            int number_2 = ReadInt("Введите значение числа n ?");
            System.Console.WriteLine(AckermanFunction(number_1, number_2));

        }
    }
}
