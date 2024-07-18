// Задача 8: Напишите программу, которая на вход
// принимает число (N), а на выходе показывает все чётные
// числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
int digit = int.Parse(Console.ReadLine());
int startEvenNumber = 2;
while (startEvenNumber <= digit)
{
    System.Console.Write(startEvenNumber + ", ");
    startEvenNumber += 2;
}
