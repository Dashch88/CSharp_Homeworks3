// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();

Console.WriteLine("Введите N. Целое, положительное.");
int num = int.Parse(Console.ReadLine());
double cub = 1;

Console.WriteLine();

if (num < 1)
{
    Console.WriteLine("Вы ввели число не удовлетворяющее условиям.");
}
else
{
    for (int i = 1; i < num + 1; i++)
    {
        cub = Math.Pow(i, 3);
        Console.Write(cub + " ");
    }
}
Console.WriteLine();