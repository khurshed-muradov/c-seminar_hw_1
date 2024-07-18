// Задача 2: Напишите программу, которая на вход
// принимает два числа и выдаёт, какое число большее, а
// какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

System.Console.WriteLine("Введите первое число: ");
int firstDigit = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите первое число: ");
int secondDigit = int.Parse(Console.ReadLine());
if (firstDigit > secondDigit)
{
    System.Console.WriteLine("Max = " + firstDigit);
}
else
{
    System.Console.WriteLine("Max = " + secondDigit);
}