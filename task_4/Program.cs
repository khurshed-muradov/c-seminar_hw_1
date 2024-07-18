// Задача 8: Напишите программу, которая на вход
// принимает число (N), а на выходе показывает все чётные
// числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
System.Console.WriteLine("Введите число: ");
int digit = int.Parse(Console.ReadLine());
List<int> numbers = new List<int>();
int startEvenNumber = 2;
while (startEvenNumber <= digit)
{
    numbers.Add(startEvenNumber);
    startEvenNumber += 2;
}
string result = string.Join(", ", numbers);
System.Console.Write(result);