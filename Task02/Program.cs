// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());

if (number < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    while (number > 999)
    {
        number = number / 10;
    }
    int digit = number % 10;
    Console.WriteLine($"{digit} третья цифра заданного числа");
}