﻿// Задача 6: Напишите программу, которая на вход
// принимает число и выдаёт, является ли число чётным
// (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
System.Console.WriteLine("Введите число: ");
int digit = int.Parse(Console.ReadLine()!);
int evenNumber = digit % 2;
if (evenNumber == 0)
{
    System.Console.WriteLine("-> да");
}
else
{
    System.Console.WriteLine("-> нет");
}