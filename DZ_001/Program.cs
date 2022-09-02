// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

void PrintNumbers(int start, int end)
{
    if (start > end)
    return;

    Console.Write($"{start} ");
    PrintNumbers(start + 1, end);
}

PrintNumbers(m, n);
