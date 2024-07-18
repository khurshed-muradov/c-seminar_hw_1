// Задача 4: Напишите программу, которая принимает на
// вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
System.Console.WriteLine("Введите первое число: ");
int firstDigit = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите первое число: ");
int secondDigit = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите третье число: ");
int thirdDigit = int.Parse(Console.ReadLine()!);
int max = firstDigit;
if (secondDigit > max)
{
    max = secondDigit;

}
if (thirdDigit > max)
{
    max = thirdDigit;
}
else
{
    max = thirdDigit;
}
System.Console.WriteLine("-> " + max);
