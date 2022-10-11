﻿/* программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

void GetNumber (int Number)
{
    Console.WriteLine($" {Number} - ");
    for (int i = 1; i <= Number; i++)

        {
            double cube = Math.Pow(i, 3);
            Console.WriteLine($"{cube}. ");
        }
}

Console.WriteLine("Введите число: ");
int Number = int.Parse(Console.ReadLine()!);
GetNumber(Number);

